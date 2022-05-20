using ChuckNorrisAPI;

namespace JokeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            richTextBox1.Text = j.JokeText;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "Select Category";
            IEnumerable<String> categories = await ChuckNorrisClient.GetCategories();

            foreach(String category in categories)
            {
                comboBox1.Items.Add(category);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}