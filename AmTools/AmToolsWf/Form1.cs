using AmToolsWf.MicrosoftTranslator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmToolsWf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            LanguageServiceClient client = new LanguageServiceClient();
            result = client.Translate("DF9E54CA96F73F2E289AEC059F407DE8295A6515", txtBodyCN.Text, "en", "zh-CHS", "text/html", "general");

            txtBodyEn.Text = result;
        }
    }
}
