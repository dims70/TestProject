using System.Linq;
using System.Windows.Forms;

namespace TestWF
{
    public partial class MainForm : Form
    {
        LoginForm loginf;
        TestContext db = new TestContext();
        public MainForm(LoginForm first)
        {
            InitializeComponent();
            loginf = first;
            FormClosed += (o, s) =>
            {
                loginf.Visible = true;
            };
            listhospitals.DataSource = db.Hospital.ToList();
            listresearchs.DataSource = db.Research.ToList();

        }


    }
}
