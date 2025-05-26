using Kursovik.Model;
using Kursovik.Presenter;
using Kursovik.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;


namespace Kursovik.View
{
    public partial class MainForm : Form, IMain
    {
        //Необходимые для работы программы поля
        private MainPresenter _presenter;
        private int selectionIndex = 0;
        private string lastText = "";
        private bool isCutEnabled = false;
        private Dictionary<int, int> pairsOfPages = new Dictionary<int, int>();
        private bool isEnabledToTextChanged = true;

        //Конструктор класса
        public MainForm()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
            _presenter._res = new ResourceManager("Kursovik.Resources.Resource_ru", typeof(MainForm).Assembly);
            lastText = UpperRichTextBox.Text;
            UpperRichTextBox.DragEnter += new DragEventHandler(MainForm_DragEnter);
            UpperRichTextBox.DragDrop += new DragEventHandler(MainForm_DragDrop);
            UpperRichTextBox.AllowDrop = true;
            UpperRichTextBox.VScroll += (s, e) => SyncScroll();
            UpperRichTextBox.TextChanged += (s, e) => UpdateLineNumbers();
            UpperRichTextBox.SelectionChanged += (s, e) => SyncScroll();
            this.SizeChanged += (s, e) => UpdateLineNumbers();
            NumericLB.SelectionMode = SelectionMode.None;
            UpdateLineNumbers();
            
        }

        //Все события, назначенные на действия пользователя, те или иные
        public event EventHandler<string> CreateFile;
        public event EventHandler<string> OpenFile;
        public event EventHandler<string> SaveFile;
        public event EventHandler<string> StartEnd;
        public event EventHandler Repeat;
        public event EventHandler<string> SaveAsFile;
        public event FormClosingEventHandler CloseProgram;
        public event EventHandler<int> SelectPage;
        public event EventHandler<Operation> ChangeLastUserOperation;
        public event EventHandler NullLastUserOperation;
        public event EventHandler<string> SetNewFileSavedStr;
        public event EventHandler<string> SetNewFileOpenedStr;
        public event EventHandler<string> SetNewFileCreatedStr;
        public event EventHandler<string> ThrowLastTextToModel;
        public event EventHandler<string> ThrowNewTextToModel;
        public event EventHandler CloseCurrentPage;
        public event EventHandler<string> POLIZ;


