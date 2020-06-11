using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace UltrasonicTesting.Controllers
{
    /// <summary>
    /// Класс для создания отчета моделирования в файле docx.
    /// </summary>
    public class MSWordController : IDisposable
    {
        private Word.Application App;
        private Word.Document Docx;
        private Word.Find Find;
        private Object Missing;
        private Object WdReplace;
        private Object Wrap;
        FileInfo AppFile;
        /// <summary>
        /// Основной конструктор.
        /// </summary>
        /// <param name="pathTemplate">Короткий путь к шаблону отчета. 
        /// Файл должен находится в одной директории с исполняемым файлом или наследнике.</param>
        public MSWordController(string pathTemplate)
        {
            App = new Word.Application();
            AppFile = new FileInfo(Application.ExecutablePath);
            string absolutePath = Path.Combine(AppFile.DirectoryName, pathTemplate);
            Docx = App.Application.Documents.Add(absolutePath);
            Missing = Type.Missing;
            Find = App.Selection.Find;
            Wrap = Word.WdFindWrap.wdFindContinue;
            WdReplace = Word.WdReplace.wdReplaceAll;
        }
        /// <summary>
        /// Сохраняет созданный файл docx.
        /// </summary>
        public void DocxSave()
        {
            Docx.Save();
        }
        /// <summary>
        /// Заменяет текст на заданный.
        /// </summary>
        /// <param name="findText">Текст который нужно заменить.</param>
        /// <param name="newText">Текст на который будет заменен.</param>
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
        /// <summary>
        /// Добавляет в конец файла docx изображение.
        /// Изображение временно добавляется в папку Images наследника директории исполняемого файла. 
        /// </summary>
        /// <param name="img">Изображение.</param>
        public void AddImage(Bitmap img)
        {
            string pathImg = @"Images\tmp.png";
            string absolutePath = Path.Combine(AppFile.DirectoryName, pathImg);
            img.Save(absolutePath);

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
        /// <summary>
        /// Нужен для корректной зачистки ресурсов. 
        /// </summary>
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
