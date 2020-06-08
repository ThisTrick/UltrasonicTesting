using System;
using System.Drawing;
using System.Windows.Forms;
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
            App = new Word.Application();
            System.IO.FileInfo file = new System.IO.FileInfo(Application.ExecutablePath);
            string absolutePath = System.IO.Path.Combine(file.Directory.FullName, pathTemplate);
            Docx = App.Application.Documents.Add(absolutePath);
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

        public void AddImage(Bitmap img)
        {
            string pathImg = @"Images\tmp.png";
            img.Save(pathImg);
            System.IO.FileInfo file = new System.IO.FileInfo(Application.ExecutablePath);
            string absolutePath = System.IO.Path.Combine(file.Directory.FullName, pathImg);
            // Перемещение курсора в конец файла
            Word.Range Range = Docx.Range(0, Docx.Content.End);
            object dir = Word.WdCollapseDirection.wdCollapseEnd;
            Range.Collapse(ref dir);
            Range.Select();
            // Вставка рисунка 
            Docx.Application.Selection.InlineShapes.AddPicture(absolutePath);
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