        ////Блок работы со вкладками
        //Очистка словаря пар страниц
        public void ClearPairs()
        {
            pairsOfPages.Clear();
        }
        //Удаление удаляемой вкладки
        public void DeleteDeletedPage()
        {
            int startIndexToFix = PagesCB.SelectedIndex;
            Dictionary<int, int> buffDict = new Dictionary<int, int>();
            pairsOfPages.Remove(PagesCB.SelectedIndex);
            PagesCB.Items.Remove(PagesCB.SelectedItem);
            foreach (var pair in pairsOfPages)
            {
                if (pair.Key > startIndexToFix)
                {
                    buffDict.Add(pair.Key - 1, pair.Value);
                }
                else
                {
                    buffDict.Add(pair.Key, pair.Value);
                }
            }
            pairsOfPages = buffDict;

        }
        //Удаление всех вкладок
        public void DeleteAllPages()
        {
            isEnabledToTextChanged = false;
            UpperRichTextBox.Clear();
            PagesCB.Items.Clear();
            isEnabledToTextChanged = true;
        }
        //Редактирование имени текущей вкладки
        public void EditCurrentPageName(string newName)
        {
            PagesCB.Items[PagesCB.SelectedIndex] = newName;
            PagesCB.Update();
        }
        //Метод установки вкладки
        public void SetPage(int pageId)
        {
            PagesCB.SelectedIndex = pairsOfPages.FirstOrDefault(x => x.Value == pageId).Key;
        }
        //Метод добавления вкладки
        public void AddTab(string fileName, int idOfPage)
        {
            pairsOfPages.Add(PagesCB.Items.Count, idOfPage);
            PagesCB.Items.Add(fileName);
            PagesCB.SelectedIndex = pairsOfPages.FirstOrDefault(x => x.Value == idOfPage).Key;
        }
        //Закрытие вкладки
        private void закрытьВкладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseCurrentPage?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Обработка смены вкладки
        private void PagesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (PagesCB.Focused)
                {
                    SelectPage?.Invoke(this, pairsOfPages[PagesCB.SelectedIndex]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Обработка ввода комбинаций
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Сохранение
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveButton_Click(this, EventArgs.Empty);
                return true;
            }
            //Вырезать
            else if (keyData == (Keys.Control | Keys.X))
            {
                CutButton_Click(this, EventArgs.Empty);
            }
            //Копировать
            else if (keyData == (Keys.Control | Keys.C))
            {
                CopyButton_Click(this, EventArgs.Empty);
            }
            //Вставить
            else if (keyData == (Keys.Control | Keys.V))
            {
                PasteButton_Click(this, EventArgs.Empty);
            }
            //Открытие файла
            else if (keyData == (Keys.Control | Keys.O))
            {
                FolderButton_Click(this, EventArgs.Empty);
                return true;
            }
            //Выбрать всё
            else if (keyData == (Keys.Control | Keys.A))
            {
                UpperRichTextBox.SelectAll();
            }
            //Отмена
            else if (keyData == (Keys.Control | Keys.Z))
            {
                UpperRichTextBox.Undo();
            }
            //Создание нового файла
            else if (keyData == (Keys.Control | Keys.N))
            {
                FileButton_Click(this, EventArgs.Empty);
            }
            //Закрытие вкладки
            else if (keyData == (Keys.Control | Keys.W))
            {
                try
                {
                    CloseCurrentPage?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        ////Блок работы с нумерацией строк
        //Синхронизация скроллинга
        private void SyncScroll()
        {
            int firstIndex = UpperRichTextBox.GetCharIndexFromPosition(new Point(0, 3));
            int firstLine = UpperRichTextBox.GetLineFromCharIndex(firstIndex);

            if (firstLine < NumericLB.Items.Count)
            {
                NumericLB.TopIndex = firstLine;
            }
        }
        //Обновление нумерации
        private void UpdateLineNumbers()
        {
            int totalLines = UpperRichTextBox.Lines.Length;

            NumericLB.BeginUpdate();
            NumericLB.Items.Clear();
            for (int i = 1; i <= totalLines; i++)
            {
                NumericLB.Items.Add(i.ToString());
            }
            NumericLB.EndUpdate();

            SyncScroll();
        }
        //Кнопка перевода на другой шрифт
        private void toolStripComboBox1_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                UpperRichTextBox.Font = new Font("Bahnschrift", float.Parse(toolStripComboBox1.Text));
                ScanerDataGridView.Font = new Font("Bahnschrift", float.Parse(toolStripComboBox1.Text));
                NumericLB.Font = new Font("Bahnschrift", float.Parse(toolStripComboBox1.Text));
                NumericLB.ItemHeight = int.Parse(toolStripComboBox1.Text);
                UpdateLineNumbers();
                UpperRichTextBox.Update();
                ScanerDataGridView.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        ////Блок оповещений
        //Метод для оповещения путём MessageBox
        public void Message(string message)
        {
            MessageBox.Show(message);
        }


        ////Блок "раскидки" текста
        //Метод получения текста
        public string GetText()
        {
            return UpperRichTextBox.Text;
        }
        //Метод установки текста до изменения
        public void SetLastText(string text)
        {
            lastText = text;
        }
        //Метод установки текста в поле для ввода
        public void InsertFileText(string text)
        {
            UpperRichTextBox.Text = text;
        }
        //Метод "повтор в текст"
        public void RepeatToView(Operation operation)
        {
            try
            {
                if (operation.isDelete == false)
                {
                    int position = UpperRichTextBox.SelectionStart;
                    UpperRichTextBox.Text = UpperRichTextBox.Text.Insert(UpperRichTextBox.SelectionStart, operation.containtment);
                    lastText = UpperRichTextBox.Text;
                    UpperRichTextBox.Focus();
                    UpperRichTextBox.SelectionStart = position + operation.containtment.Length;
                }
                else
                {
                    if (UpperRichTextBox.SelectionStart > 0)
                    {
                        int position = UpperRichTextBox.SelectionStart;
                        UpperRichTextBox.Text = UpperRichTextBox.Text.Remove(position - 1, 1);
                        lastText = UpperRichTextBox.Text;
                        UpperRichTextBox.Focus();
                        UpperRichTextBox.SelectionStart = position - operation.containtment.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Отмена
        private void LeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpperRichTextBox.CanUndo)
                {
                    UpperRichTextBox.Undo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Повтор
        private void RightButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectionIndex = UpperRichTextBox.SelectionStart;
                Repeat?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Копирование
        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpperRichTextBox.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Вырезать
        private void CutButton_Click(object sender, EventArgs e)
        {
            try
            {
                isCutEnabled = true;
                UpperRichTextBox.Cut();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Вставить
        private void PasteButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpperRichTextBox.Paste();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Обработка кнопки "Удалить"
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UpperRichTextBox.SelectedText.Length > 0)
            {
                UpperRichTextBox.SelectedText = "";
            }
        }
        //Обработка кнопки "Выделить всё"
        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpperRichTextBox.SelectAll();
        }
        //Обработка ввода текста
        private void UpperRichTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isEnabledToTextChanged) return;

                string newText = UpperRichTextBox.Text;
                ThrowNewTextToModel?.Invoke(this, newText);
                int cursorPos = UpperRichTextBox.SelectionStart;
                if (!UpperRichTextBox.Focused)
                {
                    cursorPos = selectionIndex;
                }

                if (newText.Length > lastText.Length) // Ввод символа
                {
                    int diff = newText.Length - lastText.Length;
                    string insertedText = newText.Substring(cursorPos - (newText.Length - lastText.Length), newText.Length - lastText.Length);
                    if (diff == 1)
                    {
                        ChangeLastUserOperation?.Invoke(this, new Operation(insertedText, false, false, false));
                    }
                    else
                    {
                        ChangeLastUserOperation?.Invoke(this, new Operation(insertedText, false, false, true));
                    }
                }
                else if (newText.Length < lastText.Length) // Удаление символа
                {
                    int diff = lastText.Length - newText.Length;
                    string deletedText = lastText.Substring(cursorPos, diff);
                    if (diff == 1 && isCutEnabled == false)
                    {
                        ChangeLastUserOperation?.Invoke(this, new Operation(deletedText, false, true, false));
                    }
                    else
                    {
                        NullLastUserOperation?.Invoke(this, EventArgs.Empty);
                        isCutEnabled = false;
                    }
                }
                int firstVisibleLine = UpperRichTextBox.GetLineFromCharIndex(UpperRichTextBox.GetCharIndexFromPosition(new Point(0, 0)));
                lastText = newText;
                UpperRichTextBox.Focus();
                ThrowLastTextToModel?.Invoke(this, lastText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        ////Блок перевода
        //Метод для перевода интерфейса
        private void UpdateControlsText(Control control, ResourceManager res)
        {
            ScanerDataGridView.Columns[0].HeaderText = res.GetString("Mess");
            ScanerDataGridView.Columns[1].HeaderText = res.GetString("MessageColumn");
            _presenter.CloseProgramStr = res.GetString("CloseProgramStr");
            _presenter.CloseSavedStr = res.GetString("CloseSavedStr");
            _presenter.CloseUnsavedStr = res.GetString("CloseUnsavedStr");
            _presenter.MessageNoPathStr = res.GetString("MessageNoPathStr");
            _presenter.SaveNoPathStr = res.GetString("SaveNoPathStr");
            TabLabel.Text = res.GetString("TabLabel");
            SetNewFileSavedStr?.Invoke(this, res.GetString("FileSaved"));
            SetNewFileOpenedStr?.Invoke(this, res.GetString("FileOpened"));
            SetNewFileCreatedStr?.Invoke(this, res.GetString("FileCreated"));

            foreach (var item in this.MainMenuStrip.Items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    UpdateMenuItems(menuItem, res);
                }
            }
        }
        //Метод обновления текста MenuStrip
        private void UpdateMenuItems(ToolStripMenuItem menuItem, ResourceManager res)
        {
            if (!string.IsNullOrEmpty(menuItem.Name))
            {
                string newText = res.GetString(menuItem.Name);
                if (!string.IsNullOrEmpty(newText))
                    menuItem.Text = newText;
            }


            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    UpdateMenuItems(subMenuItem, res);
                }
            }
        }
        //Метод для установки\удаления флажка "* " при изменении\сохранении
        public void SetFlagToComboBoxItem(int pageToEditId, bool flag)
        {
            if (flag)
            {
                string currentPageName = PagesCB.Items[pairsOfPages.FirstOrDefault(x => x.Value == pageToEditId).Key].ToString();
                if (currentPageName.StartsWith("* "))
                {
                    PagesCB.Items[pairsOfPages.FirstOrDefault(x => x.Value == pageToEditId).Key] = PagesCB.Items[pairsOfPages.FirstOrDefault(x => x.Value == pageToEditId).Key].ToString().Remove(0, 2);
                }
            }
            else
            {
                string currentPageName = PagesCB.Items[pairsOfPages.FirstOrDefault(x => x.Value == pageToEditId).Key].ToString();
                if (!currentPageName.StartsWith("* "))
                {
                    PagesCB.Items[pairsOfPages.FirstOrDefault(x => x.Value == pageToEditId).Key] = "* " + currentPageName;
                }
            }
        }
        //Выбор русского языка
        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
                _presenter._res = new ResourceManager("Kursovik.Resources.Resource_ru", typeof(MainForm).Assembly);
                UpdateControlsText(this, _presenter._res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Выбор английского языка
        private void английскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                _presenter._res = new ResourceManager("Kursovik.Resources.Resource_en", typeof(MainForm).Assembly);
                UpdateControlsText(this, _presenter._res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        ////Блок работы с файлом
        //Создание файла
        private void FileButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog.FileName;
                CreateFile?.Invoke(this, saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Открытие готового файла
        private void FolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = openFileDialog.FileName;
                isEnabledToTextChanged = false;
                OpenFile?.Invoke(this, filename);
                isEnabledToTextChanged = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Сохранение файла
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFile?.Invoke(this, UpperRichTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Сохранить как
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAsFile?.Invoke(this, UpperRichTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        ////Блок "не для первой лабы"
        //Пуск
        private void StartEndButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartEnd?.Invoke(this, UpperRichTextBox.Text.Trim().Replace("  ", " ").Replace("\t", "").Replace("\n", "").Replace("\r", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Обработка закрытия программы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProgram?.Invoke(this, e);
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        ////Блок обработки Drag&Drop
        //Обработка Drag&Drop
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Обработка Drag&Drop
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string filePath in files)
                {
                    if (File.Exists(filePath))
                    {
                        OpenFile?.Invoke(this, filePath);
                    }
                    else
                    {
                        MessageBox.Show("Невозможно открыть файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        ////Блок информации о сканировании
        //Заполнение ScanerDGV
        public void FillScanerDGV(List<Lexem> lexemsList)
        {
            ScanerDataGridView.Rows.Clear();
            foreach (var item in lexemsList)
            {
                ScanerDataGridView.Rows.Add(item.lexemCode,item.lexemName,item.lexemContaintment,item.lexemStartPosition+1 + "-"+item.lexemEndPosition);
            }
        }
        public void FillErrorsDGV(List<ErrorPair> errorsList)
        {
            ScanerDataGridView.Rows.Clear();
            foreach (var item in errorsList)
            {
                ScanerDataGridView.Rows.Add(item.errorMessage, $"{item.posStart} - {item.posEnd}");
            }
        }

        public void FillPOLIZ(List<string> messagesList)
        {
            POLIZDGV.Rows.Clear();
            foreach (string msg in messagesList)
            {
                POLIZDGV.Rows.Add(msg);
            }
        }


        ////Блок вспомогательных элементов
        //Справка
        private void вызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Путь к временной папке
                string tempPath = Path.Combine(Path.GetTempPath(), "Help.chm");

                // Записываем ресурс во временный файл
                System.IO.File.WriteAllBytes(tempPath, Kursovik.Properties.Resources.Help);

                // Проверяем, что файл действительно существует
                if (System.IO.File.Exists(tempPath))
                {
                    // Открываем справку
                    Help.ShowHelp(this, tempPath);
                }
                else
                {
                    MessageBox.Show("Файл справки не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии справки: " + ex.Message);
            }
        }
        //О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramCard programCard = new ProgramCard();
            programCard.Show();
        }

        private void исходныйКодПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OriginCode originCode = new OriginCode();
            originCode.Show();
        }

        private void списокЛитературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Literature literature = new Literature();
            literature.Show();
        }

        private void тестовыйПримерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
        }

        private void диагностикаИНейтрализацияОшибокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Irons irons = new Irons();
            irons.Show();
        }

        private void методАнализаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalysisMethod analysisMethod = new AnalysisMethod();
            analysisMethod.Show();
        }

        private void классификацияГрамматикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grammar grammar = new Grammar();
            grammar.Show();
        }

        private void грамматикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrammarMain grammarMain = new GrammarMain();
            grammarMain.Show();
        }

        private void постановкаЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mission mission = new Mission();
            mission.Show();
        }

        private void POLIZBtn_Click(object sender, EventArgs e)
        {
            POLIZ?.Invoke(this, UpperRichTextBox.Text.Trim().Replace("  ", " ").Replace("\t", "").Replace("\n", "").Replace("\r", ""));
        }

        private void регулярноеВыражениеДляКППОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"\b\d{4}\d{2}\d{3}\b";
            FindSubstring(pattern);
        }

        private void размерыФайловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"\b\d+(?:\.\d+)?\s?(?:KB|MB|GB|TB)\b";
            FindSubstring(pattern);
        }

        private void nINUKNationalInsuranceNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = @"\b(?!BG|GB|KN|NK|NT|TN|ZZ)(?!.*[DFIQUV])[A-CEGHJ-NPR-TW-Z]{2}\d{6}[A-D]?\b";
            FindSubstring(pattern);
        }

        private void FindSubstring(string pattern)
        {
            RegularDGV.Rows.Clear();
            UpperRichTextBox.SelectAll();
            UpperRichTextBox.SelectionBackColor = UpperRichTextBox.BackColor;
            string text = UpperRichTextBox.Text;
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                int startIndex = match.Index;
                int length = match.Length;
                string result = $"Найдено: \"{match.Value}\" (позиция: {startIndex})";
                RegularDGV.Rows.Add(result);
                UpperRichTextBox.Select(startIndex, length);
                UpperRichTextBox.SelectionBackColor = Color.Red;
            }
            UpperRichTextBox.SelectionLength = 0;
        }
        
        private void Lab8Btn_Click(object sender, EventArgs e)
        {
            string input = UpperRichTextBox.Text.Trim().Replace("  ", " ").Replace("\t", "").Replace("\n", "").Replace("\r", "");
            Lab8Analyzer.Parser parser = new Lab8Analyzer.Parser(input);
            parser.Parse();
            Lab8DGV.Rows.Clear();
            if (parser.Errors != null)
            {
                foreach (var error in parser.Errors)
                {
                    Lab8DGV.Rows.Add($"Ошибка: {error.Message} (позиция {error.Position})");
                }
            }
        }
    }
}
