using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementationAS;

namespace Visualization
{
    public partial class MainForm : Form
    {
        private string _fileName = string.Empty;
        List<Thread> threads = new List<Thread>();
        public MainForm()
        {
            InitializeComponent();
            label1.Text = string.Format("Support Value: {0}", trackBar1.Value + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Text|*.txt";
            if (dialog.ShowDialog() != DialogResult.OK) return;

            _fileName = dialog.FileName;
            trackBar1.Enabled = true;
            DisplayResult();
            btnRefresh.Enabled = true;
        }

        private void DisplayResult()
        {
            Thread t = new Thread(delegate ()
                {
                    pictureBox1.Invoke(new MethodInvoker(delegate
                    {
                        pictureBox1.Show();
                    }));
                    ExecuteAssociationRule();
                    pictureBox1.Invoke(new MethodInvoker(delegate
                    {
                        pictureBox1.Hide();
                    }));
                })
                { Name = "Implementation" };
            threads.Add(t);
            t.Start();
        }

        private void ExecuteAssociationRule()
        {
            int Support = 2;
            if (trackBar1.InvokeRequired)
                trackBar1.Invoke(new MethodInvoker(delegate
                    {
                        Support = trackBar1.Value + 1;
                        trackBar1.Enabled = false;
                    }
                ));
            if (flowLayoutPanel1.InvokeRequired)
                flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                    {
                        flowLayoutPanel1.Controls.Clear();
                        flowLayoutPanel1.Controls.Add(new TableResult(File.ReadAllLines(_fileName).ToList()));
                    }
                ));

            ImplementationAS.Apriori apriori = new ImplementationAS.Apriori(_fileName);
            int k = 1;
            List<ImplementationAS.ItemSet> ItemSets = new List<ImplementationAS.ItemSet>();
            ItemSet L = new ItemSet();
            bool next;
            do
            {
                next = false;
                if (k == 1) L = apriori.Get_First_Frequent_ItemSet(k,Support);
                else L = apriori.Get_Frequent_ItemSet(k - 1, L, Support);
                if (L.Count > 0)
                {
                    List<AssociationRule> rules = new List<AssociationRule>();
                    if (k != 1)
                        rules = apriori.GetRules(L);
                    TableResult tableL = new TableResult(L, rules);
                    next = true;
                    k++;
                    ItemSets.Add(L);
                    if (flowLayoutPanel1.InvokeRequired)
                        flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                            {
                                flowLayoutPanel1.Controls.Add(tableL);
                                flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
                            }
                        ));
                }
            } while (next);

            if (trackBar1.InvokeRequired)
                trackBar1.Invoke(new MethodInvoker(delegate
                    {
                        trackBar1.Enabled = true;
                    }
                ));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = string.Format("Support Value: {0}", trackBar1.Value + 1);
            DisplayResult();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbortThread();
        }

        private void AbortThread()
        {
            foreach (var thread in threads)
            {
                thread.Abort();
            }
            threads.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AbortThread();
            DisplayResult();
        }
    }
}
