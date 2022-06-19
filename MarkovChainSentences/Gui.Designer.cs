using System.ComponentModel;

namespace MarkovChainSentences
{
    partial class Gui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomStart = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileInput = new System.Windows.Forms.RadioButton();
            this.LeftBoxInput = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FileOutput = new System.Windows.Forms.RadioButton();
            this.RightBoxOutput = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.DepthPicker = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DepthPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.InputBox.Location = new System.Drawing.Point(12, 12);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(298, 426);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "";
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Location = new System.Drawing.Point(450, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(338, 426);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate model";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Generate output from model";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(331, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "<- input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(346, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "output ->";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(316, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Custom start (empty for default):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CustomStart
            // 
            this.CustomStart.Location = new System.Drawing.Point(316, 208);
            this.CustomStart.Name = "CustomStart";
            this.CustomStart.Size = new System.Drawing.Size(128, 20);
            this.CustomStart.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FileInput);
            this.panel1.Controls.Add(this.LeftBoxInput);
            this.panel1.Location = new System.Drawing.Point(316, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 52);
            this.panel1.TabIndex = 9;
            // 
            // FileInput
            // 
            this.FileInput.Location = new System.Drawing.Point(3, 27);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(102, 16);
            this.FileInput.TabIndex = 1;
            this.FileInput.Text = "File Input";
            this.FileInput.UseVisualStyleBackColor = true;
            this.FileInput.Click += new System.EventHandler(this.FileInput_CheckedChanged);
            // 
            // LeftBoxInput
            // 
            this.LeftBoxInput.Checked = true;
            this.LeftBoxInput.Location = new System.Drawing.Point(3, 3);
            this.LeftBoxInput.Name = "LeftBoxInput";
            this.LeftBoxInput.Size = new System.Drawing.Size(102, 18);
            this.LeftBoxInput.TabIndex = 0;
            this.LeftBoxInput.TabStop = true;
            this.LeftBoxInput.Text = "Left Box Input";
            this.LeftBoxInput.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FileOutput);
            this.panel2.Controls.Add(this.RightBoxOutput);
            this.panel2.Location = new System.Drawing.Point(316, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 62);
            this.panel2.TabIndex = 10;
            // 
            // FileOutput
            // 
            this.FileOutput.Location = new System.Drawing.Point(3, 35);
            this.FileOutput.Name = "FileOutput";
            this.FileOutput.Size = new System.Drawing.Size(102, 24);
            this.FileOutput.TabIndex = 1;
            this.FileOutput.Text = "File Output";
            this.FileOutput.UseVisualStyleBackColor = true;
            this.FileOutput.Click += new System.EventHandler(this.FileOutput_CheckedChanged);
            // 
            // RightBoxOutput
            // 
            this.RightBoxOutput.Checked = true;
            this.RightBoxOutput.Location = new System.Drawing.Point(3, 3);
            this.RightBoxOutput.Name = "RightBoxOutput";
            this.RightBoxOutput.Size = new System.Drawing.Size(102, 37);
            this.RightBoxOutput.TabIndex = 0;
            this.RightBoxOutput.TabStop = true;
            this.RightBoxOutput.Text = "Right Box Output";
            this.RightBoxOutput.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "File input";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "File output";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(316, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depth:";
            // 
            // DepthPicker
            // 
            this.DepthPicker.Location = new System.Drawing.Point(363, 363);
            this.DepthPicker.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.DepthPicker.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.DepthPicker.Name = "DepthPicker";
            this.DepthPicker.Size = new System.Drawing.Size(69, 20);
            this.DepthPicker.TabIndex = 12;
            this.DepthPicker.Value = new decimal(new int[] {3, 0, 0, 0});
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepthPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Gui";
            this.Text = "Text Generator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.DepthPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DepthPicker;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.RadioButton FileOutput;
        private System.Windows.Forms.RadioButton FileInput;

        private System.Windows.Forms.RadioButton LeftBoxInput;

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RightBoxOutput;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomStart;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.RichTextBox InputBox;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;

        #endregion
    }
}