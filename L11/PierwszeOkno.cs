using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wyklad4
{
    public partial class PierwszeOkno : Form
    {
        private string kodowanie_wejsciowe;
        private string kodowanie_wyjsciowe;

        public PierwszeOkno()
        {
            InitializeComponent();


            comboBoxLista.Items.AddRange(new object[] {"UTF-8",
                        "ASCII",
                        "Unicode",
                        "UTF-32",
                        "UTF-7"});

            comboBox1.Items.AddRange(new object[] {"UTF-8",
                        "ASCII",
                        "Unicode",
                        "UTF-32",
                        "UTF-7"});
        }

        private void comboBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                var cmb = (ComboBox)sender;

                kodowanie_wejsciowe = cmb.SelectedItem.ToString();
                //textBoxNazwa.Text = cmb.SelectedItem.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                var cmb1 = (ComboBox)sender;

                kodowanie_wyjsciowe = cmb1.SelectedItem.ToString();
                //textBoxNazwa.Text = cmb.SelectedItem.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {                                                                // wyklad4\wyklad4\bin\Debug\file.txt
            using (System.IO.FileStream input = new System.IO.FileStream(@".\file.txt",   
                                       System.IO.FileMode.Open,
                                       System.IO.FileAccess.Read))
            {
                byte[] buffer = new byte[input.Length];

                int readLength = 0;

                while (readLength < buffer.Length)
                    readLength += input.Read(buffer, readLength, buffer.Length - readLength);

                

                byte[] converted = Encoding.Convert(Encoding.GetEncoding(kodowanie_wejsciowe),
                                   Encoding.GetEncoding(kodowanie_wyjsciowe), buffer);
                                                                              // wyklad4\wyklad4\bin\Debug\file2.txt
                using (System.IO.FileStream output = new System.IO.FileStream(@".\file2.txt",
                                                     System.IO.FileMode.Create,
                                                     System.IO.FileAccess.Write))
                {
                    output.Write(converted, 0, converted.Length);
                }
            }

            /*var text = System.IO.File.ReadAllText(@"C:\Users\Jakub\Desktop\wyklad4\wyklad4\bin\Debug\file.txt");            

            using (var fstream = System.IO.File.OpenRead(@"C:\Users\Jakub\Desktop\wyklad4\wyklad4\bin\Debug\file.txt"))
            {
                // UTF8
                // ASCII
                // Unicode
                // UTF32
                // UTF7
                // Default
                // BigEndianUnicode                

                using (var r = new System.IO.StreamReader(fstream, Encoding.UTF8))
                {
                    using (var fstream2 = System.IO.File.Create(@"C:\Users\Jakub\Desktop\wyklad4\wyklad4\bin\Debug\file2.txt"))
                    {
                        using (var w = new System.IO.StreamWriter(fstream2, Encoding.UTF7))
                        {
                            var buf = new char[256];
                            int read = 0;
                            read = r.Read(buf, 0, 256);
                            w.Write(buf);
                        }
                    }                        
                }
            }*/

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }        
    }
}
