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
        lblEpoch = new Label();
        label1 = new Label();
        label2 = new Label();
        lblHiddenLayers = new Label();
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
        textBoxInput0.Location = new Point(168, 86);
        textBoxInput0.Name = "textBoxInput0";
        textBoxInput0.Size = new Size(100, 23);
        textBoxInput0.TabIndex = 7;
        // 
        // textBoxInput1
        // 
        textBoxInput1.Location = new Point(168, 142);
        textBoxInput1.Name = "textBoxInput1";
        textBoxInput1.Size = new Size(100, 23);
        textBoxInput1.TabIndex = 8;
        // 
        // textBoxInput2
        // 
        textBoxInput2.Location = new Point(168, 205);
        textBoxInput2.Name = "textBoxInput2";
        textBoxInput2.Size = new Size(100, 23);
        textBoxInput2.TabIndex = 9;
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
        // lblEpoch
        // 
        lblEpoch.AutoSize = true;
        lblEpoch.Location = new Point(52, 406);
        lblEpoch.Name = "lblEpoch";
        lblEpoch.Size = new Size(13, 15);
        lblEpoch.TabIndex = 12;
        lblEpoch.Text = "0";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 406);
        label1.Name = "label1";
        label1.Size = new Size(43, 15);
        label1.TabIndex = 13;
        label1.Text = "Epoch:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 426);
        label2.Name = "label2";
        label2.Size = new Size(85, 15);
        label2.TabIndex = 14;
        label2.Text = "Hidden Layers:";
        // 
        // lblHiddenLayers
        // 
        lblHiddenLayers.AutoSize = true;
        lblHiddenLayers.Location = new Point(94, 426);
        lblHiddenLayers.Name = "lblHiddenLayers";
        lblHiddenLayers.Size = new Size(13, 15);
        lblHiddenLayers.TabIndex = 15;
        lblHiddenLayers.Text = "0";
        // 
        // AndGateForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblHiddenLayers);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(lblEpoch);
        Controls.Add(textBoxOutput0);
        Controls.Add(textBoxInput3);
        Controls.Add(textBoxInput2);
        Controls.Add(textBoxInput1);
        Controls.Add(textBoxInput0);
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
    private Label lblEpoch;
    private Label label1;
    private Label label2;
    private Label lblHiddenLayers;
}