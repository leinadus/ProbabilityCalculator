using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProbabilityCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double prob_success = 0;
        double percent = 0;
        double prob = 0;
        double attempts = 0;
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            
            try
            {
                percent = double.Parse(tb_percent.Text);
                
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }
            try
            {
                attempts = double.Parse(tb_attempts.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input");
            }

            prob = percent / 100;
            prob_success = Math.Round((100 - 100 * Math.Pow(1 - prob, attempts)),2);
            lbl_odds.Text = prob_success.ToString()+"% chance of getting one success";
        }

        Random rnd = new Random();
        int countSuccess = 0;
        int countFail = 0;
        double countAttempt = 0;
        double successRate = 0;
        private void Btn_enhance_Click(object sender, EventArgs e)
        {
            if (percent == 0 || attempts == 0)
            {
                MessageBox.Show("Wrong Input");
            }
            else
            {
                double roll = Math.Round(rnd.NextDouble() * (100 - 0) + 0, 2);
                if (roll > percent)
                {
                    countFail++;
                    lbl_result.ForeColor = Color.Red;
                    lbl_result.Text = "FAIL!";
                    lbl_fails.Text = "Fails: " + countFail.ToString();
                }
                else
                {
                    countSuccess++;
                    lbl_result.ForeColor = Color.Green;
                    lbl_result.Text = "SUCCESS!";
                    lbl_successes.Text = "Successes: " + countSuccess.ToString();
                }
                countAttempt++;
                lbl_attempts.Text = "Attempts: " + countAttempt;

                if (countSuccess == 0)
                {
                    lbl_successRate.Text = "Success Rate: 0.00%";
                }
                else
                {
                    successRate = Math.Round(countSuccess / countAttempt * 100, 2);
                    lbl_successRate.Text = "Success Rate: " + successRate.ToString() + "%";
                }
            }
        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            countSuccess = 0;
            countFail = 0;
            countAttempt = 0;
            successRate = 0;
            lbl_fails.Text = "Fails: " + countFail.ToString();
            lbl_successes.Text = "Successes: " + countSuccess.ToString();
            lbl_attempts.Text = "Attempts: " + countAttempt;
            lbl_successRate.Text = "Success Rate: 0.00%";

        }

        
    }
}
