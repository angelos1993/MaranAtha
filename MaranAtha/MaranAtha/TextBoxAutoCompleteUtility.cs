using System.Collections.Generic;
using System.Windows.Forms;

namespace MaranAtha
{
    public class TextBoxAutoCompleteUtility
    {
        public static void SetAutoCompleteSourceForTextBox(TextBox textBox, AutoCompleteStringCollection collection)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = collection;
        }

        public static void SetAutoCompleteSourceForTextBox(TextBox textBox, string[] list)
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(list);
            SetAutoCompleteSourceForTextBox(textBox, collection);
        }

        public static void SetAutoCompleteSourceForTextBox(TextBox textBox, List<string> list)
        {
            SetAutoCompleteSourceForTextBox(textBox, list.ToArray());
        }
    }
}