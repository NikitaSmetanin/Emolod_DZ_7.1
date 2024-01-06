using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_7._1
{
    public partial class Form1 : Form
    {
        int englishRows = 5;
        int enlishCols = 5; 
        char[,] englishChars = {{ 'A', 'B', 'C', 'D', 'E' },
                                { 'F', 'G', 'H', 'I', 'K' },
                                { 'L', 'M', 'N', 'O', 'P' },
                                { 'Q', 'R', 'S', 'T', 'U' },
                                { 'V', 'W', 'X', 'Y', 'Z' }};
        int ukranianRows = 6;
        int ukranianCols = 6;
        char[,] ukranianChars = {{'А', 'Б', 'В', 'Г', 'Ґ', 'Д'},
                                 {'Е', 'Є', 'Ж', 'З', 'И', 'І'},
                                 {'Ї', 'Й', 'К', 'Л', 'М', 'Н'},
                                 {'О', 'П', 'Р', 'С', 'Т', 'У'},
                                 {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ'},
                                 {'Ю', 'Я', 'Ь', '.', ',', ' '}};
        int currentRows;
        int currentCols;
        char[,] currentChars;
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sourceTextBox.Clear();
            codeTextBox.Clear();
            ukrRadioButton.Checked = true;
            engRadioButton.Checked = false;
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            if (ukrRadioButton.Checked) {
                currentChars = ukranianChars;
                currentCols = ukranianCols;
                currentRows = ukranianRows;
            } else {
                currentChars = englishChars;
                currentRows = englishRows;
                currentCols = enlishCols;
            }

            for (int i = 0; i < sourceTextBox.Text.Length; i++)
            {
                string code = findSymbol(sourceTextBox.Text.ToUpper()[i]);
                if (code != null)
                {
                    codeTextBox.Text += code + " ";
                }
            }
        }

        private string findSymbol(char symbol)
        {
            if (symbol == 'J')
                symbol = 'I';

            for (int i = 0; i < currentRows; i++)
            {
                for (int j = 0; j < currentCols; j++)
                {
                    if (symbol == currentChars[i, j])
                    {
                        return (++i * 10 + ++j).ToString() ;
                    }
                }
            }
            return null;
        }
    }
}
