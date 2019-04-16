using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;


namespace WPF_functionsTest.Behaviors
{
    /// <summary>
    /// Конечно, есть и более простые способы сделать тоже самое
    /// </summary>
    class TextBoxImputBehavior : Behavior<TextBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.PreviewTextInput += TextBox_OnPreviewTextInput;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.PreviewTextInput -= TextBox_OnPreviewTextInput;
        }

        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            bool negative = e.Text.Equals("-") && textBox.Text.IndexOf("-") < 0 && textBox.SelectionStart == 0;
            bool dot =  e.Text.Equals(".") && textBox.Text.IndexOf(".") < 0
                && textBox.SelectionStart > 0 && textBox.SelectionStart > textBox.Text.IndexOf("-") + 1;
            double result;
            if (!(double.TryParse(e.Text, out result) || dot || negative))
            {
                e.Handled = true;
            }
        }
    }
}