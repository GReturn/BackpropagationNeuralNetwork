namespace BackpropagationNeuralNetwork.Forms;

public partial class MainForm : Form
{
    private NeuralNet neuralNet;

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnCreateBPNN_Click(Object sender, EventArgs e)
    {
        neuralNet = new NeuralNet(2, 100, 1);
    }

    private void btnTrainNetwork_Click(object sender, EventArgs e)
    {
        for (int x = 0; x < 100; x++)
        {
            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setDesiredOutput(0, 0.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 0.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setDesiredOutput(0, 1.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 0.0);
            neuralNet.setDesiredOutput(0, 1.0);
            neuralNet.learn();

            neuralNet.setInputs(0, 1.0);
            neuralNet.setInputs(1, 1.0);
            neuralNet.setDesiredOutput(0, 1.0);
            neuralNet.learn();
        }
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
        neuralNet.setInputs(0, Convert.ToDouble(textBoxInput0.Text));
        neuralNet.setInputs(1, Convert.ToDouble(textBoxInput1.Text));
        neuralNet.run();
        textBoxOutput0.Text = "" + neuralNet.getOuputData(0);
    }

    private void btnGoToAND_Click(object sender, EventArgs e)
    {
        var andForm = new AndGateForm(this);
        andForm.Show();
        Hide();
    }
}
