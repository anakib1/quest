using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace quest_firstA
{
    
    public partial class Form1 : Form
    {
        int firstAN;
        bool home = false;
        int mmc = 100;
        int[] answers = new int[100];
        string[,] actions = new string[2, 4];
        int number_of_answer = -1;
        public string GetAnswer(int answer)
        {
            if (number_of_answer == -1)
            {
                 number_of_answer++;
                return GetResult(answer);

            }
            answers[number_of_answer] = answer;
                debug_l.Text = "number of answer" + Convert.ToString(number_of_answer) + " " + Convert.ToString(answer);
                number_of_answer++;
                return GetResult(answer);
            
            
        }
        public void SetActions(string[] action, string[] result)
        {
            for (int i = 0; i < action.Length; i++)
            {
                actions[0, i] = action[i];
               switch(i)
                {
                    case 0:
                        {
                            firstA.Text = action[i];
                            break;
                        }
                    case 1:
                        {
                            secondA.Text = action[i];
                            break;
                        }
                    case 2:
                        {
                            thirdA.Text = action[i];
                            break;
                        }
                    case 3:
                        {
                            foursA.Text = action[i];
                            break;
                        }
                }
            }

            for (int i = 0; i < result.Length; i++)
                actions[1, i] = result[i];
        }
        public string GetResult(int number)
        {
            return actions[1, number-1];
        }
        public string[] ToArrayFromS(string s)
        {
            return s.Split(';').ToArray();
        }
       
        public  Form1()
        {
            InitializeComponent();
            description.Text = @"Hello. It`s second try to do normal quest) i help, u enjoy :D  ";
            description.Text += @"You got up. Everything is normal. What will u do?";
            SetActions(ToArrayFromS("go to school;lie further;die;go to mathbattle"), ToArrayFromS("You got up, and went to school, how will we get there?;ok, how long?;you are dead;how will we get there?"));
            
        }

        private void firstA_Click(object sender, EventArgs e)
        {

            description.Text = @GetAnswer(1);
            if (number_of_answer==0)
            {
                firstAN = 1;
                

                SetActions(ToArrayFromS("by train;by metro;peshkom nahui;na taxi"), ToArrayFromS("you entered the train. But there were KUBIK!;you got to the school! Where will u go?;ok, ti poshel.... no tut na tebia napali chechenci. THe battle begin!;ok, eto budet stiot 100mmc"));
                return;
            }
            if (firstAN == 1||(firstAN==4&&answers[0]==1&&answers[1]==0))
            {
                SetActions(ToArrayFromS("PRiv kubik-huebik!;aaaaaaaaa(run);try to kill kubik;hi..."), ToArrayFromS("kubik said \" HI \";u jumped from train end dead...;the battle begins!;kubik said \" HI \""));
                    return;
            }
            if(firstAN==2&&answers[0]==1&&answers[1]==0)
            {
                SetActions(ToArrayFromS("go to school;play games?;die;go to mathbattle"), ToArrayFromS("You got up, and went to school, how will we get there?;ok,which game?;you are dead;how will we get there?"));

            }
            if (firstAN == 2 && answers[0] == 1&&answers[1] == 1)
            {
               SetActions(ToArrayFromS("tu zalupa;to math; to kokosha; nah "), ToArrayFromS("the battle begins;ok. Answer this questions;TI CHTO PROGULIAL SREDU???(battle begins);you got to zhytomir"));
               
            }
            if((firstAN==4&&answers[0]==4&&answers[1]==1&&answers[2]==0)|| (firstAN == 4 && (answers[0] == 3||answers[0]==2) && answers[1] == 1 && answers[2] == 0))
            {
                Battle(description.Text, 50, 5);
                if (CheckRes())
                {
                    description.Text = "you won and got out of MB. Your actions?";
                    SetActions(ToArrayFromS("go home;go home; go home; go home "), ToArrayFromS("u got home;u got home;u got home;u got home"));
                    home = true;
                }
                else
                    End();
                return;
            }
            if (home)
            {
                MessageBox.Show("WAIT FOR UPDATES)", "that`s all");
                End("YOU WON", "U WON))");
            }
        }

        private void secondA_Click(object sender, EventArgs e)
        {
            description.Text = @GetAnswer(2);
            if (answers[0] == 2 && firstAN == 4 && answers[1] == 0)
            {

                SetActions(ToArrayFromS("lider1;lider3;178;208"), ToArrayFromS("It will be easy, battle begins;u lost;KILL DIDUR;U WON"));

            }
            if ((answers[1]==2&&answers[0]==1&&firstAN==1)||(answers[0]==1&&firstAN==4&&answers[1]==2))
            {
                End();
            }
            if((firstAN==4&&(answers[0]==4||answers[0]==2)&&answers[1]==2)||(firstAN == 4 && answers[0] == 3 && answers[1] == 2))
            {
                End("(FROM LIDER 3. DON~T TRY TO WIN");

            }
            if (number_of_answer == 0)
            {
                firstAN = 2;

                SetActions(ToArrayFromS("5min;10min;0min; INFINITY"), ToArrayFromS("ok. You lied 5 mins and got up. What will u do?;you got up. What will u do?;you got up. What will u do?;you dead in sleep. It was quite good death)"));

                return;
            }
            
            if (firstAN == 1 && answers[0] == 2 && answers[1] == 2)
            {
                Battle(description.Text, 100, 15);
                if (CheckRes())
                {
                    description.Text = "you won and got out of school. Your actions?";
                    SetActions(ToArrayFromS("go home;go home; go home; go home "), ToArrayFromS("u got home;u got home;u got home;u got home"));
                }
                else
                    End();
                return;
            }
            if (answers[0] == 2&&firstAN==1)
            {
                SetActions(ToArrayFromS("tu zalupa;to math; to kokosha; nah "), ToArrayFromS("the battle begins;ok.hit gumanitariy;TI CHTO PROGULIAL SREDU???(battle begins);you got to zhytomir"));
                return;
            }
            if (firstAN == 2&&answers[0]!=4)
            {


                SetActions(ToArrayFromS("go to school;play games?;die;go to mathbattle"), ToArrayFromS("You got up, and went to school, how will we get there?;ok,which game?;you are dead;how will we get there?"));
                return;
            }
            if (home)
            {
                MessageBox.Show("WAIT FOR UPDATES)", "that`s all");
                End("YOU WON", "U WON))");
            }
        }

        private void thirdA_Click(object sender, EventArgs e)
        {
            description.Text = @GetAnswer(3);
            if(firstAN==2&&answers[0]!=4&&answers[1]==3)
            {
                End();
            }
            if (number_of_answer == 0)
            {
                End();
            }
            if((firstAN == 4 && answers[0] == 4 && answers[1] == 3)|| (firstAN == 4 && (answers[0] == 2||answers[0]==4) && answers[1] == 3))
            {
                Battle(description.Text, 200, 9);
                if (CheckRes())
                {
                    description.Text = "you won and got out of MB. Your actions?";
                    SetActions(ToArrayFromS("go home;go home; go home; go home "), ToArrayFromS("u got home;u got home;u got home;u got home"));
                    home = true;
                }
                else
                    End();
            }
            if((firstAN==1||firstAN==4)&&answers[1]==3&&answers[0]==1&&answers[2]==0)
            {
                Battle(description.Text, 200, 15);
                if (CheckRes())
                {
                    description.Text = "you won and got to school. Your actions?";
                    SetActions(ToArrayFromS("tu zalupa;to math; to kokosha; nah "), ToArrayFromS("the battle begins;ok. Answer this questions;TI CHTO PROGULIAL SREDU???(battle begins);you got to zhytomir"));
                }
                else
                    End();
                return;
            }
            if((firstAN == 1 && answers[1] == 3 && answers[0] == 1 && answers[2] == 3)||(firstAN==2&&answers[0]==1&&answers[1]==1&&answers[2]==3))
            {
                Battle(description.Text, 1000, 39);
                if (CheckRes())
                {
                    description.Text = "you won and got out of school. Your actions?";
                    SetActions(ToArrayFromS("go home;go home; go home; go home "), ToArrayFromS("u got home;u got home;u got home;u got home"));
                    MessageBox.Show("WAIT FOR UPDATES)", "that`s all");
                    End("YOU WON", "U WON))");
                }
                else
                    End();
            }
            if (home)
            {
                MessageBox.Show("WAIT FOR UPDATES)", "that`s all");
                End("YOU WON", "U WON))");
            }
            if(answers[0]==3&&firstAN==4&&answers[1]==0)
            {
                Battle(description.Text, 1000, 35);
                if (CheckRes())
                {
                    description.Text = "you won and got to mathbattle. Your actions?(whom will u battle with?";
                    SetActions(ToArrayFromS("lider1;lider3;178;208"), ToArrayFromS("It will be easy, battle begins;u lost;KILL DIDUR;U WON"));

                }
                else
                    End();
            }
        }

        private void foursA_Click(object sender, EventArgs e)
        {
            description.Text = @GetAnswer(4);

            if (number_of_answer == 0)
            {
                SetActions(ToArrayFromS("by train;by metro;peshkom nahui;na taxi"), ToArrayFromS("you entered the train. But there were KUBIK!;you got to the mathbattle!;ok, ti poshel.... no tut na tebia napali chechenci;ok, eto budet stiot 100mmc. You got o MB. What team will u battle with?"));
                firstAN = 4;
                return;
            }
            if(answers[0]==4&&firstAN==4&&answers[1]==0)
            {
                mmc -= 100;
                mmc_count.Text = mmc.ToString();
                SetActions(ToArrayFromS("lider1;lider3;178;208"), ToArrayFromS("It will be easy, battle begins;u lost;KILL DIDUR;U WON"));

            }
            
            if (answers[0]==4&&firstAN==2)
            {
                End(description.Text);
            }
            if(firstAN == 4 && (answers[0] == 4||answers[0]==3||answers[0]==2) && answers[1] == 4)
            {
                End("YOU WON, and got home. Wait for updates", "U WON))");

            }
            if (home)
            {
                MessageBox.Show("WAIT FOR UPDATES)", "that`s all");
                End("YOU WON", "U WON))");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        void End()
        {
            Thread.Sleep(1000);
            MessageBox.Show("YOU ARE DEAD", "quest");

            Application.Exit();
        }
        void End(string c)
        {
            Thread.Sleep(1000);
            MessageBox.Show("YOU ARE DEAD  "+c, "quest");

            Application.Exit();

        }
        void End(string c,string c1)
        {
            Thread.Sleep(1000);
            MessageBox.Show(c,c1);

            Application.Exit();

        }
        void Battle(string des,int hp,int time)
        {
            Thread.Sleep(1000);

            Form2 form2 = new Form2(des,hp,time);
            form2.ShowDialog();
            
        }
        bool CheckRes()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\bidzi\source\repos\quest_firstA\quest_firstA\res_of_b.txt"))
            {
                //while (sr.ReadLine() == null)
                  //  continue;
                if (sr.ReadLine() == "True")
                        return true;
                else
                        return false;
                
            }
        }
    }
    public class Quest
    {
       
    }
}
