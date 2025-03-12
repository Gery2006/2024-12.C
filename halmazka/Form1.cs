using System.Windows.Forms;

namespace halmazka
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            int countA = (int)numericUpDownA.Value;
            int countB = (int)numericUpDownB.Value;

            HashSet<int> halmazA = GeneralHalmaz(countA);
            HashSet<int> halmazB = GeneralHalmaz(countB);

            listBoxA.Items.Clear();
            listBoxB.Items.Clear();
            listBoxUnio.Items.Clear();
            listBoxMetszet.Items.Clear();
            listBoxKulonbsegAB.Items.Clear();
            listBoxKulonbsegBA.Items.Clear();

            foreach (var item in halmazA) listBoxA.Items.Add(item);
            foreach (var item in halmazB) listBoxB.Items.Add(item);
            foreach (var item in halmazA.Union(halmazB)) listBoxUnio.Items.Add(item);
            foreach (var item in halmazA.Intersect(halmazB)) listBoxMetszet.Items.Add(item);
            foreach (var item in halmazA.Except(halmazB)) listBoxKulonbsegAB.Items.Add(item);
            foreach (var item in halmazB.Except(halmazA)) listBoxKulonbsegBA.Items.Add(item);
        }

        private HashSet<int> GeneralHalmaz(int count)
        {
            HashSet<int> halmaz = new HashSet<int>();
            while (halmaz.Count < count)
            {
                halmaz.Add(random.Next(0, 10001));
            }
            return halmaz;
        }
    }

}
