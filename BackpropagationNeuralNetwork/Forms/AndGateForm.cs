namespace BackpropagationNeuralNetwork.Forms;

public partial class AndGateForm : Form
{
    private MainForm parentForm;
    private NeuralNet neuralNet;
    public AndGateForm(MainForm parentForm)
    {
        InitializeComponent();
        this.parentForm = parentForm;
    }

    private void btnGoBack_Click(object sender, EventArgs e)
    {
        parentForm.Show();
        Hide();
    }


    private void btnCreateBPNN_Click(Object sender, EventArgs e)
    {
        neuralNet = new NeuralNet(4, 0, 1);
    }

    private void btnTrainNetwork_Click(object sender, EventArgs e)
    {
        if (neuralNet is null)
        {
            MessageBox.Show("Please create the neural network first.");
            return;
        }

        for (int x = 0; x < 1; x++)
        {
            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setInputs(2, 0.0);
            neuralNet.setInputs(3, 0.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();



            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setInputs(2, 0.0);
            neuralNet.setInputs(3, 0.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setInputs(2, 0.0);
            neuralNet.setInputs(3, 0.0); 
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setInputs(2, 1.0);
            neuralNet.setInputs(3, 0.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setInputs(2, 0.0);
            neuralNet.setInputs(3, 1.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();



            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setInputs(2, 0.0);
            neuralNet.setInputs(3, 0.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setInputs(2, 1.0);
            neuralNet.setInputs(3, 0.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setInputs(2, 0.0);
            neuralNet.setInputs(3, 1.0);
            neuralNet.setDesiredOutput(0, 0.0);

            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setInputs(2, 1.0);
            neuralNet.setInputs(3, 0.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setInputs(2, 0.0);
            neuralNet.setInputs(3, 1.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setInputs(2, 1.0);
            neuralNet.setInputs(3, 1.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();



            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setInputs(2, 1.0);
            neuralNet.setInputs(3, 0.0);
            neuralNet.setDesiredOutput(0, 0.0);

            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setInputs(2, 0.0);
            neuralNet.setInputs(3, 1.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setInputs(2, 1.0);
            neuralNet.setInputs(3, 1.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setInputs(2, 1.0);
            neuralNet.setInputs(3, 1.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();



            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setInputs(2, 1.0);
            neuralNet.setInputs(3, 1.0);
            neuralNet.setDesiredOutput(0, 1.0);
        }
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
        if (neuralNet is null)
        {
            MessageBox.Show("Please create the neural network first.");
            return;
        }

        neuralNet.setInputs(0, Convert.ToDouble(textBoxInput0.Text));
        neuralNet.setInputs(1, Convert.ToDouble(textBoxInput1.Text));
        neuralNet.setInputs(2, Convert.ToDouble(textBoxInput2.Text));
        neuralNet.setInputs(3, Convert.ToDouble(textBoxInput3.Text));
        neuralNet.run();
        textBoxOutput0.Text = "" + neuralNet.getOuputData(0);
    }
}