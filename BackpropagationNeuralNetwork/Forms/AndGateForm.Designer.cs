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
        // 
        // btnCreateBPNN
        // 
        btnCreateBPNN.Location = new Point(203, 388);
        btnCreateBPNN.Name = "btnCreateBPNN";
        btnCreateBPNN.Size = new Size(110, 50);
        btnCreateBPNN.TabIndex = 4;
        btnCreateBPNN.Text = "Create BPNN";
        btnCreateBPNN.UseVisualStyleBackColor = true;
        btnCreateBPNN.Click += this.btnCreateBPNN_Click;
        // 
        // btnTest
        // 
        btnTest.Location = new Point(435, 388);
        btnTest.Name = "btnTest";
        btnTest.Size = new Size(110, 50);
        btnTest.TabIndex = 6;
        btnTest.Text = "Test";
        btnTest.UseVisualStyleBackColor = true;
        // 
        // AndGateForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnTest);
        Controls.Add(btnTrainNetwork);
        Controls.Add(btnCreateBPNN);
        Controls.Add(btnGoBack);
        Name = "AndGateForm";
        Text = "AndGateForm";
        ResumeLayout(false);
    }

    #endregion
    private Button btnGoBack;
    private Button btnTrainNetwork;
    private Button btnCreateBPNN;
    private Button btnTest;
}