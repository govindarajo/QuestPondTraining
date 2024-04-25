using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MEF;

namespace MEFNamespce
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    var txtEditor = new TextEditor();

        //    txtEditor.PerformSpellCheck("Hello");
        //}
    }
    public class TextEditor
    {
        [ImportMany]
        public IEnumerable<iSpellChecker> SpellCheckers { get; set; }

        public TextEditor()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);

            container.ComposeParts(this);
        }

        public void PerformSpellCheck(string txt)
        {
            foreach(var spellChecker in SpellCheckers)
            {
                spellChecker.CheckSpelling(txt);
            }
        }
    }

    public interface iSpellChecker
    {
        string CheckSpelling(string text);
    }

    [Export(typeof(iSpellChecker))]
    public class EnglishSpellCheker : iSpellChecker
    {
        public string CheckSpelling(string text)
        {
            Console.WriteLine("English spell checker called");
            return text;
            //throw new NotImplementedException();
        }
    }
}
