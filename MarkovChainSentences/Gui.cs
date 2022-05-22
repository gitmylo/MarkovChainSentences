using System;
using System.Windows.Forms;
using MarkovChainSentences.Data;
using Newtonsoft.Json;

namespace MarkovChainSentences
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputBox.Text = JsonConvert.SerializeObject(Processor.Processor.Process(InputBox.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OutputBox.Text = Processor.Generator.Generate(JsonConvert.DeserializeObject<ProcessResults>(InputBox.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputBox.Text = Processor.Generator.Generate(Processor.Processor.Process(InputBox.Text));
        }
    }
}