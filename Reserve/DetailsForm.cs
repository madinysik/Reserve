using Reserve.Models;

namespace Reserve
{
    public partial class DetailsForm : Form
    {
        private IDetails _data;

        public DetailsForm(IDetails data)
        {
            InitializeComponent();
            btnClose.Click += BtnClose_Click;

            _data = data;
            var details = _data.GetDetails();
            txtDetails.Text = details;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }

}
