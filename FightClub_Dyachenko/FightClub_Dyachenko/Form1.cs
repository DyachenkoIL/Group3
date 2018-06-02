using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub_Dyachenko
{
    enum TARGET { Head = 1, Body, Legs } //список целей блока/атаки
    enum ENEMIES : int { Clone, Titan, Hades, Zeus, Hercules, SubZero, Scorpion, Creator } //список имён врагов

    public partial class Form1 : Form
    {
        Gamer you = new Gamer("Top Gamer");
        Computer enemy = new Computer();
        int turn = 1;
        public Form1()
        {
            InitializeComponent();
            Text = "FightClub";
            this.BackColor = Color.Aquamarine;
            this.ForeColor = Color.Red;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            butstart.Visible = false;
            entername.Visible = false;
            restbut.Visible = true;
            if (textBox1.Text != "")
                you.Name = textBox1.Text;
            player1name.Text = you.Name;
            player1name.Visible = true;
            player2name.Text = enemy.Name;
            player2name.Visible = true;
            move.Visible = true;
            move.Text = "Бей пока можешь, выбери цель";
            hpBar1.Visible = true;
            hpBar2.Visible = true;
            butblock1.Visible = true;
            butblock1.Text = "В голову";
            butblock2.Visible = true;
            butblock2.Text = "По корпусу";
            butblock3.Visible = true;
            butblock3.Text = "По ногам";
            LogTextBox.Visible = true;
            LogTextBox.Text += "Бой начался";
            hp1.Visible = true;
            hp1.Text = you.HP.ToString();
            hp2.Visible = true;
            hp2.Text = enemy.HP.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void butblock1_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 1)
            {
                Random rnd = new Random();
                enemy.SetBlock((TARGET)rnd.Next(1, 3));
                move.Text = "Бить хорошо, но пора занять оборону";
                if (enemy.GetHit(TARGET.Head, move2, LogTextBox) <= 0)
                {
                    move.Visible = false;
                    butblock1.Visible = false;
                    butblock2.Visible = false;
                    butblock3.Visible = false;
                    move2.MinimumSize = new System.Drawing.Size(400, 240);
                    move2.Location = new Point(0, 365);
                    move2.Width = 500;
                }
                hp2.Text = enemy.HP.ToString();
                hpBar2.Value = enemy.HP;

            }
            else
            {
                you.SetBlock(TARGET.Head);
                Random rnd = new Random();
                move.Text = "Бей пока можешь, выбери цель";
                if (you.GetHit((TARGET)rnd.Next(1, 3), move2, LogTextBox) <= 0)
                {
                    move.Visible = false;
                    butblock1.Visible = false;
                    butblock2.Visible = false;
                    butblock3.Visible = false;
                    move2.MinimumSize = new System.Drawing.Size(400, 240);
                    move2.Location = new Point(0, 365);
                    move2.Width = 500;
                }
                hp1.Text = you.HP.ToString();
                hpBar1.Value = you.HP;

            }
            turn += 1;
        }

        private void butblock2_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 1)
            {
                Random rnd = new Random();
                enemy.SetBlock((TARGET)rnd.Next(1, 3));
                move.Text = "Бить хорошо, но пора занять оборону";
                if (enemy.GetHit(TARGET.Body, move2, LogTextBox) <= 0)
                {
                    move.Visible = false;
                    butblock1.Visible = false;
                    butblock2.Visible = false;
                    butblock3.Visible = false;
                    move2.MinimumSize = new System.Drawing.Size(400, 240);
                    move2.Location = new Point(0, 365);
                    move2.Width = 500;
                }
                hp2.Text = enemy.HP.ToString();
                hpBar2.Value = enemy.HP;

            }
            else
            {
                you.SetBlock(TARGET.Body);
                Random rnd = new Random();
                move.Text = "Бей пока можешь, выбери цель";
                if (you.GetHit((TARGET)rnd.Next(1, 3), move2, LogTextBox) <= 0)
                {
                    move.Visible = false;
                    butblock1.Visible = false;
                    butblock2.Visible = false;
                    butblock3.Visible = false;
                    move2.MinimumSize = new System.Drawing.Size(400, 240);
                    move2.Location = new Point(0, 365);
                    move2.Width = 500;
                }
                hp1.Text = you.HP.ToString();
                hpBar1.Value = you.HP;

            }

            turn += 1;
        }

        private void butblock3_Click(object sender, EventArgs e)
        {
            if (turn % 2 == 1)
            {
                Random rnd = new Random();
                enemy.SetBlock((TARGET)rnd.Next(1, 3));
                move.Text = "Бить хорошо, но пора занять оборону";
                if (enemy.GetHit(TARGET.Legs, move2, LogTextBox) <= 0)
                {
                    move.Visible = false;
                    butblock1.Visible = false;
                    butblock2.Visible = false;
                    butblock3.Visible = false;
                    move2.MinimumSize = new System.Drawing.Size(400, 240);
                    move2.Location = new Point(0, 365);
                    move2.Width = 500;
                }
                hp2.Text = enemy.HP.ToString();
                hpBar2.Value = enemy.HP;

            }
            else
            {
                you.SetBlock(TARGET.Legs);
                Random rnd = new Random();
                move.Text = "Бей пока можешь, выбери цель";
                if (you.GetHit((TARGET)rnd.Next(1, 3), move2, LogTextBox) <= 0)
                {
                    move.Visible = false;
                    butblock1.Visible = false;
                    butblock2.Visible = false;
                    butblock3.Visible = false;
                    move2.MinimumSize = new System.Drawing.Size(400, 240);
                    move2.Location = new Point(0, 365);
                    move2.Width = 500;
                }
                hp1.Text = you.HP.ToString();
                hpBar1.Value = you.HP;

            }

            turn += 1;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

    abstract class Player
    {
        public string Name;
        public TARGET Blocked;
        public int HP = 100;

        public virtual int GetHit(TARGET att, Label A, TextBox B)
        {
            if (att == Blocked)
                return (Block(A, B));
            else return (Wound(A, B));
        }

        public virtual void SetBlock(TARGET blk)
        {
            this.Blocked = blk;
        }

        public abstract int Block(Label a, TextBox b);
        public abstract int Wound(Label a, TextBox b);
        public abstract void Death(Label a, TextBox b);

    }


    class Gamer : Player
    {
        public Gamer(string na)
        {
            this.Name = na;
        }

        public override int Block(Label a, TextBox b)
        {
            a.Text = "Было сложно но вы смогли заблокировать этот удар!!!";
            b.Text += "     " + this.Name + " блокирует удар \nТекущие HP = " + this.HP;
            return HP;
        }

        public override int Wound(Label a, TextBox b)
        {
            this.HP -= 10;
            if (HP > 0)
            {
                a.Text = "Вы получили урон но бой не окончен!!!";
                b.Text += "     " + this.Name + " пропускает удар \nТекущие HP = " + this.HP;
                return HP;
            }
            else { Death(a, b); return 0; }
        }

        public override void Death(Label a, TextBox b)
        {
            a.Text = "К сожалению это конец.. поражение.. смерть.. приходите ещё..";
            b.Text += "     " + this.Name + " получает фатальный урон     Это конец";
        }

    }

    class Computer : Player
    {
        public override int Block(Label a, TextBox b)
        {
            a.Text = "Как вы не старались противник так и не заметил вашей атаки!!!";
            b.Text += "     " + this.Name + " блокирует удар     Текущие HP = " + this.HP;
            return HP;
        }

        public override int Wound(Label a, TextBox b)
        {
            this.HP -= 10;
            if (HP > 0)
            {
                a.Text = "Как же вы хороши противник истекает кровью продолжайте в том же духе!!!";
                b.Text += "     " + this.Name + " пропускает удар     Текущие HP = " + this.HP;
                return HP;
            }
            else { Death(a, b); return 0; }
        }

        public override void Death(Label a, TextBox b)
        {
            a.Text = "Противник повержен, отличная игра!!!";
            b.Text += "     " + this.Name + " получает фатальный урон     Это конец";
        }

        public Computer()
        {
            Random rnd = new Random();
            ENEMIES en = (ENEMIES)rnd.Next(Enum.GetNames(typeof(ENEMIES)).Length);
            this.Name = en.ToString();
        }
    }

}