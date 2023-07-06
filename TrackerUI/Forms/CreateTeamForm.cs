using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, System.EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output = true;

            // Validate First Name field
            if (firstNameValueTextbox.Text.Length == 0)
            {
                output = false;
            }

            // Validate Last Name field
            if (lastNameValueTextbox.Text.Length == 0)
            {
                output = false;
            }

            // Validate Email Address field
            if (emailValueTextbox.Text.Length == 0)
            {
                output = false;
            }

            // Validate Cellphone Number field
            if (cellphoneValueTextbox.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
