using System;
using System.Windows.Forms;

namespace restClient
{
    public partial class RestClientForm : Form
    {
        public RestClientForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            Tuple<string, string> response = null;
            RestClient rClient = new RestClient(urlTextBox.Text, methodComboBox.GetItemText(methodComboBox.SelectedItem));

            rClient.body = bodyTextBox.Text;

            response = rClient.makeRequest();
            responseTextBox.Text = response.Item1;
            statusCodeTextBox.Text = response.Item2;
        }
    }
}
