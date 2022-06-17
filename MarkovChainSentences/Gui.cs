using System;
using System.ComponentModel;
using System.IO;
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

        public string getInput()
        {
            return FileInput.Checked 
                ? File.ReadAllText(openFileDialog1.FileName) 
                : InputBox.Text ;
        }
        
        public void sendOutput(string output)
        {
            if (FileOutput.Checked)
            {
                File.WriteAllText(saveFileDialog1.FileName, output);
            }
            else
            {
                OutputBox.Text = output;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendOutput(JsonConvert.SerializeObject(Processor.Processor.Process(getInput())));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var results = JsonConvert.DeserializeObject<ProcessResults>(getInput());
            if (CustomStart.Text != "" && results != null)
            {
                results.startWord = results.getTokenFromNameOrCreate(CustomStart.Text).token;
            }
            sendOutput(Processor.Generator.Generate(results));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = Processor.Processor.Process(getInput());
            if (CustomStart.Text != "" && results != null)
            {
                results.startWord = results.getTokenFromNameOrCreate(CustomStart.Text).token;
            }
            sendOutput(Processor.Generator.Generate(results));
        }

        private void FileInput_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void FileOutput_CheckedChanged(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}