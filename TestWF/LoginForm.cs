using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace TestWF
{
    public partial class LoginForm : Form
    {
        TestContext db = new TestContext();
        public static Tehnician authPerson;
        public LoginForm()
        {
            InitializeComponent();
            RoleComboBox.DataSource = db.Role.Select(x => x.Role1).ToList();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            authPerson = db.Tehnician.Where(x => x.Role.Role1 == RoleComboBox.SelectedText).FirstOrDefault();
            new MainForm(this).Show();
            this.Hide();
        }
    }
}
