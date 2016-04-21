using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* RESOURCE: http://wiki.dataconsultants.com/doku.php?id=wiki:supp:dmv
             https://www.dmv.ca.gov/portal/dmv/detail/vr/vr_info
             https://www.dmv.ca.gov/portal/dmv/detail/pubs/brochures/fast_facts/ffvr34
  
    Used Vehicle with Expired Tags

    Previous selling price of the vehicle* (Rounded to the nearest odd $100) X 0.65% (DMV Multiplier) = Vehicle License fee

    + DMV Add-On Amount (varies by County, ranges from $1.00 to $24.00)

    DMV Chart Showing County Add Amounts
    + CA Base DMV Fee (Currently Reg Fee of $46 + CHP Fee of $24) Total $70.00

    + $20.00 Smog Abatement - If the vehicle is Gas Driven AND 6 model years old or less

    + $15.00 Title Transfer Fee Amount

    + $8.00 Smog Waiver Fee - If the vehicle is Gas Driven AND 4 model years old or less

    = Total California DMV License Fee
 
    *If the vehicle is greater than 4 model years old then the $8.00 Smog Waiver Fee is not 
    charged and the Dealer Smog Fee (typically $50.00) and the State Smog Cert. fee ($8.25) are charged. 

  
 */
namespace DMVFeeCalculator
{
    public partial class Form1 : Form
    {

        private const decimal DMVMultiplier = 0.0065M; //This is used to calculate VLF.

        //7.625% Sales Tax + $19 Air Quality + $4 Auto Theft/DUI + $4 Abandoned Vehicle + $4 Fingerprint
        private const decimal stanCountyAmount = 24.0M; //This is only good for Stanislaus County

        //$70.00 CA Base DMV Fee (Currently Reg Fee of $46 + CHP Fee of $24)
        private const int CABaseFee = 70;

        //$20.00 Smog Abatement (used if vehicle is Gas AND (current year - model year) < 6)
        private const int smogAbatement = 20;

        //$15.00 Title Transfer Fee
        private const int titleTransferFee = 15;

        //$8.00 Smog Waiver Fee (used if vehicle is Gas AND (current year - model year) < 4)
        private const int smogWaiver = 8;

        private int prevSellAmnt;

        private decimal VLF = 0.00M;

        private decimal lateFee = 0.00M;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int vehicleYear = this.vehicleYear.Value.Year;
            int vehicleAge = DateTime.Now.Year - vehicleYear;
            prevSellAmnt = Int32.Parse(this.prevSellPrice.Text);

            //Calculate Vehicle License Fees.
            if (vehicleAge < 4)
            {
                VLF = (prevSellAmnt * DMVMultiplier) + stanCountyAmount + CABaseFee + smogAbatement + smogWaiver;
            }
            if (vehicleAge >= 4 && vehicleAge < 6)
            {
                VLF = (prevSellAmnt * DMVMultiplier) + stanCountyAmount + CABaseFee + smogAbatement;
            }
            else
            {
                VLF = (prevSellAmnt * DMVMultiplier) + stanCountyAmount + CABaseFee;
            }

            VLF += VLF * 0.07625M;

            //Calculate DMV Late Fees. Hold on tight for the if waterfall.
            if (this.radioNotLate.Checked)
            {
                lateFee = 0;
            }
            if (this.radio10Days.Checked)
            {
                lateFee = (0.10M * VLF) + 10 + 10;
            }
            if (this.radio30Days.Checked)
            {
                lateFee = (0.20M * VLF) + 15 + 15;
            }
            if (this.radio1Year.Checked)
            {
                lateFee = (0.60M * VLF) + 30 + 30;
            }
            if (this.radio2Years.Checked)
            {
                lateFee = (0.80M * VLF) + 50 + 50;
            }
            if (this.radioMoreThan2Years.Checked)
            {
                lateFee = (1.60M * VLF) + 100 + 100;
            }

            VLF = Decimal.Round((VLF), 2);
            lateFee = Decimal.Round(lateFee, 2);

            VLFOutput.Text = VLF.ToString();
            lateOutput.Text = lateFee.ToString();
            estimateOutput.Text = (VLF + lateFee).ToString();

        }
    }
}
