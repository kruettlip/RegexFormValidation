using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<Control, string> RegexLookup;

        public bool FormValid { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeRegexLookup();
        }

        private void InitializeRegexLookup()
        {
            RegexLookup = new Dictionary<Control, string>
            {
                { TxtName, RegexTypes.NAME },
                { TxtMail, RegexTypes.EMAIL },
                { TxtPhone, RegexTypes.PHONENR }
            };
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FormValid = true;
            RegexLookup.ToList().ForEach(x =>
            {
                var field = ((TextBox)x.Key);
                if (!RegexValidator.ValidateField(x.Value, field.Text, field))
                {
                    FormValid = false;
                }
            });
            BtnSave.IsEnabled = FormValid;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
