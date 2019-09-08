using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMWinForm
{
    public partial class Form1 : Form
    {
        string path = @"E:\Универ\3 семестр\Programming languages\Labs\ATMWinForm\ATMWinForm\Cards.txt";
        List<Card> cards;
        int PINattempts = 0;
        bool WithdrawOrPut = false;//withdraw=false, put=true
        Card Currentcard;
        public Form1()
        {
            InitializeComponent();
            cards = WorkingWithCard.ReadInfo(path);

        }

        private void textCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) e.Handled = true;
           
        }

        private void textPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) e.Handled = true;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butNumContinue_Click(object sender, EventArgs e)
        {
            string cardNumber = textCardNumber.Text;
            bool exists = false;
            foreach(Card card in cards)
            {
                if(card.cardNumber==cardNumber)
                {
                    exists = true;
                    Currentcard = new Card(card);
                    break;
                }
            }
            if (exists)
            {
                butNumContinue.Visible = false;
                textCardNumber.Visible = false;
                labelCard.Visible = false;
                labelPIN.Visible = true;
                textPIN.Visible = true;
                butPINContinue.Visible = true;
                labelCommon.Text = "У Вас 3 попытки";
                textPIN.Focus();

            }
            else
            {
                labelCommon.Visible = true;
                labelCommon.Text = "Вашей карты нет в базе. Попробуйте ещё раз.";
                textCardNumber.Text = String.Empty;
            }
        }

        private void butPINContinue_Click(object sender, EventArgs e)
        {
           
            string PIN = textPIN.Text;
            if (Currentcard.PIN==PIN)
            {
                PINattempts = 0;
                butPINContinue.Visible = false;
                textPIN.Visible = false;
                labelPIN.Visible = false;
                butBalance.Visible = true;
                butWithdraw.Visible = true;
                butPutMoney.Visible = true;
                labelCommon.Text = String.Empty;
                butBalance.Focus();
            }
            else
            {
                PINattempts++;
                if (PINattempts == 3)
                {
                    PINattempts = 0;
                    Form1_Load(this, e);
                }
                else
                {
                   // labelCommon.Visible = true;
                    labelCommon.Text = String.Format($"Неверный ПИН.\nОсталось попыток: {3 - PINattempts}");
                    textPIN.Text = String.Empty;
                }
            }
            textPIN.Text = String.Empty;

        }

        private void textCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter) butNumContinue_Click(this, e);
        }

        private void textPIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) butPINContinue_Click(this, e);
        }

        private void butBalance_Click(object sender, EventArgs e)
        {
            //labelCommon.Visible = true;
            labelCommon.Text = ($"{Currentcard.Sum} руб.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butNumContinue.Visible = true;
            textCardNumber.Visible = true;
            labelCard.Visible = true;
            labelPIN.Visible = false;
            textPIN.Visible = false;
            butPINContinue.Visible = false;
            butBalance.Visible = false;
            butWithdraw.Visible = false;
            butPutMoney.Visible = false;
            textSum.Visible = false;
            labSum.Visible = false;
            labelCommon.Text = String.Empty;
            textCardNumber.Text = String.Empty;
            textCardNumber.Focus();
        }

        //public delegate void Some(string s);
        //Some Something;
        //public event Some FOP;
        private void butWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawOrPut = false;
            labSum.Visible = true;
            textSum.Visible = true;
            labelCommon.Text= String.Empty;
            textSum.Focus();
        }

        private void textSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) e.Handled = true;
        }

        private void textSum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int sum = Convert.ToInt32(textSum.Text);
                if (WithdrawOrPut==false)
                {
                    if (sum <= Currentcard.Sum)
                    {
                        Currentcard.Sum -= sum;
                        for (int i = 0; i < cards.Count; i++)
                        {
                            if (cards[i].cardNumber == Currentcard.cardNumber)
                            {
                                cards[i] = Currentcard;
                                break;
                            }
                        }
                        labelCommon.Text = "Операция прошла успешно";
                        WorkingWithCard.WriteInfoCards(cards, path);

                    }
                    else
                    {
                        labelCommon.Text = "Недостаточно средств";
                    }
                }
                else
                {
                    Currentcard.Sum += sum;
                    for (int i=0;i<cards.Count;i++)
                    {
                        if (cards[i].cardNumber==Currentcard.cardNumber)
                        {
                            cards[i] = Currentcard;
                            break;
                        }
                    }
                    labelCommon.Text = "Операция прошла успешно";
                    WorkingWithCard.WriteInfoCards(cards, path);
                }
                textSum.Text = String.Empty;
                textSum.Visible = false;
                labSum.Visible = false;
                butBalance.Focus();
            }
           
        }

        private void butPutMoney_Click(object sender, EventArgs e)
        {
            WithdrawOrPut = true;
            labSum.Visible = true;
            textSum.Visible = true;
            labelCommon.Text = String.Empty;
            textSum.Focus();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            Form1_Load(this, e);
        }

        
    }
}
