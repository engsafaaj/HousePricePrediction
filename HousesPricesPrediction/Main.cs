namespace HousesPricesPrediction
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            comboBoxCommunityType.SelectedIndex = 0;
        }

        private async void buttonStartPredict_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                SquareMeter = (float)Convert.ToDouble(textBoxArea.Text),
                Bedrooms = (float)Convert.ToDouble(numericUpDownBedRoms.Text),
                Bathrooms = (float)Convert.ToDouble(numericUpDownBathRooms.Text),
                Neighborhood = comboBoxCommunityType.SelectedIndex,
                YearBuilt = (float)Convert.ToDouble(textBoxYearBuild.Text),
            };

            //Load model and predict output
            buttonStartPredict.Text = "Start Prediction ...";
            buttonStartPredict.Enabled = false;
            await Task.Delay(2000);
            var result = await Task.Run(() => MLModel1.Predict(sampleData));

            label1PriceResult.Text = result.Score.ToString();
            buttonStartPredict.Text = "Start Prediction";
            buttonStartPredict.Enabled = true;

        }


    }
}