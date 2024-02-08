using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyCalc {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            label1.BackColor = pizzaBackground;
            label2.BackColor = pizzaBackground;
            surfaceArea1.BackColor = pizzaBackground;
            surfaceArea2.BackColor = pizzaBackground;
            ratio1Text.BackColor = pizzaBackground;
            ratio2Text.BackColor = pizzaBackground;
            output.BackColor = pizzaBackground;
        }
        double circ1 = 0;
        double circ2 = 0;
        double price1 = 1.0;
        double price2 = 1.0;
        double surface1;
        double surface2;
        double ratio1;
        double ratio2;
        Color pizzaBackground = Color.FromArgb(70, 191, 202);

        private void circ1Text_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(circ1Text.Text, out circ1)) {
                calculations();
            }
        }

        private void circ2Text_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(circ2Text.Text, out circ2)) {
                calculations();
            }
        }

        private void price1Text_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(price1Text.Text, out price1)) {
                calculations();
            }
        }

        private void price2Text_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(price2Text.Text, out price2)) {
                calculations();
            }
            
        }
        private void reset() {

        }
        private void calculations() {
            surface1 = (3.14 * Convert.ToDouble((circ1 / 2) * (circ1 / 2)));
            surface2 = (3.14 * Convert.ToDouble((circ2/2) * (circ2 / 2)));
            ratio1 = surface1/price1;
            ratio2 = surface2 / price2;
            output.Text = surface1.ToString();
            surfaceArea1.Text = "Surface area is " + surface1.ToString("F2") + "cm²";
            surfaceArea2.Text = "Surface area is " + surface2.ToString("F2") + "cm²";

            ratio1Text.Text = "Pizza1 is " + ratio1.ToString("F2") + "cm²/₺";
            ratio2Text.Text = "Pizza2 is " + ratio2.ToString("F2") + "cm²/₺";
            if(ratio1==0 || ratio2==0) { output.Text = "Any pizza is better than no pizza!!!"; }
            else if(ratio1 > ratio2) {
                output.Text = "Pizza 1 is " + (((ratio1 / ratio2) - 1) * 100).ToString("F2") + "% better!";
            }
            else if (ratio2 > ratio1) {
                output.Text = "Pizza 2 is " + (((ratio2 / ratio1) - 1) * 100).ToString("F2") + "% better!";
            }
            else output.Text = "Both pizzas are equal.";
        }

        private void circ1Text_Click(object sender, EventArgs e) {
            circ1Text.Text = "";
            circ1Text.ForeColor = Color.Black;
        }

        private void circ2Text_Click(object sender, EventArgs e) {
            circ2Text.Text = "";
            circ2Text.ForeColor = Color.Black;

        }

        private void price1Text_Click(object sender, EventArgs e) {
            price1Text.Text = "";
            price1Text.ForeColor = Color.Black;

        }

        private void price2Text_Click(object sender, EventArgs e) {
            price2Text.Text = "";
            price2Text.ForeColor = Color.Black;

        }
    }
    public class SemiTransparentLabel : Label {
        public SemiTransparentLabel() {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            if (Parent != null) {
                using (var brush = new SolidBrush(Color.FromArgb(128, BackColor))) {
                    e.Graphics.FillRectangle(brush, ClientRectangle);
                }
            }
        }
    }
}
