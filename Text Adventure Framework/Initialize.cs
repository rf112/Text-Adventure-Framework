using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Adventure_Framework
{
    public partial class Initialize : Form
    {
        decimal strSel;
        decimal dexSel;
        decimal conSel;
        decimal intSel;
        decimal wisSel;
        decimal charSel;
        bool increase;

        public Initialize()
        {
            InitializeComponent();
        }

        private void Initialize_Load(object sender, EventArgs e)
        {
            classSelect.SelectedIndex = 0;
        }

        private void strengthNum_ValueChanged(object sender, EventArgs e)
        {
            decimal tot;

            if (strengthNum.Value > strSel)
            {
                increase = true;
            }

            tot = strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value;

            if (tot > 25 && increase == true)
            {
                strengthNum.Value -= 1;
            }

            tot = 25 - (strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value);
            strSel = strengthNum.Value;

            totalStat.Text = tot.ToString();
        }

        private void dexterityNum_ValueChanged(object sender, EventArgs e)
        {
            decimal tot;

            if (dexterityNum.Value > strSel)
            {
                increase = true;
            }

            tot = strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value;

            if (tot > 25 && increase == true)
            {
                dexterityNum.Value -= 1;
            }

            tot = 25 - (strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value);
            dexSel = strengthNum.Value;

            totalStat.Text = tot.ToString();

        }

        private void constitutionNum_ValueChanged(object sender, EventArgs e)
        {
            decimal tot;

            if (constitutionNum.Value > strSel)
            {
                increase = true;
            }

            tot = strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value;

            if (tot > 25 && increase == true)
            {
                constitutionNum.Value -= 1;
            }

            tot = 25 - (strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value);
            conSel = strengthNum.Value;

            totalStat.Text = tot.ToString();

        }

        private void intelligenceNum_ValueChanged(object sender, EventArgs e)
        {
            decimal tot;

            if (intelligenceNum.Value > strSel)
            {
                increase = true;
            }

            tot = strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value;

            if (tot > 25 && increase == true)
            {
                intelligenceNum.Value -= 1;
            }

            tot = 25 - (strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value);
            intSel = strengthNum.Value;

            totalStat.Text = tot.ToString();

        }

        private void wisdomNum_ValueChanged(object sender, EventArgs e)
        {
            decimal tot;

            if (wisdomNum.Value > strSel)
            {
                increase = true;
            }

            tot = strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value;

            if (tot > 25 && increase == true)
            {
                wisdomNum.Value -= 1;
            }

            tot = 25 - (strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value);
            wisSel = strengthNum.Value;

            totalStat.Text = tot.ToString();

        }

        private void charismaNum_ValueChanged(object sender, EventArgs e)
        {
            decimal tot;

            if (charismaNum.Value > strSel)
            {
                increase = true;
            }

            tot = strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value;

            if (tot > 25 && increase == true)
            {
                charismaNum.Value -= 1;
            }

            tot = 25 - (strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value);
            charSel = strengthNum.Value;

            totalStat.Text = tot.ToString();

        }
    }
}
