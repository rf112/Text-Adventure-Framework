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
        //Globals For use in stat selection logic
        decimal strSel;
        decimal dexSel;
        decimal conSel;
        decimal intSel;
        decimal wisSel;
        decimal charSel;
        bool increase;





        //Behaviors
        public Initialize()
        {
            InitializeComponent();
        }

        private void Initialize_Load(object sender, EventArgs e)
        {
            classSelect.SelectedIndex = 0;
        }

        private void strengthNum_ValueChanged(object sender, EventArgs e) //Event Handler for controlling the stat selection. Identical methods for all stat selection boxes.
        {
            decimal tot; //total points allocated.

            if (strengthNum.Value > strSel) //Checks to see if the user tried to increase the points attributed to a category.
            {
                increase = true; //if there was a commanded increase, sets the global increase to true.
            }

            tot = strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value; //gives the tot a value equal to the sum of all selected skill points.

            if (tot > 25 && increase == true) //If the total selected skill points is greater than the maximum (25) and an increase was commanded.
            {
                strengthNum.Value -= 1; //removes the point the user tried to add that would have gone over the maximum allowed points.
            }

            tot = 25 - (strengthNum.Value + dexterityNum.Value + constitutionNum.Value + intelligenceNum.Value + wisdomNum.Value + charismaNum.Value); //Uses the tot variable to store how many points remain for selection
            strSel = strengthNum.Value; //sets the value select box to the appropriate value after the logic has finished.

            totalStat.Text = tot.ToString(); //Updates the displayed total points remaining based on user selections.
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

        } //Identical Event Handler for controlling stat selection. Only changes are the value box controlled.

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

        }  //Identical Event Handler for controlling stat selection. Only changes are the value box controlled.

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

        }  //Identical Event Handler for controlling stat selection. Only changes are the value box controlled.

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

        }  //Identical Event Handler for controlling stat selection. Only changes are the value box controlled.

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

        }  //Identical Event Handler for controlling stat selection. Only changes are the value box controlled.
    }
}
