using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Индивидуальный_Проект
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            deck.BackgroundImage = Image.FromFile("D:/ПКГХ/УП/IP_img/cards/shirt.png");
            result_txt.Visible = false;
            bet.Enabled = false;
            stand.Enabled = false;
            plus5.Enabled = false;
            plus10.Enabled = false;
            plus25.Enabled = false;
            plus50.Enabled = false;
            hit.Enabled = false;
            bet.Visible = false;
            stand.Visible = false;
            plus5.Visible = false;
            plus10.Visible = false;
            plus25.Visible = false;
            plus50.Visible = false;
            hit.Visible = false;

            PlayerCard1.Visible = false;
            PlayerCard2.Visible = false;
            PlayerCard3.Visible = false;
            PlayerCard4.Visible = false;
            PlayerCard5.Visible = false;
            PlayerCard6.Visible = false;
            PlayerCard7.Visible = false;
            PlayerCard8.Visible = false;
            PlayerCard9.Visible = false;
            PlayerCard10.Visible = false;
            PlayerCard11.Visible = false;
            PlayerCard12.Visible = false;
            PlayerCard13.Visible = false;
            PlayerCard14.Visible = false;

            DealerCard1.Visible = false;
            DealerCard2.Visible = false;
            DealerCard3.Visible = false;
            DealerCard4.Visible = false;
            DealerCard5.Visible = false;
            DealerCard6.Visible = false;
            DealerCard7.Visible = false;
            DealerCard8.Visible = false;
            DealerCard9.Visible = false;
            DealerCard10.Visible = false;
            DealerCard11.Visible = false;
            DealerCard12.Visible = false;
            DealerCard13.Visible = false;
            DealerCard14.Visible = false;
        }
        //Класс с глобальными переменными: bet_am, bank_am - Объем ставки и количество валюты в банке; cards_am_p, cards_am_d - общая стоимость карт игрока и дилера; p_stop, d_stop - индексы остановки сдачи карт игроку и дилеру; CardPath - путь к изображениям игральных карт; p_cards_on, d_cards_on - количество карт на столе у игрока и дилера, используются для определения, в какой PictureBox вставлять изображения карт; deck - массив колоды с наименованиями изображений карт; index_9 - индекс местоположения 9.4 в массиве deck.
        static class Global
        {
            public static int bet_am = 0;
            //public static int bet_am
            //{
            //    get { return Bet_amo; }
            //    set { Bet_amo = value; }
            //}

            public static int bank_am = 100;
            //public static int bank_am
            //{
            //    get { return Bank_amo; }
            //    set { Bank_amo = value; }
            //}

            public static int cards_am_p = 0;
            //public static int cards_am_p
            //{
            //    get { return Cards_amo_p; }
            //    set { Cards_amo_p = value; }
            //}
            public static int cards_am_d = 0;
            //public static int cards_am_d
            //{
            //    get { return Cards_amo_d; }
            //    set { Cards_amo_d = value; }
            //}
            public static int p_stop = 0;
            //public static int p_stop
            //{
            //    get { return p_Stop; }
            //    set { p_Stop = value; }
            //}
            public static int d_stop = 0;
            //public static int d_stop
            //{
            //    get { return d_Stop; }
            //    set { d_Stop = value; }
            //}
            public static string CardPath = "D:/ПКГХ/УП/IP_img/cards/";
            //public static string CardPath
            //{
            //    get { return cardPath; }
            //    // set { cardPath = value; }
            //}
            public static int p_cards_on = 0;
            //public static int p_cards_on
            //{
            //    get { return p_Cards_on; }
            //    set { p_Cards_on = value; }
            //}
            public static int d_cards_on = 0;
            //public static int d_cards_on
            //{
            //    get { return d_Cards_on; }
            //    set { d_Cards_on = value; }
            //}

            public static string[] deck = { "2.1", "2.2", "2.3", "2.4", "3.1", "3.2", "3.3", "3.4", "4.1", "4.2", "4.3", "4.4", "5.1", "5.2", "5.3", "5.4", "6.1", "6.2", "6.3", "6.4", "7.1", "7.2", "7.3", "7.4", "8.1", "8.2", "8.3", "8.4", "9.1", "9.2", "9.3", "9.4", "10.1", "10.2", "10.3", "10.4", "11.1", "11.2", "11.3", "11.4", "12.1", "12.2", "12.3", "12.4", "13.1", "13.2", "13.3", "13.4", "14.1", "14.2", "14.3", "14.4" };
            //public static string[] deck
            //{
            //    get { return Deck; }
            //    set { Deck = value; }
            //}
            public static int index_9 = 31;
        }
        //Кнопка "Начать игру"
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            deckVariants.Enabled = false;

            bet.Visible = true;
            plus5.Visible = true;
            plus10.Visible = true;
            plus25.Visible = true;
            plus50.Visible = true;
            bet.Enabled = true;
            plus5.Enabled = true;
            plus10.Enabled = true;
            plus25.Enabled = true;
            plus50.Enabled = true;
            BankAmount.Text = "$" + Global.bank_am.ToString();
            BetAmount.Text = "$" + Global.bet_am.ToString();


        }

        private void plus5_Click(object sender, EventArgs e)
        {
            if (Global.bank_am - 5 >= 0)
            {
                Global.bank_am -= 5;
                Global.bet_am += 5;
                BankAmount.Text = "$" + Global.bank_am.ToString();
                BetAmount.Text = "$" + Global.bet_am.ToString();
            }
            else
            {
                plus5.Enabled = false;
            }

        }

        private void plus10_Click(object sender, EventArgs e)
        {
            if (Global.bank_am - 10 >= 0)
            {
                Global.bank_am -= 10;
                Global.bet_am += 10;
                BankAmount.Text = "$" + Global.bank_am.ToString();
                BetAmount.Text = "$" + Global.bet_am.ToString();
            }
            else
            {
                plus10.Enabled = false;
            }
        }

        private void plus25_Click(object sender, EventArgs e)
        {
            if (Global.bank_am - 25 >= 0)
            {
                Global.bank_am -= 25;
                Global.bet_am += 25;
                BankAmount.Text = "$" + Global.bank_am.ToString();
                BetAmount.Text = "$" + Global.bet_am.ToString();
            }
            else
            {
                plus25.Enabled = false;
            }
        }

        private void plus50_Click(object sender, EventArgs e)
        {
            if (Global.bank_am - 50 >= 0)
            {
                Global.bank_am -= 50;
                Global.bet_am += 50;
                BankAmount.Text = "$" + Global.bank_am.ToString();
                BetAmount.Text = "$" + Global.bet_am.ToString();
            }
            else
            {
                plus50.Enabled = false;
            }
        }
        //Кнопка "Ставка"
        private void bet_Click(object sender, EventArgs e)
        {
            if (Global.bet_am > 0)
            {
               
                hit.Enabled = true;
                stand.Enabled = true;
                bet.Enabled = false;
                plus5.Enabled = false;
                plus10.Enabled = false;
                plus25.Enabled = false;
                plus50.Enabled = false;
                hit.Visible = true;
                stand.Visible = true;
                bet.Visible = false;
                plus5.Visible = false;
                plus10.Visible = false;
                plus25.Visible = false;
                plus50.Visible = false;
                int i;
                i = 2;
                Card_Deal_P(i);
                i = 1;
                Card_Deal_D(i, 0);

            }
        }
        //Кнопка "Еще"
        private void hit_Click(object sender, EventArgs e)
        {
            int i;
            
            i = 1;
            Card_Deal_P(i);
            
        }
        //Кнопка "Хватит"
        private void stand_Click(object sender, EventArgs e)
        {
            int i;
            Global.p_stop = 1;
            hit.Enabled = false;
            i = 1;
            Card_Deal_D(i, 1);
        }
        //Кнопка "Выход"
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Функция раздачи карт игроку (На вход передается количество карт, которые нужно сдать)
        public async void Card_Deal_P(int iter)
        {
            Random random = new Random();
            string targetcardName1="";
            int tcN1;
            string targetcardName2;
            int tcN2=0;
            string targetcard="";
            int tc_cost=0;
            for (int i = 0; i < iter; i++)
            {
                if (deckVariants.SelectedIndex == 0 || deckVariants.SelectedIndex == -1)
                {
                    tcN1 = random.Next(2, 14);
                    tcN2 = random.Next(1, 4);
                    tc_cost = tcN1;
                    if (tcN1 > 10 && tcN1 < 14)
                    {
                        tc_cost = 10;
                    }
                    else if (tcN1 == 14)
                    {
                        if (tcN1 + Global.cards_am_p <= 21)
                        {
                            tc_cost = 11;
                        }
                        else if (tcN1 + Global.cards_am_p > 21)
                        {
                            tc_cost = 1;
                        }
                    }
                    targetcardName1 = Convert.ToString(tcN1);
                    targetcardName2 = Convert.ToString(tcN2);
                    targetcard = Global.CardPath + targetcardName1 + "." + targetcardName2 + ".png";
                }
                else if(deckVariants.SelectedIndex == 1)
                {
                    tcN1 = random.Next(0, Global.deck.GetLength(0)-1);
                    
                    if (tcN1 <= Global.index_9)
                    {
                        tc_cost = Convert.ToInt32(Global.deck[tcN1].Substring(0, 1));
                        Global.index_9 -= 1;
                    }
                    else if (tcN1 > Global.index_9)
                    {
                        tc_cost = Convert.ToInt32(Global.deck[tcN1].Substring(0, 2));
                    }

                    if (tc_cost > 10 && tc_cost < 14)
                    {
                        tc_cost = 10;
                    }
                    else if (tc_cost == 14)
                    {
                        if (tc_cost + Global.cards_am_p <= 21)
                        {
                            tc_cost = 11;
                        }
                        else if (tc_cost + Global.cards_am_p > 21)
                        {
                            tc_cost = 1;
                        }
                    }

                    string[] tempdeck = new string[Global.deck.GetLength(0) - 1];
                    for (int j = 0; j < tcN1; j++)
                    {
                        tempdeck[j] = Global.deck[j];
                    }

                    
                    for (int k = tcN1; k < tempdeck.GetLength(0); k++)
                    {
                        tempdeck[k] = Global.deck[k + 1];
                    }
                    
                    targetcardName1 = Global.deck[tcN1];
                    targetcard = Global.CardPath + targetcardName1 + ".png";
                    Global.deck = tempdeck;
                    
                }
                switch (i + Global.p_cards_on)
                {
                    case 0: PlayerCard1.BackgroundImage = Image.FromFile(targetcard); PlayerCard1.Visible = true; break;
                    case 1: PlayerCard2.BackgroundImage = Image.FromFile(targetcard); PlayerCard2.Visible = true; break;
                    case 2: PlayerCard3.BackgroundImage = Image.FromFile(targetcard); PlayerCard3.Visible = true; break;
                    case 3: PlayerCard4.BackgroundImage = Image.FromFile(targetcard); PlayerCard4.Visible = true; break;
                    case 4: PlayerCard5.BackgroundImage = Image.FromFile(targetcard); PlayerCard5.Visible = true; break;
                    case 5: PlayerCard6.BackgroundImage = Image.FromFile(targetcard); PlayerCard6.Visible = true; break;
                    case 6: PlayerCard7.BackgroundImage = Image.FromFile(targetcard); PlayerCard7.Visible = true; break;
                    case 7: PlayerCard8.BackgroundImage = Image.FromFile(targetcard); PlayerCard8.Visible = true; break;
                    case 8: PlayerCard9.BackgroundImage = Image.FromFile(targetcard); PlayerCard9.Visible = true; break;
                    case 9: PlayerCard10.BackgroundImage = Image.FromFile(targetcard); PlayerCard10.Visible = true; break;
                    case 10: PlayerCard11.BackgroundImage = Image.FromFile(targetcard); PlayerCard11.Visible = true; break;
                    case 11: PlayerCard12.BackgroundImage = Image.FromFile(targetcard); PlayerCard12.Visible = true; break;
                    case 12: PlayerCard13.BackgroundImage = Image.FromFile(targetcard); PlayerCard13.Visible = true; break;
                    case 13: PlayerCard14.BackgroundImage = Image.FromFile(targetcard); PlayerCard14.Visible = true; break;
                    default: break;
                }
                Global.cards_am_p += tc_cost;
                PlayerCardPoints.Text = Global.cards_am_p.ToString();
                await Task.Delay(600);
                Win_Condition();
                
            }
            Global.p_cards_on += iter;
            
        }
        //Функция раздачи карт дилеру (На вход передается количество карт, которые нужно сдать)
        public async void Card_Deal_D(int iter, int stand)
        {
            Random random = new Random();
            string targetcardName1=null;
            int tcN1;
            string targetcardName2=null;
            int tcN2;
            string targetcard="";
            int tc_cost=0;
            for (int i = 0; i < iter; i++)
            {
                if (deckVariants.SelectedIndex == 0|| deckVariants.SelectedIndex==-1)
                {
                    tcN1 = random.Next(2, 14);
                    tcN2 = random.Next(1, 4);
                    tc_cost = tcN1;
                    if (tcN1 > 10 && tcN1 < 14)
                    {
                        tc_cost = 10;
                    }
                    else if (tcN1 == 14)
                    {
                        if (tcN1 + Global.cards_am_d <= 21)
                        {
                            tc_cost = 11;
                        }
                        else if (tcN1 + Global.cards_am_d > 21)
                        {
                            tc_cost = 1;
                        }
                    }
                    targetcardName1 = Convert.ToString(tcN1);
                    targetcardName2 = Convert.ToString(tcN2);
                    targetcard = Global.CardPath + targetcardName1 + "." + targetcardName2 + ".png";
                }
                else if (deckVariants.SelectedIndex == 1)
                {
                    tcN1 = random.Next(0, Global.deck.GetLength(0) - 1);
                    if (tcN1 <= Global.index_9)
                    {
                        tc_cost = Convert.ToInt32(Global.deck[tcN1].Substring(0, 1));
                        Global.index_9 -= 1;
                    }
                    else if (tcN1 > Global.index_9)
                    {
                        tc_cost = Convert.ToInt32(Global.deck[tcN1].Substring(0, 2));
                    }

                    if (tc_cost > 10 && tc_cost < 14)
                    {
                        tc_cost = 10;
                    }
                    else if (tc_cost == 14)
                    {
                        if (tc_cost + Global.cards_am_d <= 21)
                        {
                            tc_cost = 11;
                        }
                        else if (tc_cost + Global.cards_am_d > 21)
                        {
                            tc_cost = 1;
                        }
                    }

                    string[] tempdeck = new string[Global.deck.GetLength(0) - 1];
                    for (int j = 0; j < tcN1; j++)
                    {
                        tempdeck[j] = Global.deck[j];
                    }


                    for (int k = tcN1; k < tempdeck.GetLength(0); k++)
                    {
                        tempdeck[k] = Global.deck[k + 1];
                    }
                    
                    targetcardName1 = Global.deck[tcN1];
                    targetcard = Global.CardPath + targetcardName1 + ".png";
                    Global.deck = tempdeck;
                }
                switch (i + Global.d_cards_on)
                {
                    case 0: DealerCard1.BackgroundImage = Image.FromFile(targetcard); DealerCard1.Visible = true; break;
                    case 1: DealerCard2.BackgroundImage = Image.FromFile(targetcard); DealerCard2.Visible = true; break;
                    case 2: DealerCard3.BackgroundImage = Image.FromFile(targetcard); DealerCard3.Visible = true; break;
                    case 3: DealerCard4.BackgroundImage = Image.FromFile(targetcard); DealerCard4.Visible = true; break;
                    case 4: DealerCard5.BackgroundImage = Image.FromFile(targetcard); DealerCard5.Visible = true; break;
                    case 5: DealerCard6.BackgroundImage = Image.FromFile(targetcard); DealerCard6.Visible = true; break;
                    case 6: DealerCard7.BackgroundImage = Image.FromFile(targetcard); DealerCard7.Visible = true; break;
                    case 7: DealerCard8.BackgroundImage = Image.FromFile(targetcard); DealerCard8.Visible = true; break;
                    case 8: DealerCard9.BackgroundImage = Image.FromFile(targetcard); DealerCard9.Visible = true; break;
                    case 9: DealerCard10.BackgroundImage = Image.FromFile(targetcard); DealerCard10.Visible = true; break;
                    case 10: DealerCard11.BackgroundImage = Image.FromFile(targetcard); DealerCard11.Visible = true; break;
                    case 11: DealerCard12.BackgroundImage = Image.FromFile(targetcard); DealerCard12.Visible = true; break;
                    case 12: DealerCard13.BackgroundImage = Image.FromFile(targetcard); DealerCard13.Visible = true; break;
                    case 13: DealerCard14.BackgroundImage = Image.FromFile(targetcard); DealerCard14.Visible = true; break;
                    default: break;
                }
                Global.cards_am_d += tc_cost;
                DealerCardPoints.Text = Global.cards_am_d.ToString();
                if (Global.cards_am_d < 17 && stand == 1) { iter += 1; }
                else if (Global.cards_am_d >= 17 && stand == 1) { Global.d_stop = 1; }
                await Task.Delay(600);
                Win_Condition();
                
            }
            Global.d_cards_on += iter;
            
        }
        //Функция проверки победителя
        public void Win_Condition()
        {
            if (Global.cards_am_p > 21)
            {
                More21();
            }
            else if (Global.p_stop == 1 && Global.d_stop == 1 && Global.cards_am_p < Global.cards_am_d && Global.cards_am_p < 21 && Global.cards_am_d <= 21 || Global.cards_am_d == 21 && Global.cards_am_p<21)
            {
                Loose();
            }
            else if (Global.p_stop == 1 && Global.d_stop == 1 && Global.cards_am_p == Global.cards_am_d)
            {
                Draw();
            }
            else if (Global.p_stop == 1 && Global.d_stop == 1 && Global.cards_am_p > Global.cards_am_d && Global.cards_am_p != 21 || Global.cards_am_d > 21)
            {
                Win();
            }
            else if (Global.cards_am_p == 21)
            {
                Blackjack();
            }
            else if (Global.deck.GetLength(0) == 0)
            {
                Reshuffle();
            }
        }
        //Функции вывода на экран результата раунда
        public void More21()
        {
            result_txt.Text = "перебор";
            result_txt.ForeColor = Color.OrangeRed;
            result_txt.Visible = true;
            Next_Round();
        }

        public void Loose()
        {
            result_txt.Text = "вы проиграли";
            result_txt.ForeColor = Color.Red;
            result_txt.Visible = true;
            Next_Round();
        }
        public void Draw()
        {
            result_txt.Text = "ничья";
            result_txt.ForeColor = Color.Yellow;
            result_txt.Visible = true;
            Global.bank_am += Global.bet_am;
            Next_Round();
        }
        public void Win()
        {
            result_txt.Text = "вы выиграли";
            result_txt.ForeColor = Color.PaleGreen;
            result_txt.Visible = true;
            Global.bank_am += Global.bet_am * 2;
            Next_Round();
        }
        public void Blackjack()
        {
            result_txt.Text = "блэк-джек";
            result_txt.ForeColor = Color.Black;
            result_txt.Visible = true;
            Global.bank_am += Global.bet_am * 3;
            Next_Round();
        }
        //Функция перемешивания колоды, которая вызывается, если колода заканчивается в течении раунда
        public async void Reshuffle()
        {
            string[] tempdeck= { "2.1", "2.2", "2.3", "2.4", "3.1", "3.2", "3.3", "3.4", "4.1", "4.2", "4.3", "4.4", "5.1", "5.2", "5.3", "5.4", "6.1", "6.2", "6.3", "6.4", "7.1", "7.2", "7.3", "7.4", "8.1", "8.2", "8.3", "8.4", "9.1", "9.2", "9.3", "9.4", "10.1", "10.2", "10.3", "10.4", "11.1", "11.2", "11.3", "11.4", "12.1", "12.2", "12.3", "12.4", "13.1", "13.2", "13.3", "13.4", "14.1", "14.2", "14.3", "14.4" };
            result_txt.Height = 257;
            result_txt.Location = new Point(0, 212);
            result_txt.Text = "Перемешиваем колоду";
            result_txt.ForeColor = Color.Black;
            result_txt.Visible = true;
            Global.deck = tempdeck;
            Global.index_9 = 31;
            await Task.Delay(1500);
            result_txt.Visible = false;
            result_txt.Height = 149;
            result_txt.Location = new Point(0, 266);
        }
        //Функция перемешивания колоды без вывода текста на экран, которая вызывается в конце раунда
        public void Reshuffle_wo_txt()
        {
            string[] tempdeck = { "2.1", "2.2", "2.3", "2.4", "3.1", "3.2", "3.3", "3.4", "4.1", "4.2", "4.3", "4.4", "5.1", "5.2", "5.3", "5.4", "6.1", "6.2", "6.3", "6.4", "7.1", "7.2", "7.3", "7.4", "8.1", "8.2", "8.3", "8.4", "9.1", "9.2", "9.3", "9.4", "10.1", "10.2", "10.3", "10.4", "11.1", "11.2", "11.3", "11.4", "12.1", "12.2", "12.3", "12.4", "13.1", "13.2", "13.3", "13.4", "14.1", "14.2", "14.3", "14.4" };
            Global.index_9 = 31;
            Global.deck = tempdeck;
        }
        //Функция перехода к следующему раунду, которая вызывается, когда установлен результат раунда
        public async void Next_Round()
        {
            await Task.Delay(10000);
            result_txt.Visible = false;
            stand.Enabled = false;
            hit.Enabled = false;
            stand.Visible = false;
            hit.Visible = false;

            PlayerCard1.Visible = false;
            PlayerCard2.Visible = false;
            PlayerCard3.Visible = false;
            PlayerCard4.Visible = false;
            PlayerCard5.Visible = false;
            PlayerCard6.Visible = false;
            PlayerCard7.Visible = false;
            PlayerCard8.Visible = false;
            PlayerCard9.Visible = false;
            PlayerCard10.Visible = false;
            PlayerCard11.Visible = false;
            PlayerCard12.Visible = false;
            PlayerCard13.Visible = false;
            PlayerCard14.Visible = false;

            DealerCard1.Visible = false;
            DealerCard2.Visible = false;
            DealerCard3.Visible = false;
            DealerCard4.Visible = false;
            DealerCard5.Visible = false;
            DealerCard6.Visible = false;
            DealerCard7.Visible = false;
            DealerCard8.Visible = false;
            DealerCard9.Visible = false;
            DealerCard10.Visible = false;
            DealerCard11.Visible = false;
            DealerCard12.Visible = false;
            DealerCard13.Visible = false;
            DealerCard14.Visible = false;

            Global.bet_am = 0;
            Global.cards_am_p = 0;
            Global.cards_am_d = 0;
            Global.p_stop = 0;
            Global.d_stop = 0;
            Global.p_cards_on = 0;
            Global.d_cards_on = 0;
            Reshuffle_wo_txt();

            bet.Visible = true;
            plus5.Visible = true;
            plus10.Visible = true;
            plus25.Visible = true;
            plus50.Visible = true;
            bet.Enabled = true;
            plus5.Enabled = true;
            plus10.Enabled = true;
            plus25.Enabled = true;
            plus50.Enabled = true;
            BankAmount.Text = "$" + Global.bank_am.ToString();
            BetAmount.Text = "$" + Global.bet_am.ToString();
        }
    }
}


