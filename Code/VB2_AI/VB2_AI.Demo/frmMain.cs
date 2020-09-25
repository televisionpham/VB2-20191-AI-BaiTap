using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB2_AI.Lib;

namespace VB2_AI.Demo
{
    public partial class frmMain : Form
    {
        private List<Syllogism> _patterns = new List<Syllogism>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            cboP1.SelectedIndex = 0;
            cboP2.SelectedIndex = 0;
            cboC.SelectedIndex = 0;

            initRepo();
        }

        private void initRepo()
        {
            var types = "AEPBTDKGIO".ToCharArray();
            for (int i = 0; i < types.Length; i++)
            {
                for (int j = 0; j < types.Length; j++)
                {
                    for (int k = 0; k < types.Length; k++)
                    {
                        for (int t = 0; t < 4; t++)
                        {
                            var content = new char[] { types[i], types[j], types[k] };
                            var s = new Syllogism(content, t + 1);
                            if (s.IsValid)
                            {
                                _patterns.Add(s);
                            }
                        }
                    }
                }
            }
        }

        private void cboManual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboP1.Text) ||
                string.IsNullOrEmpty(cboP2.Text) ||
                string.IsNullOrEmpty(cboC.Text) ||
                string.IsNullOrEmpty(cboType.Text) )
            {
                return;
            }

            var sb = new StringBuilder();            
            var q = new char[3];
            q[0] = cboP1.Text[0];
            q[1] = cboP2.Text[0];
            q[2] = cboC.Text[0];
            var type = int.Parse(cboType.Text);
            var syl = new Syllogism(q, type);
            var strSyl = Syllogism.GenerateSyllogism(type, q, txtS.Text, txtP.Text, txtM.Text);
            sb.AppendLine(syl.ToString());
            sb.AppendLine();
            sb.AppendLine(strSyl);
            if (syl.IsValid)
            {
                sb.AppendLine("HỢP LỆ");
            }
            else
            {
                sb.AppendLine("KHÔNG HỢP LỆ");
            }
            txtManualResult.Text = sb.ToString();
        }

        private void btnGenResult_Click(object sender, EventArgs e)
        {
            cboManual_SelectedIndexChanged(null, null);
        }

        private void btnGenerateAllValid_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var pattern in _patterns)
            {
                sb.AppendLine(pattern.ToString());
                var s = Syllogism.GenerateSyllogism(pattern.Type, pattern.Content, txtS.Text, txtP.Text, txtM.Text);
                sb.AppendLine(s);
            }
            txtAutoResult.Text = sb.ToString();
        }
    }
}
