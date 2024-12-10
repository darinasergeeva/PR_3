using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PartnersContext db = new PartnersContext())
            {
                var partner = db.Partners.ToList();
                //labelTabl.Text = "Список партнеров:";

                foreach (Partner u in partner)
                {
                    labelBottom.Text += $"{u.Id,-5}|    {u.IdPartnerType,-5}  {u.NamePartner,-20}" +
                        $"{u.LegalAddress,-80}     {u.NameOfDirector,-25}      {u.Telephone,-15}\n";
                }
            }

        }
    }
}
