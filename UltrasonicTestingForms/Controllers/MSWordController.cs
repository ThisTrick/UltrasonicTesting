using System;
using Word = Microsoft.Office.Interop.Word;

namespace UltrasonicTestingForms.Controllers
{
    public class MSWordController : IDisposable
    {
        private Word.Application App;
        private Word.Document Docx;
        private Word.Find Find;
        private Object Missing;
        private Object WdReplace;
        private Object Wrap;
        public MSWordController(string pathTemplate)
        {
            Object pathObject = pathTemplate as Object;
            Init(pathObject);
        }
        public MSWordController(object pathTemplate)
        {
            Init(pathTemplate);
        }

        private void Init(object pathTemplate)
        {
            App = new Word.Application();
            Docx = App.Application.Documents.Add(pathTemplate);
            Missing = Type.Missing;
            Find = App.Selection.Find;
            Wrap = Word.WdFindWrap.wdFindContinue;
            WdReplace = Word.WdReplace.wdReplaceAll;
        }
        public void DocxSave()
        {
            Docx.Save();
        }
        public void Replace(string findText, string newText)
        {
            Find.Text = findText;
            Find.Replacement.Text = newText;
            Find.Execute(FindText: Missing,
                MatchCase: false,
                MatchWholeWord: false,
                MatchWildcards: false,
                MatchSoundsLike: Missing,
                MatchAllWordForms: false,
                Forward: true,
                Wrap: Wrap,
                Format: false,
                ReplaceWith: Missing,
                Replace: WdReplace);
        }

        #region IDisposable
        private bool disposed = false;

        // реализация интерфейса IDisposable.
        public void Dispose()
        {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    App.ActiveDocument.Close();
                    App.Quit();
                }
                // освобождаем неуправляемые объекты
                disposed = true;
            }
        }

        // Деструктор
        ~MSWordController()
        {
            Dispose(false);
        }
        #endregion

    }
}
