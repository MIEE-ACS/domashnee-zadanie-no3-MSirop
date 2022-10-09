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

namespace dz3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', ',', '.', '!', '?'};

        string[] codeMorse = new string[] { ".–", "–...", ".––", "––.",
                                                        "–..", ".", "...–", "––..",
                                                        "..", ".–––", "–.–", ".–..",
                                                        "––", "–.", "–––", ".––.",
                                                        ".–.", "...", "–", "..–",
                                                        "..–.", "....", "–.–.",
                                                        "–––.", "––––", "−−.−",
                                                        "−.−−", "−..−", "..−..",
                                                        "..−−", ".−.−", ",", ".", "!", "?" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string input = textBox1.Text;
            input = input.ToUpper();
            string output = "";
            int index;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(characters, c);
                    output += codeMorse[index] + " ";
                }
                else
                {
                    output +=  "    ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox2.Text = output;
        }
    }
}
