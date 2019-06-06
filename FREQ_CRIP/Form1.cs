using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace FREQ_CRIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Shifr_Click(object sender, EventArgs e)
        {
            char[] text = Text.Text.ToCharArray();
            char[] shifr = Text.Text.ToCharArray();
            char[] ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ 123456789".ToCharArray();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz 123456789".ToCharArray();
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] ALPH = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            char[] ALPH_freq = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();

            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename, Encoding.GetEncoding(1251));
            
            double[] freq_alph = { 0.062, 0.014, 0.038, 0.013, 0.025, 0.072, 0.001, 0.007, 0.016, 0.062, 0.010, 0.028, 0.035, 0.026, 0.053, 0.090, 0.023, 0.040, 0.045, 0.053, 0.021, 0.002, 0.009, 0.004, 0.012, 0.006, 0.003, 0.014, 0.016, 0.001, 0.003, 0.006, 0.018};
            int[] count_symbols_text = new int[33];
            int length_text = 0;
            for(int i = 0; i < fileText.Length; i++)
            {
                for (int j = 0; j < alph.Length; j++)
                {
                    if(ALPH[j] == fileText[i])
                    {
                        count_symbols_text[j]++;
                        length_text++;
                        break;
                    }
                }
            }

            int[] freq_count_symbols = new int[33]; 

            for(int i = 0; i < alph.Length; i++)
            {
                freq_count_symbols[i] = (int)Math.Truncate(freq_alph[i] * length_text);
            }

            int temp;
            char temp_char = ' ';
            for (int i = 0; i < freq_count_symbols.Length - 1; i++)
            {
                bool f = false;

                for (int j = 0; j < freq_count_symbols.Length - i - 1; j++)
                {
                    if (freq_count_symbols[j + 1] > freq_count_symbols[j])
                    {
                        f = true;
                        temp = freq_count_symbols[j + 1];
                        temp_char = ALPH_freq[j + 1];
                        freq_count_symbols[j + 1] = freq_count_symbols[j];
                        ALPH_freq[j + 1] = ALPH_freq[j];
                        freq_count_symbols[j] = temp;
                        ALPH_freq[j] = temp_char;
                    }
                }
                if (!f) break;
            }
    
            for (int i = 0; i < count_symbols_text.Length - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < count_symbols_text.Length - i - 1; j++)
                {
                    if (count_symbols_text[j + 1] > count_symbols_text[j])
                    {
                        f = true;
                        temp = count_symbols_text[j + 1];                   
                        count_symbols_text[j + 1] = count_symbols_text[j];
                        count_symbols_text[j] = temp;
                        temp_char = ALPH[j + 1];
                        ALPH[j + 1] = ALPH[j];
                        ALPH[j] = temp_char;
                    }
                }
                if (!f) break;
            }
 
            // Set palette.
            this.chart1.Palette = ChartColorPalette.Excel;

            for (int i = 0; i < count_symbols_text.Length; i++)
            {              
                // Add series.
                Series series = this.chart1.Series.Add(ALPH[i].ToString());

                // Add point.
                series.Points.Add(count_symbols_text[i]);
            }



            char[] fileText_to_char = fileText.ToCharArray();
            for(int i = 0; i < fileText_to_char.Length; i++)
            {
                for(int j = 0; j < ALPH.Length; j++)
                {
                    if(fileText_to_char[i] == ALPH[j])
                    {
                        fileText_to_char[i] = ALPH_freq[j];
                        break;
                    }
                }
            }
            string filetext_str = new string(fileText_to_char);

            saveFileDialog1.ShowDialog();
            string filename2 = saveFileDialog1.FileName;
            StreamWriter streamwriter = new System.IO.StreamWriter(filename2, false, System.Text.Encoding.GetEncoding("utf-8"));
            streamwriter.Write(filetext_str);
            streamwriter.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
