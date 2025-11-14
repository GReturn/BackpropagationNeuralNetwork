namespace BackpropagationNeuralNetwork
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateBPNN = new Button();
            btnTrainNetwork = new Button();
            btnTest = new Button();
            textBoxInput0 = new TextBox();
            textBoxInput1 = new TextBox();
            textBoxOutput0 = new TextBox();
            btnGoToAND = new Button();
            SuspendLayout();
            // 
            // btnCreateBPNN
            // 
            btnCreateBPNN.Location = new Point(219, 345);
            btnCreateBPNN.Name = "btnCreateBPNN";
            btnCreateBPNN.Size = new Size(110, 50);
            btnCreateBPNN.TabIndex = 0;
            btnCreateBPNN.Text = "Create BPNN";
            btnCreateBPNN.UseVisualStyleBackColor = true;
            btnCreateBPNN.Click += btnCreateBPNN_Click;
            // 
            // btnTrainNetwork
            // 
            btnTrainNetwork.Location = new Point(335, 345);
            btnTrainNetwork.Name = "btnTrainNetwork";
            btnTrainNetwork.Size = new Size(110, 50);
            btnTrainNetwork.TabIndex = 1;
            btnTrainNetwork.Text = "Train Neural Network";
            btnTrainNetwork.UseVisualStyleBackColor = true;
            btnTrainNetwork.Click += btnTrainNetwork_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(451, 345);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(110, 50);
            btnTest.TabIndex = 2;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // textBoxInput0
            // 
            textBoxInput0.Location = new Point(268, 86);
            textBoxInput0.Name = "textBoxInput0";
            textBoxInput0.Size = new Size(100, 23);
            textBoxInput0.TabIndex = 4;
            // 
            // textBoxInput1
            // 
            textBoxInput1.Location = new Point(268, 214);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(100, 23);
            textBoxInput1.TabIndex = 5;
            // 
            // textBoxOutput0
            // 
            textBoxOutput0.Location = new Point(430, 150);
            textBoxOutput0.Name = "textBoxOutput0";
            textBoxOutput0.Size = new Size(100, 23);
            textBoxOutput0.TabIndex = 6;
            // 
            // btnGoToAND
            // 
            btnGoToAND.Location = new Point(12, 12);
            btnGoToAND.Name = "btnGoToAND";
            btnGoToAND.Size = new Size(120, 23);
            btnGoToAND.TabIndex = 7;
            btnGoToAND.Text = "Go To AND Gate";
            btnGoToAND.UseVisualStyleBackColor = true;
            btnGoToAND.Click += btnGoToAND_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoToAND);
            Controls.Add(textBoxOutput0);
            Controls.Add(textBoxInput1);
            Controls.Add(textBoxInput0);
            Controls.Add(btnTest);
            Controls.Add(btnTrainNetwork);
            Controls.Add(btnCreateBPNN);
            Name = "MainForm";
            Text = "Neural Network by Rafael Mendoza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateBPNN;
        private Button btnTrainNetwork;
        private Button btnTest;
        private TextBox textBoxInput0;
        private TextBox textBoxInput1;
        private TextBox textBoxOutput0;
        private Button btnGoToAND;
    }
}
