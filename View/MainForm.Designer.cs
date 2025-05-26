using System.Drawing;
using System.Windows.Forms;

namespace Kursovik.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьВкладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификацияГрамматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерШрифтаВОкнеВыводавводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.регулярноеВыражениеДляКППОрганизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерыФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nINUKNationalInsuranceNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.POLIZBtn = new System.Windows.Forms.Button();
            this.NSTUlogo = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PagesCB = new System.Windows.Forms.ComboBox();
            this.TabLabel = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.StartEndButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.CutButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FolderButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NumericLB = new System.Windows.Forms.ListBox();
            this.UpperRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LowerTabs = new System.Windows.Forms.TabControl();
            this.ScanPage = new System.Windows.Forms.TabPage();
            this.ScanerDataGridView = new System.Windows.Forms.DataGridView();
            this.Mess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POLIZPage = new System.Windows.Forms.TabPage();
            this.POLIZDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regularki = new System.Windows.Forms.TabPage();
            this.RegularDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab8TabPage = new System.Windows.Forms.TabPage();
            this.Lab8DGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab8Btn = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSTUlogo)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.LowerTabs.SuspendLayout();
            this.ScanPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScanerDataGridView)).BeginInit();
            this.POLIZPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POLIZDGV)).BeginInit();
            this.Regularki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegularDGV)).BeginInit();
            this.Lab8TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lab8DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Firebrick;
            this.MainMenu.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файоToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.справкToolStripMenuItem,
            this.языкПрограммыToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(749, 31);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Главное меню";
            // 
            // файоToolStripMenuItem
            // 
            this.файоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файоToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.файоToolStripMenuItem.Name = "файоToolStripMenuItem";
            this.файоToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.файоToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.сохранитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.сохранитьКакToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выделитьВсёToolStripMenuItem,
            this.закрытьВкладкуToolStripMenuItem});
            this.правкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(85, 27);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.отменитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // повторитьToolStripMenuItem
            // 
            this.повторитьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.повторитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            this.повторитьToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.повторитьToolStripMenuItem.Text = "Повторить";
            this.повторитьToolStripMenuItem.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.вырезатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.копироватьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.вставитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // выделитьВсёToolStripMenuItem
            // 
            this.выделитьВсёToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.выделитьВсёToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.выделитьВсёToolStripMenuItem.Text = "Выделить всё";
            this.выделитьВсёToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсёToolStripMenuItem_Click);
            // 
            // закрытьВкладкуToolStripMenuItem
            // 
            this.закрытьВкладкуToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.закрытьВкладкуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.закрытьВкладкуToolStripMenuItem.Name = "закрытьВкладкуToolStripMenuItem";
            this.закрытьВкладкуToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.закрытьВкладкуToolStripMenuItem.Text = "Закрыть вкладку";
            this.закрытьВкладкуToolStripMenuItem.Click += new System.EventHandler(this.закрытьВкладкуToolStripMenuItem_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постановкаЗадачиToolStripMenuItem,
            this.грамматикаToolStripMenuItem,
            this.классификацияГрамматикиToolStripMenuItem,
            this.методАнализаToolStripMenuItem,
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem,
            this.тестовыйПримерToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem,
            this.исходныйКодПрограммыToolStripMenuItem,
            this.размерШрифтаВОкнеВыводавводаToolStripMenuItem,
            this.регулярноеВыражениеДляКППОрганизацииToolStripMenuItem,
            this.размерыФайловToolStripMenuItem,
            this.nINUKNationalInsuranceNumberToolStripMenuItem});
            this.текстToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // постановкаЗадачиToolStripMenuItem
            // 
            this.постановкаЗадачиToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.постановкаЗадачиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
            this.постановкаЗадачиToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
            this.постановкаЗадачиToolStripMenuItem.Click += new System.EventHandler(this.постановкаЗадачиToolStripMenuItem_Click);
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.грамматикаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.грамматикаToolStripMenuItem.Text = "Грамматика";
            this.грамматикаToolStripMenuItem.Click += new System.EventHandler(this.грамматикаToolStripMenuItem_Click);
            // 
            // классификацияГрамматикиToolStripMenuItem
            // 
            this.классификацияГрамматикиToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.классификацияГрамматикиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.классификацияГрамматикиToolStripMenuItem.Name = "классификацияГрамматикиToolStripMenuItem";
            this.классификацияГрамматикиToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.классификацияГрамматикиToolStripMenuItem.Text = "Классификация грамматики";
            this.классификацияГрамматикиToolStripMenuItem.Click += new System.EventHandler(this.классификацияГрамматикиToolStripMenuItem_Click);
            // 
            // методАнализаToolStripMenuItem
            // 
            this.методАнализаToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.методАнализаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            this.методАнализаToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.методАнализаToolStripMenuItem.Text = "Метод анализа";
            this.методАнализаToolStripMenuItem.Click += new System.EventHandler(this.методАнализаToolStripMenuItem_Click);
            // 
            // диагностикаИНейтрализацияОшибокToolStripMenuItem
            // 
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Name = "диагностикаИНейтрализацияОшибокToolStripMenuItem";
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Text = "Диагностика и нейтрализация ошибок";
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Click += new System.EventHandler(this.диагностикаИНейтрализацияОшибокToolStripMenuItem_Click);
            // 
            // тестовыйПримерToolStripMenuItem
            // 
            this.тестовыйПримерToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.тестовыйПримерToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
            this.тестовыйПримерToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            this.тестовыйПримерToolStripMenuItem.Click += new System.EventHandler(this.тестовыйПримерToolStripMenuItem_Click);
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.списокЛитературыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            this.списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.списокЛитературыToolStripMenuItem.Text = "Список литературы";
            this.списокЛитературыToolStripMenuItem.Click += new System.EventHandler(this.списокЛитературыToolStripMenuItem_Click);
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            this.исходныйКодПрограммыToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.исходныйКодПрограммыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            this.исходныйКодПрограммыToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            this.исходныйКодПрограммыToolStripMenuItem.Click += new System.EventHandler(this.исходныйКодПрограммыToolStripMenuItem_Click);
            // 
            // размерШрифтаВОкнеВыводавводаToolStripMenuItem
            // 
            this.размерШрифтаВОкнеВыводавводаToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.размерШрифтаВОкнеВыводавводаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.размерШрифтаВОкнеВыводавводаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.размерШрифтаВОкнеВыводавводаToolStripMenuItem.Name = "размерШрифтаВОкнеВыводавводаToolStripMenuItem";
            this.размерШрифтаВОкнеВыводавводаToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.размерШрифтаВОкнеВыводавводаToolStripMenuItem.Text = "Размер шрифта в окне вывода\\ввода";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.Color.Firebrick;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.toolStripComboBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_TextUpdate);
            this.toolStripComboBox1.TextUpdate += new System.EventHandler(this.toolStripComboBox1_TextUpdate);
            // 
            // регулярноеВыражениеДляКППОрганизацииToolStripMenuItem
            // 
            this.регулярноеВыражениеДляКППОрганизацииToolStripMenuItem.Name = "регулярноеВыражениеДляКППОрганизацииToolStripMenuItem";
            this.регулярноеВыражениеДляКППОрганизацииToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.регулярноеВыражениеДляКППОрганизацииToolStripMenuItem.Text = "Регулярное выражение для КПП организации";
            this.регулярноеВыражениеДляКППОрганизацииToolStripMenuItem.Click += new System.EventHandler(this.регулярноеВыражениеДляКППОрганизацииToolStripMenuItem_Click);
            // 
            // размерыФайловToolStripMenuItem
            // 
            this.размерыФайловToolStripMenuItem.Name = "размерыФайловToolStripMenuItem";
            this.размерыФайловToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.размерыФайловToolStripMenuItem.Text = "Размеры файлов";
            this.размерыФайловToolStripMenuItem.Click += new System.EventHandler(this.размерыФайловToolStripMenuItem_Click);
            // 
            // nINUKNationalInsuranceNumberToolStripMenuItem
            // 
            this.nINUKNationalInsuranceNumberToolStripMenuItem.Name = "nINUKNationalInsuranceNumberToolStripMenuItem";
            this.nINUKNationalInsuranceNumberToolStripMenuItem.Size = new System.Drawing.Size(483, 28);
            this.nINUKNationalInsuranceNumberToolStripMenuItem.Text = "NIN (UK National Insurance Number)";
            this.nINUKNationalInsuranceNumberToolStripMenuItem.Click += new System.EventHandler(this.nINUKNationalInsuranceNumberToolStripMenuItem_Click);
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(63, 27);
            this.пускToolStripMenuItem.Text = "Пуск";
            this.пускToolStripMenuItem.Click += new System.EventHandler(this.StartEndButton_Click);
            // 
            // справкToolStripMenuItem
            // 
            this.справкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызовСправкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.справкToolStripMenuItem.Name = "справкToolStripMenuItem";
            this.справкToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.справкToolStripMenuItem.Text = "Справка";
            // 
            // вызовСправкиToolStripMenuItem
            // 
            this.вызовСправкиToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.вызовСправкиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.вызовСправкиToolStripMenuItem.Name = "вызовСправкиToolStripMenuItem";
            this.вызовСправкиToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.вызовСправкиToolStripMenuItem.Text = "Вызов справки";
            this.вызовСправкиToolStripMenuItem.Click += new System.EventHandler(this.вызовСправкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // языкПрограммыToolStripMenuItem
            // 
            this.языкПрограммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.английскийToolStripMenuItem});
            this.языкПрограммыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.языкПрограммыToolStripMenuItem.Name = "языкПрограммыToolStripMenuItem";
            this.языкПрограммыToolStripMenuItem.Size = new System.Drawing.Size(167, 27);
            this.языкПрограммыToolStripMenuItem.Text = "Язык программы";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.русскийToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // английскийToolStripMenuItem
            // 
            this.английскийToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.английскийToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            this.английскийToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.английскийToolStripMenuItem.Text = "Английский";
            this.английскийToolStripMenuItem.Click += new System.EventHandler(this.английскийToolStripMenuItem_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BottomPanel.Controls.Add(this.Lab8Btn);
            this.BottomPanel.Controls.Add(this.POLIZBtn);
            this.BottomPanel.Controls.Add(this.NSTUlogo);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 458);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(749, 50);
            this.BottomPanel.TabIndex = 1;
            // 
            // POLIZBtn
            // 
            this.POLIZBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.POLIZBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.POLIZBtn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.POLIZBtn.Location = new System.Drawing.Point(652, 8);
            this.POLIZBtn.Name = "POLIZBtn";
            this.POLIZBtn.Size = new System.Drawing.Size(91, 35);
            this.POLIZBtn.TabIndex = 12;
            this.POLIZBtn.Text = "ПОЛИЗ";
            this.POLIZBtn.UseVisualStyleBackColor = true;
            this.POLIZBtn.Click += new System.EventHandler(this.POLIZBtn_Click);
            // 
            // NSTUlogo
            // 
            this.NSTUlogo.Image = global::Kursovik.Properties.Resources.Логотип_НГТУ_НЭТИ;
            this.NSTUlogo.Location = new System.Drawing.Point(4, 3);
            this.NSTUlogo.Name = "NSTUlogo";
            this.NSTUlogo.Size = new System.Drawing.Size(86, 43);
            this.NSTUlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NSTUlogo.TabIndex = 0;
            this.NSTUlogo.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopPanel.Controls.Add(this.PagesCB);
            this.TopPanel.Controls.Add(this.TabLabel);
            this.TopPanel.Controls.Add(this.InfoButton);
            this.TopPanel.Controls.Add(this.QuestionButton);
            this.TopPanel.Controls.Add(this.StartEndButton);
            this.TopPanel.Controls.Add(this.PasteButton);
            this.TopPanel.Controls.Add(this.CutButton);
            this.TopPanel.Controls.Add(this.CopyButton);
            this.TopPanel.Controls.Add(this.RightButton);
            this.TopPanel.Controls.Add(this.LeftButton);
            this.TopPanel.Controls.Add(this.SaveButton);
            this.TopPanel.Controls.Add(this.FolderButton);
            this.TopPanel.Controls.Add(this.FileButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 31);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(749, 56);
            this.TopPanel.TabIndex = 2;
            // 
            // PagesCB
            // 
            this.PagesCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PagesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PagesCB.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.PagesCB.FormattingEnabled = true;
            this.PagesCB.Location = new System.Drawing.Point(407, 25);
            this.PagesCB.MaximumSize = new System.Drawing.Size(429, 0);
            this.PagesCB.Name = "PagesCB";
            this.PagesCB.Size = new System.Drawing.Size(188, 27);
            this.PagesCB.TabIndex = 11;
            this.PagesCB.SelectedIndexChanged += new System.EventHandler(this.PagesCB_SelectedIndexChanged);
            // 
            // TabLabel
            // 
            this.TabLabel.AutoSize = true;
            this.TabLabel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.TabLabel.Location = new System.Drawing.Point(407, 6);
            this.TabLabel.Name = "TabLabel";
            this.TabLabel.Size = new System.Drawing.Size(142, 19);
            this.TabLabel.TabIndex = 4;
            this.TabLabel.Text = "Текущая вкладка:";
            // 
            // InfoButton
            // 
            this.InfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoButton.BackgroundImage")));
            this.InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfoButton.Location = new System.Drawing.Point(696, 6);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(43, 43);
            this.InfoButton.TabIndex = 10;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // QuestionButton
            // 
            this.QuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionButton.BackgroundImage")));
            this.QuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuestionButton.Location = new System.Drawing.Point(648, 6);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(43, 43);
            this.QuestionButton.TabIndex = 9;
            this.QuestionButton.UseVisualStyleBackColor = true;
            this.QuestionButton.Click += new System.EventHandler(this.вызовСправкиToolStripMenuItem_Click);
            // 
            // StartEndButton
            // 
            this.StartEndButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartEndButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartEndButton.BackgroundImage")));
            this.StartEndButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartEndButton.Location = new System.Drawing.Point(600, 6);
            this.StartEndButton.Name = "StartEndButton";
            this.StartEndButton.Size = new System.Drawing.Size(43, 43);
            this.StartEndButton.TabIndex = 8;
            this.StartEndButton.UseVisualStyleBackColor = true;
            this.StartEndButton.Click += new System.EventHandler(this.StartEndButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasteButton.BackgroundImage")));
            this.PasteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasteButton.Location = new System.Drawing.Point(359, 6);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(43, 43);
            this.PasteButton.TabIndex = 7;
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // CutButton
            // 
            this.CutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CutButton.BackgroundImage")));
            this.CutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CutButton.Location = new System.Drawing.Point(311, 6);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(43, 43);
            this.CutButton.TabIndex = 6;
            this.CutButton.UseVisualStyleBackColor = true;
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CopyButton.BackgroundImage")));
            this.CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyButton.Location = new System.Drawing.Point(263, 6);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(43, 43);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightButton.BackgroundImage")));
            this.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightButton.Location = new System.Drawing.Point(215, 6);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(43, 43);
            this.RightButton.TabIndex = 4;
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftButton.BackgroundImage")));
            this.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftButton.Location = new System.Drawing.Point(167, 6);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(43, 43);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = global::Kursovik.Properties.Resources.icons8_save_50;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Location = new System.Drawing.Point(108, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(43, 43);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FolderButton
            // 
            this.FolderButton.BackgroundImage = global::Kursovik.Properties.Resources.icons8_folder_50;
            this.FolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FolderButton.Location = new System.Drawing.Point(60, 6);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(43, 43);
            this.FolderButton.TabIndex = 1;
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // FileButton
            // 
            this.FileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FileButton.BackgroundImage")));
            this.FileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FileButton.Location = new System.Drawing.Point(12, 6);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(43, 43);
            this.FileButton.TabIndex = 0;
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Controls.Add(this.splitContainer1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 87);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(749, 371);
            this.MainPanel.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NumericLB);
            this.splitContainer1.Panel1.Controls.Add(this.UpperRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LowerTabs);
            this.splitContainer1.Size = new System.Drawing.Size(749, 371);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // NumericLB
            // 
            this.NumericLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NumericLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericLB.FormattingEnabled = true;
            this.NumericLB.IntegralHeight = false;
            this.NumericLB.ItemHeight = 19;
            this.NumericLB.Location = new System.Drawing.Point(4, 3);
            this.NumericLB.Name = "NumericLB";
            this.NumericLB.Size = new System.Drawing.Size(45, 180);
            this.NumericLB.TabIndex = 3;
            // 
            // UpperRichTextBox
            // 
            this.UpperRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpperRichTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.UpperRichTextBox.Location = new System.Drawing.Point(54, 3);
            this.UpperRichTextBox.Name = "UpperRichTextBox";
            this.UpperRichTextBox.ShortcutsEnabled = false;
            this.UpperRichTextBox.Size = new System.Drawing.Size(693, 180);
            this.UpperRichTextBox.TabIndex = 0;
            this.UpperRichTextBox.Text = "";
            this.UpperRichTextBox.WordWrap = false;
            this.UpperRichTextBox.TextChanged += new System.EventHandler(this.UpperRichTextBox_TextChanged);
            // 
            // LowerTabs
            // 
            this.LowerTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowerTabs.Controls.Add(this.ScanPage);
            this.LowerTabs.Controls.Add(this.POLIZPage);
            this.LowerTabs.Controls.Add(this.Regularki);
            this.LowerTabs.Controls.Add(this.Lab8TabPage);
            this.LowerTabs.Location = new System.Drawing.Point(0, 0);
            this.LowerTabs.Name = "LowerTabs";
            this.LowerTabs.SelectedIndex = 0;
            this.LowerTabs.Size = new System.Drawing.Size(749, 186);
            this.LowerTabs.TabIndex = 1;
            // 
            // ScanPage
            // 
            this.ScanPage.Controls.Add(this.ScanerDataGridView);
            this.ScanPage.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScanPage.Location = new System.Drawing.Point(4, 22);
            this.ScanPage.Name = "ScanPage";
            this.ScanPage.Padding = new System.Windows.Forms.Padding(3);
            this.ScanPage.Size = new System.Drawing.Size(741, 160);
            this.ScanPage.TabIndex = 0;
            this.ScanPage.Text = "Парсер";
            this.ScanPage.UseVisualStyleBackColor = true;
            // 
            // ScanerDataGridView
            // 
            this.ScanerDataGridView.AllowUserToAddRows = false;
            this.ScanerDataGridView.AllowUserToDeleteRows = false;
            this.ScanerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ScanerDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ScanerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScanerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mess,
            this.MessageColumn});
            this.ScanerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScanerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ScanerDataGridView.Name = "ScanerDataGridView";
            this.ScanerDataGridView.ReadOnly = true;
            this.ScanerDataGridView.Size = new System.Drawing.Size(735, 154);
            this.ScanerDataGridView.TabIndex = 0;
            // 
            // Mess
            // 
            this.Mess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mess.HeaderText = "Сообщение";
            this.Mess.Name = "Mess";
            this.Mess.ReadOnly = true;
            // 
            // MessageColumn
            // 
            this.MessageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MessageColumn.HeaderText = "Местоположение";
            this.MessageColumn.Name = "MessageColumn";
            this.MessageColumn.ReadOnly = true;
            this.MessageColumn.Width = 161;
            // 
            // POLIZPage
            // 
            this.POLIZPage.Controls.Add(this.POLIZDGV);
            this.POLIZPage.Location = new System.Drawing.Point(4, 22);
            this.POLIZPage.Name = "POLIZPage";
            this.POLIZPage.Size = new System.Drawing.Size(741, 160);
            this.POLIZPage.TabIndex = 1;
            this.POLIZPage.Text = "ПОЛИЗ";
            this.POLIZPage.UseVisualStyleBackColor = true;
            // 
            // POLIZDGV
            // 
            this.POLIZDGV.AllowUserToAddRows = false;
            this.POLIZDGV.AllowUserToDeleteRows = false;
            this.POLIZDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.POLIZDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.POLIZDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.POLIZDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.POLIZDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.POLIZDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POLIZDGV.Location = new System.Drawing.Point(0, 0);
            this.POLIZDGV.Name = "POLIZDGV";
            this.POLIZDGV.ReadOnly = true;
            this.POLIZDGV.Size = new System.Drawing.Size(741, 160);
            this.POLIZDGV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Сообщение";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Regularki
            // 
            this.Regularki.Controls.Add(this.RegularDGV);
            this.Regularki.Location = new System.Drawing.Point(4, 22);
            this.Regularki.Name = "Regularki";
            this.Regularki.Size = new System.Drawing.Size(741, 160);
            this.Regularki.TabIndex = 2;
            this.Regularki.Text = "Регулярки";
            this.Regularki.UseVisualStyleBackColor = true;
            // 
            // RegularDGV
            // 
            this.RegularDGV.AllowUserToAddRows = false;
            this.RegularDGV.AllowUserToDeleteRows = false;
            this.RegularDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RegularDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegularDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RegularDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegularDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.RegularDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegularDGV.Location = new System.Drawing.Point(0, 0);
            this.RegularDGV.Name = "RegularDGV";
            this.RegularDGV.ReadOnly = true;
            this.RegularDGV.Size = new System.Drawing.Size(741, 160);
            this.RegularDGV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Сообщение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Lab8TabPage
            // 
            this.Lab8TabPage.Controls.Add(this.Lab8DGV);
            this.Lab8TabPage.Location = new System.Drawing.Point(4, 22);
            this.Lab8TabPage.Name = "Lab8TabPage";
            this.Lab8TabPage.Size = new System.Drawing.Size(741, 160);
            this.Lab8TabPage.TabIndex = 3;
            this.Lab8TabPage.Text = "Лаба 8";
            this.Lab8TabPage.UseVisualStyleBackColor = true;
            // 
            // Lab8DGV
            // 
            this.Lab8DGV.AllowUserToAddRows = false;
            this.Lab8DGV.AllowUserToDeleteRows = false;
            this.Lab8DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lab8DGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lab8DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Lab8DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lab8DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.Lab8DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab8DGV.Location = new System.Drawing.Point(0, 0);
            this.Lab8DGV.Name = "Lab8DGV";
            this.Lab8DGV.ReadOnly = true;
            this.Lab8DGV.Size = new System.Drawing.Size(741, 160);
            this.Lab8DGV.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Сообщение";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Lab8Btn
            // 
            this.Lab8Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab8Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Lab8Btn.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lab8Btn.Location = new System.Drawing.Point(552, 8);
            this.Lab8Btn.Name = "Lab8Btn";
            this.Lab8Btn.Size = new System.Drawing.Size(91, 35);
            this.Lab8Btn.TabIndex = 13;
            this.Lab8Btn.Text = "Лаба 8";
            this.Lab8Btn.UseVisualStyleBackColor = true;
            this.Lab8Btn.Click += new System.EventHandler(this.Lab8Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 508);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(698, 488);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NSTUlogo)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.LowerTabs.ResumeLayout(false);
            this.ScanPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScanerDataGridView)).EndInit();
            this.POLIZPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.POLIZDGV)).EndInit();
            this.Regularki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegularDGV)).EndInit();
            this.Lab8TabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lab8DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem файоToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem текстToolStripMenuItem;
        private ToolStripMenuItem пускToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem повторитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private ToolStripMenuItem постановкаЗадачиToolStripMenuItem;
        private ToolStripMenuItem грамматикаToolStripMenuItem;
        private ToolStripMenuItem классификацияГрамматикиToolStripMenuItem;
        private ToolStripMenuItem методАнализаToolStripMenuItem;
        private ToolStripMenuItem диагностикаИНейтрализацияОшибокToolStripMenuItem;
        private ToolStripMenuItem тестовыйПримерToolStripMenuItem;
        private ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private ToolStripMenuItem справкToolStripMenuItem;
        private ToolStripMenuItem вызовСправкиToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Panel BottomPanel;
        private Panel TopPanel;
        private PictureBox NSTUlogo;
        private Panel MainPanel;
        private Button FileButton;
        private Button PasteButton;
        private Button CutButton;
        private Button CopyButton;
        private Button RightButton;
        private Button LeftButton;
        private Button SaveButton;
        private Button FolderButton;
        private Button InfoButton;
        private Button QuestionButton;
        private Button StartEndButton;
        private ToolStripMenuItem размерШрифтаВОкнеВыводавводаToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        public RichTextBox UpperRichTextBox;
        private Label TabLabel;
        private ComboBox PagesCB;
        private ToolStripMenuItem языкПрограммыToolStripMenuItem;
        private ToolStripMenuItem русскийToolStripMenuItem;
        private ToolStripMenuItem английскийToolStripMenuItem;
        private SplitContainer splitContainer1;
        private ListBox NumericLB;
        private DataGridView ScanerDataGridView;
        private ToolStripMenuItem закрытьВкладкуToolStripMenuItem;
        private TabControl LowerTabs;
        private TabPage ScanPage;
        private DataGridViewTextBoxColumn Mess;
        private DataGridViewTextBoxColumn MessageColumn;
        private TabPage POLIZPage;
        private DataGridView POLIZDGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button POLIZBtn;
        private ToolStripMenuItem регулярноеВыражениеДляКППОрганизацииToolStripMenuItem;
        private ToolStripMenuItem размерыФайловToolStripMenuItem;
        private ToolStripMenuItem nINUKNationalInsuranceNumberToolStripMenuItem;
        private TabPage Regularki;
        private DataGridView RegularDGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TabPage Lab8TabPage;
        private DataGridView Lab8DGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button Lab8Btn;
    }
}