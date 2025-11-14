namespace BackpropagationNeuralNetwork.Forms;

partial class AndGateForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        btnGoBack = new Button();
        btnTrainNetwork = new Button();
        btnCreateBPNN = new Button();
        btnTest = new Button();
        textBoxInput0 = new TextBox();
        textBoxInput1 = new TextBox();
        textBoxInput2 = new TextBox();
        textBoxInput3 = new TextBox();
        textBoxOutput0 = new TextBox();
        SuspendLayout();
        // 
        // btnGoBack
        // 
        btnGoBack.Location = new Point(12, 12);
        btnGoBack.Name = "btnGoBack";
        btnGoBack.Size = new Size(75, 23);
        btnGoBack.TabIndex = 3;
        btnGoBack.Text = "Go Back";
        btnGoBack.UseVisualStyleBackColor = true;
        btnGoBack.Click += btnGoBack_Click;
        // 
        // btnTrainNetwork
        // 
        btnTrainNetwork.Location = new Point(319, 388);
        btnTrainNetwork.Name = "btnTrainNetwork";
        btnTrainNetwork.Size = new Size(110, 50);
        btnTrainNetwork.TabIndex = 5;
        btnTrainNetwork.Text = "Train Neural Network";
        btnTrainNetwork.UseVisualStyleBackColor = true;
        btnTrainNetwork.Click += btnTrainNetwork_Click;
        // 
        // btnCreateBPNN
        // 
        btnCreateBPNN.Location = new Point(203, 388);
        btnCreateBPNN.Name = "btnCreateBPNN";
        btnCreateBPNN.Size = new Size(110, 50);
        btnCreateBPNN.TabIndex = 4;
        btnCreateBPNN.Text = "Create BPNN";
        btnCreateBPNN.UseVisualStyleBackColor = true;
        btnCreateBPNN.Click += btnCreateBPNN_Click;
        // 
        // btnTest
        // 
        btnTest.Location = new Point(435, 388);
        btnTest.Name = "btnTest";
        btnTest.Size = new Size(110, 50);
        btnTest.TabIndex = 6;
        btnTest.Text = "Test";
        btnTest.UseVisualStyleBackColor = true;
        btnTest.Click += btnTest_Click;
        // 
        // textBoxInput0
        // 
        this.textBoxInput0.Location = new Point(168, 86);
        this.textBoxInput0.Name = "textBoxInput0";
        this.textBoxInput0.Size = new Size(100, 23);
        this.textBoxInput0.TabIndex = 7;
        // 
        // textBoxInput1
        // 
        this.textBoxInput1.Location = new Point(168, 142);
        this.textBoxInput1.Name = "textBoxInput1";
        this.textBoxInput1.Size = new Size(100, 23);
        this.textBoxInput1.TabIndex = 8;
        // 
        // textBoxInput2
        // 
        this.textBoxInput2.Location = new Point(168, 205);
        this.textBoxInput2.Name = "textBoxInput2";
        this.textBoxInput2.Size = new Size(100, 23);
        this.textBoxInput2.TabIndex = 9;
        // 
        // textBoxInput3
        // 
        textBoxInput3.Location = new Point(168, 263);
        textBoxInput3.Name = "textBoxInput3";
        textBoxInput3.Size = new Size(100, 23);
        textBoxInput3.TabIndex = 10;
        // 
        // textBoxOutput0
        // 
        textBoxOutput0.Location = new Point(477, 171);
        textBoxOutput0.Name = "textBoxOutput0";
        textBoxOutput0.Size = new Size(100, 23);
        textBoxOutput0.TabIndex = 11;
        // 
        // AndGateForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBoxOutput0);
        Controls.Add(textBoxInput3);
        Controls.Add(this.textBoxInput2);
        Controls.Add(this.textBoxInput1);
        Controls.Add(this.textBoxInput0);
        Controls.Add(btnTest);
        Controls.Add(btnTrainNetwork);
        Controls.Add(btnCreateBPNN);
        Controls.Add(btnGoBack);
        Name = "AndGateForm";
        Text = "AndGateForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button btnGoBack;
    private Button btnTrainNetwork;
    private Button btnCreateBPNN;
    private Button btnTest;
    private TextBox textBoxInput0;
    private TextBox textBoxInput1;
    private TextBox textBoxInput2;
    private TextBox textBoxInput3;
    private TextBox textBoxOutput0;
}