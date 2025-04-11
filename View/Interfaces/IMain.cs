using Kursovik.Model;
using Kursovik.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik.View.Interfaces
{
    public interface IMain
    {
        //Это интерфейс. Здесь делать практически нечего


        //События для передачи презентеру
        event EventHandler<string> CreateFile;
        event EventHandler<string> OpenFile;
        event EventHandler<string> SaveFile;
        event EventHandler<string> StartEnd;
        event EventHandler Repeat;
        event EventHandler<string> SaveAsFile;
        event FormClosingEventHandler CloseProgram;
        event EventHandler<int> SelectPage;
        event EventHandler<Operation> ChangeLastUserOperation;
        event EventHandler NullLastUserOperation;
        event EventHandler<string> SetNewFileSavedStr;
        event EventHandler<string> SetNewFileOpenedStr;
        event EventHandler<string> SetNewFileCreatedStr;
        event EventHandler<string> ThrowLastTextToModel;
        event EventHandler<string> ThrowNewTextToModel;
        event EventHandler CloseCurrentPage;


        //Методы для вызова в представлении
        void Message(string message);
        void InsertFileText(string text);
        void RepeatToView(Operation operate);
        void AddTab (string fileName, int idOfPage);
        string GetText();
        void SetLastText(string text);
        void SetPage(int pageId);
        void SetFlagToComboBoxItem(int currentPageId, bool flag);
        void EditCurrentPageName(string newName);
        void DeleteDeletedPage();
        void DeleteAllPages();
        void ClearPairs();
        void FillScanerDGV(List<Lexem> lexemsList);
        void FillErrorsDGV(List<ErrorPair> errorsList);
    }
}
