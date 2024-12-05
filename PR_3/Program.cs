using Microsoft.VisualBasic.ApplicationServices;

namespace PR_3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (PartnersContext db = new PartnersContext())
            {
                // получаем объекты из бд и выводим на консоль
                var Partners = db.Partners.ToList();
                Console.WriteLine("Users list:");
                foreach (Partner u in Partners)
                {
                    Console.WriteLine($"{u.Id}.{u.IdPartnerType} - {u.NamePartner}");
                }
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }
    }
}