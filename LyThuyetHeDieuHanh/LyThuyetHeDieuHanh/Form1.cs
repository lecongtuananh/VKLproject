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

namespace LyThuyetHeDieuHanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int pause = 0;
        public int stop = 0;
        public int flag = 0;
        public int count = 0;
        public double sum = 0;
        public int checklock = 0;
        public int[] check = new int[100];
        public int[] check2 = new int[100];
        public int[] checkend = new int[100];
        public int[] checkend2 = new int[100];
        public double[] MB = new double[100];
        public double[] MB2 = new double[100];
        public string[] NameBox = new string[100];
        public string[] NameBox2 = new string[100];
        public TextBox[] picbox = new TextBox[100];
        public TextBox[] picbox2 = new TextBox[100];
        public int[] order = new int[100];
        public int[] order2 = new int[100];
        public int countorder = 1;
        public int countend = 1000;
        public int countreset = 0;
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                if (checklock == 0)
                {
                    MessageBox.Show("Nhap kich thuoc bo nho");
                    ActiveControl = textBox2;
                    return;
                }
            }
            if (checklock == 0)
            {
                for(int i=0;i<100;i++)
                    if (NameBox[i] == textBox1.Text.Trim())
                    {
                        MessageBox.Show("Process vừa nhập đã có tên trùng với process trong danh sách, xin nhập tên khác");
                        return;
                    }
            }
            if (radHole.Checked == true && check[count] == -1)
            {
                textBox2.Text = "";
                MessageBox.Show("Không thể có 2 hole liên tiếp, xin nhập lại");
                return;
            }
            if (checklock == 1 && radEnd.Checked == false)
            {
                for (int i = 0; i < pause; i++)
                    if (NameBox[i] == textBox1.Text.Trim())
                    {
                        MessageBox.Show("Process vừa nhập đã có tên trùng với process trong danh sách, xin nhập tên khác");
                        return;
                    }
            }
            if (radEnd.Checked == true)
            {
                int flagend = 0;
                for (int i = 0; i <= count; i++)
                    if (NameBox[i] == textBox1.Text.Trim())
                    {
                        flagend++;
                    }
                if (flagend == 0)
                {
                    MessageBox.Show("Process này không tồn tại, xin mời nhập lại");
                    return;
                }
                if (flagend > 1)
                {
                    MessageBox.Show("Process này đã được xác định là kết thúc trong hàng đợi trước đó, xin mời nhập lại");
                    return;
                }
            }
            count++;
            string[] s = new string[3];
            s[0] = "" + count;
            s[1] = textBox1.Text.Trim();
            s[2] = textBox2.Text.Trim();
            if(checklock==0)
                sum = sum + Convert.ToDouble(s[2]);
            if (radProcess.Checked == true)
            {
                flag++;
                check[count] = flag;
                check2[count] = flag;
                MB[count] = Convert.ToDouble(s[2]);
                MB2[count] = Convert.ToDouble(s[2]);
                NameBox[count] = s[1];
                NameBox2[count] = s[1];
                textBox1.Text = "P";
            }
            else if (radHole.Checked == true)
            {
                check[count] = -1;
                check2[count] = -1;
                radProcess.Checked = true;
                MB[count] = Convert.ToDouble(s[2]);
                MB2[count] = Convert.ToDouble(s[2]);
            }
            else if (radEnd.Checked == true)
            {
                checkend[count] = 1;
                NameBox[count] = s[1];
                checkend2[count] = 1;
                NameBox2[count] = s[1];
                for (int i = 1; i < count; i++)
                {
                    if (NameBox[i] == NameBox[count])
                    {
                        MB[count] = MB[i];
                        MB2[count] = MB[i];
                        break;
                    }
                }
                s[2] = "" + MB[count];
                textBox1.Text = "P";
            }
            ListViewItem item = new ListViewItem(s);
            textBox2.Text = "";
            if (lab2.Text == "Inputting") listView1.Items.Add(item);
            else
            {
                if (radEnd.Checked == true)
                    item.BackColor = Color.LightSeaGreen;
                listView2.Items.Add(item);
            }
        }

        private void radHole_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radProcess_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = "P";
            textBox2.Text = "";
        }

        private void radEnd_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox1.Text = "P";
            textBox2.Text = "";
        }

        private void butLock_Click(object sender, EventArgs e)
        {
            if (checklock == 0)
            {
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("Chưa có trạng thái ban đầu, xin nhập trạng thái ban đầu");
                    return;
                }
                checklock++;
                lab2.Text = "Confirmed";
                lab2.ForeColor = Color.Green;
                radHole.Enabled = false;
                radEnd.Enabled = true;
                radProcess.Checked = true;
                MessageBox.Show("Đã khóa trạng thái ban đầu, sẵn sàng nhập hàng đợi đầu vào");
                pause = count + 1;
            }
            else if (checklock == 1)
            {
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("Hàng đợi đầu vào rỗng, xin nhập hàng đợi đầu vào");
                    return;
                }
                checklock++;
                lab3.Text = "Confirmed";
                lab3.ForeColor = Color.Green;
                MessageBox.Show("Đã khóa hàng đợi đầu vào, sẳn sàng chạy");
                stop = count + 1;
                butPause.Enabled = true;
                butRun.Enabled = true;
                panel3.BackColor = Color.LightGreen;
                butAdd.Enabled = false;
                butLock.Enabled = false;
                int m = 10;
                for (int i = 1; i < stop; i++)
                {
                    MB[i] = MB[i] / sum * 500;
                    MB2[i] = MB2[i] / sum * 500;
                }
                for (int i = 1; i < pause; i++)
                {
                    int k = (int)(MB[i]);
                    picbox[i] = new TextBox();
                    picbox[i].Multiline = true;
                    picbox[i].Location = new Point(m, 10);
                    picbox[i].Size = new Size(k, 50);
                    picbox[i].BackColor = Color.LightPink;
                    picbox[i].BorderStyle = BorderStyle.FixedSingle;
                    picbox[i].ReadOnly = true;
                    picbox[i].Text = NameBox[i] + "\r\n\r\n" + (MB[i] / 500 * sum);

                    picbox2[i] = new TextBox();
                    picbox2[i].Multiline = true;
                    picbox2[i].Location = new Point(m, 10);
                    picbox2[i].Size = new Size(k, 50);
                    picbox2[i].BackColor = Color.LightPink;
                    picbox2[i].BorderStyle = BorderStyle.FixedSingle;
                    picbox2[i].ReadOnly = true;
                    picbox2[i].Text = NameBox[i] + "\r\n\r\n" + (MB[i] / 500 * sum);
                    if (check[i] != -1)
                    {
                        picbox[i].BackColor = Color.LightPink;
                        picbox2[i].BackColor = Color.LightPink;
                    }
                    else
                    {
                        picbox[i].BackColor = Color.LightBlue;
                        picbox2[i].BackColor = Color.LightBlue;
                    }
                    m = m + k;
                    order[countorder] = i;
                    order2[countorder] = i;
                    countorder++;
                }
                m = 10;
                for (int i = pause; i < stop; i++)
                {
                    int k = (int)(MB[i]);
                    if (checkend[i] != 1)
                    {
                        picbox[i] = new TextBox();
                        picbox[i].Multiline = true;
                        picbox[i].Location = new Point(m, 240);
                        picbox[i].Size = new Size(k, 50);
                        picbox[i].BorderStyle = BorderStyle.FixedSingle;
                        picbox[i].Text = NameBox[i] + "\r\n\r\n" + (MB[i] / 500 * sum);
                        picbox[i].ReadOnly = true;
                        picbox[i].BackColor = Color.LightPink;

                        picbox2[i] = new TextBox();
                        picbox2[i].Multiline = true;
                        picbox2[i].Location = new Point(m, 240);
                        picbox2[i].Size = new Size(k, 50);
                        picbox2[i].BorderStyle = BorderStyle.FixedSingle;
                        picbox2[i].Text = NameBox[i] + "\r\n\r\n" + (MB[i] / 500 * sum);
                        picbox2[i].ReadOnly = true;
                        picbox2[i].BackColor = Color.LightPink;
                        m = m + k;
                    }
                    else
                    {
                        picbox[i] = new TextBox();
                        picbox[i].Multiline = true;
                        picbox[i].Location = new Point(m, 240);
                        picbox[i].Size = new Size(50, 50);
                        picbox[i].BorderStyle = BorderStyle.FixedSingle;
                        picbox[i].Text = NameBox[i] + "\r\n\r\n" + (MB[i] / 500 * sum);
                        picbox[i].BackColor = Color.LightGreen;
                        picbox[i].ReadOnly = true;

                        picbox2[i] = new TextBox();
                        picbox2[i].Multiline = true;
                        picbox2[i].Location = new Point(m, 240);
                        picbox2[i].Size = new Size(50, 50);
                        picbox2[i].BorderStyle = BorderStyle.FixedSingle;
                        picbox2[i].Text = NameBox[i] + "\r\n\r\n" + (MB[i] / 500 * sum);
                        picbox2[i].BackColor = Color.LightGreen;
                        picbox2[i].ReadOnly = true;
                        m = m + 50;
                    }
                }
                picbox[stop] = new TextBox();
                picbox[stop].Multiline = true;
                picbox[stop].Location = new Point(10, 10);
                picbox[stop].Size = new Size(500, 50);
                picbox[stop].BackColor = Color.LightBlue;
                picbox[stop].BorderStyle = BorderStyle.FixedSingle;
                picbox[stop].ReadOnly = true;

                picbox2[stop] = new TextBox();
                picbox2[stop].Multiline = true;
                picbox2[stop].Location = new Point(10, 10);
                picbox2[stop].Size = new Size(500, 50);
                picbox2[stop].BackColor = Color.LightBlue;
                picbox2[stop].BorderStyle = BorderStyle.FixedSingle;
                picbox2[stop].ReadOnly = true;

                for (int i = 0; i < 100; i++)
                {
                    panel1.Controls.Add(picbox[i]);
                }
            }
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void butPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            butSlow.Enabled = true;
            butFast.Enabled = true;
        }

        private void radFF_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightBlue;
        }

        private void radBF_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightPink;
        }

        private void radWF_CheckedChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightSalmon;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tự mò đi chứ Help help cái giề (=...=)!Cho nơ-ron não hoạt động đi o(>___<)o","Hướng dẫn",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            MessageBox.Show("Haiz, chưa mò được à ?\r\nĐầu tiên chọn thuật toán ở phần Algorithms\r\nSau đó nhập trạng thái đầu tiên, kết thúc bằng cách click vào nút Confirm\r\nKế tiếp nhập hàng đợi input, kết thúc bằng cách click vào nút Confirm\r\nTùy chọn tốc độ bằng các nút Faster/Slower\r\nSau đó nhấn nút Run để chạy, Pause để tạm ngưng chương trình, khi chương trình chạy xong thì có thể nhất nút Reset để trả về trạng thái ban đầu hoặc Restart để khởi động lại toàn bộ quá trình\r\n\r\nThế thôi cũng mò không ra ah ???O___O ","Có thế cũng không biết O...o",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void butRun_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            butFast.Enabled = false;
            butSlow.Enabled = false;
            radBF.Enabled = false;
            radFF.Enabled = false;
            radWF.Enabled = false;
            radProcess.Enabled = false;
            radHole.Enabled = false;
            radEnd.Enabled = false;
            if (radFF.Checked == true) timer1.Enabled = true;
            else if (radBF.Checked == true) timer2.Enabled = true;
            else if (radWF.Checked == true) timer3.Enabled = true;
        }

        public bool delette(int i)
        {
            if (i == 1)
            {
                if (picbox[order[i + 1]].BackColor == Color.LightPink)
                {
                    picbox[order[i]].BackColor = Color.LightBlue;
                    NameBox[order[i]] = "";
                    picbox[order[i]].Text = NameBox[order[i]] + "\r\n\r\n" + (MB[order[i]] / 500 * sum);
                }
                else if (picbox[order[i + 1]].BackColor == Color.LightBlue)
                {
                    MB[order[i + 1]] = MB[order[i + 1]] + MB[order[i]];
                    picbox[order[i + 1]].Width = (int)MB[order[i + 1]];
                    picbox[order[i + 1]].Left = picbox[order[i]].Left;
                    picbox[order[i + 1]].BackColor = Color.LightBlue;
                    picbox[order[i + 1]].Text = NameBox[order[i + 1]] + "\r\n\r\n" + (MB[order[i + 1]] / 500 * sum);
                    panel1.Controls.Remove(picbox[order[i]]);
                    for (int j = i; j < 99; j++)
                    {
                        order[j] = order[j + 1];
                    }
                }
                return true;
            }
            else
            {
                if (order[i + 1] == 0)
                {
                    if (picbox[order[i - 1]].BackColor == Color.LightPink)
                    {
                        picbox[order[i]].BackColor = Color.LightBlue;
                        NameBox[order[i]] = "";
                        picbox[order[i]].Text = NameBox[order[i]] + "\r\n\r\n" + (MB[order[i]] / 500 * sum);
                    }
                    else if (picbox[order[i - 1]].BackColor == Color.LightBlue)
                    {
                        MB[order[i]] = MB[order[i]] + MB[order[i - 1]];
                        picbox[order[i]].BackColor = Color.LightBlue;
                        NameBox[order[i]] = "";
                        picbox[order[i]].Text = NameBox[order[i]] + "\r\n\r\n" + (MB[order[i]] / 500 * sum);
                        picbox[order[i]].Width = (int)(MB[order[i]]);
                        picbox[order[i]].Left = picbox[order[i]].Left - picbox[order[i - 1]].Width;
                        panel1.Controls.Remove(picbox[order[i - 1]]);
                        order[i - 1] = order[i];
                        order[i] = 0;
                    }
                    return true;
                }
                else
                {
                    if (picbox[order[i - 1]].BackColor == Color.LightPink && picbox[order[i + 1]].BackColor == Color.LightPink)
                    {
                        picbox[order[i]].BackColor = Color.LightBlue;
                        NameBox[order[i]] = "";
                        picbox[order[i]].Text = NameBox[order[i]] + "\r\n\r\n" + (MB[order[i]] / 500 * sum);
                    }
                    else
                    {
                        if (picbox[order[i + 1]].BackColor == Color.LightBlue)
                        {
                            MB[order[i + 1]] = MB[order[i + 1]] + MB[order[i]];
                            picbox[order[i + 1]].Width = (int)MB[order[i + 1]];
                            picbox[order[i + 1]].Left = picbox[order[i]].Left;
                            picbox[order[i + 1]].BackColor = Color.LightBlue;
                            picbox[order[i + 1]].Text = NameBox[order[i + 1]] + "\r\n\r\n" + (MB[order[i + 1]] / 500 * sum);
                            panel1.Controls.Remove(picbox[order[i]]);
                            for (int j = i; j < 99; j++)
                            {
                                order[j] = order[j + 1];
                            }
                        }
                        if (picbox[order[i - 1]].BackColor == Color.LightBlue)
                        {
                            MB[order[i]] = MB[order[i]] + MB[order[i - 1]];
                            picbox[order[i]].BackColor = Color.LightBlue;
                            NameBox[order[i]] = "";
                            picbox[order[i]].Text = NameBox[order[i]] + "\r\n\r\n" + (MB[order[i]] / 500 * sum);
                            picbox[order[i]].Width = (int)(MB[order[i]]);
                            picbox[order[i]].Left = picbox[order[i]].Left - picbox[order[i - 1]].Width;
                            panel1.Controls.Remove(picbox[order[i - 1]]);
                            for (int j = i - 1; j < 99; j++)
                            {
                                order[j] = order[j + 1];
                            }
                        }
                        
                    }
                    return true;
                }
            }
        }

        public void relocation(int local,int relocal)
        {
            picbox[order[local]].Width = picbox[order[local]].Width - picbox[relocal].Width;
            picbox[order[local]].Left = picbox[order[local]].Left + picbox[relocal].Width;
            MB[order[local]] = MB[order[local]] - MB[relocal];
            NameBox[order[local]] = "";
            picbox[order[local]].Text = NameBox[order[local]] + "\r\n\r\n" + (MB[order[local]] / 500 * sum);
            for (int i = 99; i > local; i--)
            {
                order[i] = order[i - 1];
            }
            order[local] = relocal;
        }

        public bool move1(int i, int left, int top)
        {
            if (picbox[i].Top == top && picbox[i].Left == left)
                return true;
            else if (picbox[i].Top > top)
            {
                picbox[i].Top = picbox[i].Top - 1;
                return false;
            }
            else if (picbox[i].Left > left)
            {
                picbox[i].Left = picbox[i].Left - 1;
                return false;
            }
            else if (picbox[i].Left < left)
            {
                picbox[i].Left = picbox[i].Left + 1;
                return false;
            }
            return true;
        }

        public bool move2(int i, int left, int top)
        {
            if (picbox[i].Top == top && picbox[i].Left == left)
                return true;
            else if (picbox[i].Left > left)
            {
                picbox[i].Left = picbox[i].Left - 1;
                return false;
            }
            else if (picbox[i].Left < left)
            {
                picbox[i].Left = picbox[i].Left + 1;
                return false;
            }
            else if (picbox[i].Top > top)
            {
                picbox[i].Top = picbox[i].Top - 1;
                return false;
            }
            return true;
        }
        
        private void butFast_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "99")
            {
                timer1.Interval = timer1.Interval - 1;
                timer2.Interval = timer2.Interval - 1;
                timer3.Interval = timer3.Interval - 1;
                countend = countend - 100;
            }
            textBox3.Text = "" + (100 - timer1.Interval);
        }

        private void butSlow_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "0")
            {
                timer1.Interval = timer1.Interval + 1;
                timer2.Interval = timer2.Interval + 1;
                timer3.Interval = timer3.Interval + 1;
                countend = countend + 100;
            }
            textBox3.Text = "" + (100 - timer1.Interval);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int flagtime = 0;
            for (int i = pause; i < stop; i++)
            {
                if (picbox[i].BackColor == Color.LightGreen)
                {
                    for (int j = 1; j < 99; j++)
                    {
                        if (NameBox[order[j]] == NameBox[i] && picbox[i].BackColor != Color.Black)
                        {
                            Thread.Sleep(countend);
                            picbox[order[j]].Top = 20;
                            picbox[i].Top = 220;
                            Thread.Sleep(countend);
                            picbox[order[j]].Top = 10;
                            delette(j);
                            for (int k = i + 1; k < stop; k++)
                            {
                                picbox[k].Left = picbox[k].Left - picbox[i].Width;
                            }
                            picbox[i].BackColor = Color.Black;
                            panel1.Controls.Remove(picbox[i]);
                            break;
                        }
                    }
                    break;
                }
                else if (picbox[i].BackColor == Color.LightPink && checkend[i] == 0)
                {
                    int flagrun = 0;
                    for (int j = 1; j < 99; j++)
                    {
                        if (order[j] != 0)
                            if (picbox[order[j]].BackColor == Color.LightBlue && MB[order[j]] >= MB[i])
                            {
                                if (move1(i, picbox[i].Left, 70) == false)
                                {
                                    break;
                                }
                                if (move2(i, picbox[order[j]].Left, 70) == false)
                                {
                                    break;
                                }
                                Thread.Sleep(countend);
                                checkend[i] = 1;
                                picbox[i].Top = picbox[order[j]].Top;
                                for (int k = i + 1; k < stop; k++)
                                {
                                    picbox[k].Left = picbox[k].Left - picbox[i].Width;
                                }
                                relocation(j, i);
                                break;
                            }
                        flagrun = j;
                    }
                    if (flagrun == 98)
                    {
                        timer1.Stop();
                        MessageBox.Show("Không tìm thấy Hole đủ rộng cho process này\r\nChương trình ngưng hoạt động\r\nChọn nút Reset để làm lại");
                    }
                    break;
                }
                flagtime = i;
            }
            if (flagtime == stop - 1)
            {
                timer1.Stop();
                MessageBox.Show("Thuật toán First Fit đã thực hiện xong\r\nCảm ơn bạn đã chịu khó test chương trình của tụi tui o(^___^)o");
            }
        }

        public int findmin(int location)
        {
            int min = 0;
            for (int i = 1; i < 99; i++)
            {
                if(order[i]!=0)
                    if(picbox[order[i]].BackColor==Color.LightBlue)
                        if (MB[order[i]] >= MB[location])
                        {
                            min = i;
                            break;
                        }
            }
            if (min == 0) return 0;
            else
            {
                for (int i = 1; i < 99; i++)
                {
                    if (order[i] != 0)
                        if (picbox[order[i]].BackColor == Color.LightBlue)
                            if (MB[order[i]] >= MB[location])
                                if (MB[order[min]] > MB[order[i]])
                                    min = i;
                }
            }
            return min;
        }

        public int findmax(int location)
        {
            int max = 0;
            for (int i = 1; i < 99; i++)
            {
                if (order[i] != 0)
                    if (picbox[order[i]].BackColor == Color.LightBlue)
                        if (MB[order[i]] >= MB[location])
                        {
                            max = i;
                            break;
                        }
            }
            if (max == 0) return 0;
            else
            {
                for (int i = 1; i < 99; i++)
                {
                    if (order[i] != 0)
                        if (picbox[order[i]].BackColor == Color.LightBlue)
                            if (MB[order[i]] >= MB[location])
                                if (MB[order[max]] < MB[order[i]])
                                    max = i;
                }
            }
            return max;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int flagtime = 0;
            for (int i = pause; i < stop; i++)
            {
                if (picbox[i].BackColor == Color.LightGreen)
                {
                    for (int j = 1; j < 99; j++)
                    {
                        if (NameBox[order[j]] == NameBox[i] && picbox[i].BackColor != Color.Black)
                        {
                            Thread.Sleep(countend);
                            picbox[order[j]].Top = 20;
                            picbox[i].Top = 220;
                            Thread.Sleep(countend);
                            picbox[order[j]].Top = 10;
                            delette(j);
                            for (int k = i + 1; k < stop; k++)
                            {
                                picbox[k].Left = picbox[k].Left - picbox[i].Width;
                            }
                            picbox[i].BackColor = Color.Black;
                            panel1.Controls.Remove(picbox[i]);
                            break;
                        }
                    }
                    break;
                }
                else if (picbox[i].BackColor == Color.LightPink && checkend[i] == 0)
                {
                    int min = findmin(i);
                    if (min == 0)
                    {
                        timer2.Stop();
                        MessageBox.Show("Không tìm thấy Hole đủ rộng cho process này\r\nChương trình ngưng hoạt động\r\nChọn nút Reset để làm lại");
                    }
                    else if (min != 0)
                    {
                        if (move1(i, picbox[i].Left, 70) == false)
                        {
                            break;
                        }
                        if (move2(i, picbox[order[min]].Left, 70) == false)
                        {
                            break;
                        }
                        Thread.Sleep(countend);
                        checkend[i] = 1;
                        picbox[i].Top = picbox[order[min]].Top;
                        for (int k = i + 1; k < stop; k++)
                        {
                            picbox[k].Left = picbox[k].Left - picbox[i].Width;
                        }
                        relocation(min, i);
                        break;
                    }
                }
                flagtime = i;
            }
            if (flagtime == stop - 1)
            {
                timer2.Stop();
                MessageBox.Show("Thuật toán Best Fit đã thực hiện xong\r\nCảm ơn bạn đã chịu khó test chương trình của tụi tui o(^___^)o");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int flagtime = 0;
            for (int i = pause; i < stop; i++)
            {
                if (picbox[i].BackColor == Color.LightGreen)
                {
                    for (int j = 1; j < 99; j++)
                    {
                        if (NameBox[order[j]] == NameBox[i] && picbox[i].BackColor != Color.Black)
                        {
                            Thread.Sleep(countend);
                            picbox[order[j]].Top = 20;
                            picbox[i].Top = 220;
                            Thread.Sleep(countend);
                            picbox[order[j]].Top = 10;
                            delette(j);
                            for (int k = i + 1; k < stop; k++)
                            {
                                picbox[k].Left = picbox[k].Left - picbox[i].Width;
                            }
                            picbox[i].BackColor = Color.Black;
                            panel1.Controls.Remove(picbox[i]);
                            break;
                        }
                    }
                    break;
                }
                else if (picbox[i].BackColor == Color.LightPink && checkend[i] == 0)
                {
                    int max = findmax(i);
                    if (max == 0)
                    {
                        timer3.Stop();
                        MessageBox.Show("Không tìm thấy Hole đủ rộng cho process này\r\nChương trình ngưng hoạt động\r\nChọn nút Reset để làm lại");
                    }
                    else if (max != 0)
                    {
                        if (move1(i, picbox[i].Left, 70) == false)
                        {
                            break;
                        }
                        if (move2(i, picbox[order[max]].Left, 70) == false)
                        {
                            break;
                        }
                        Thread.Sleep(countend);
                        checkend[i] = 1;
                        picbox[i].Top = picbox[order[max]].Top;
                        for (int k = i + 1; k < stop; k++)
                        {
                            picbox[k].Left = picbox[k].Left - picbox[i].Width;
                        }
                        relocation(max, i);
                        break;
                    }
                }
                flagtime = i;
            }
            if (flagtime == stop - 1)
            {
                timer3.Stop();
                MessageBox.Show("Thuật toán Worst Fit đã thực hiện xong\r\nCảm ơn bạn đã chịu khó test chương trình của tụi tui o(^___^)o");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designer:V.K.L & N.C.C\r\nClass:IT2\r\nCompany:348\r\n\r\nNote:\r\nVKL and NCC are the most handsome and talent students in this class","Ghi chú",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            int handsome = 0;
            do
            {
                if (MessageBox.Show("Bạn có công nhận rằng VKL và NCC là 2 học viên đẹp trai nhất lớp tin học 2 ?", "Trả lời thật lòng nhé!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    handsome = 1;
                else MessageBox.Show("Đừng dối lòng nữa , trả lời thật đi hihi");
            } while (handsome == 0);
            if (handsome == 1)
                do
                {
                    if (MessageBox.Show("Bạn chắc chắn chứ ???", "Trả lời thật lòng nhé!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        handsome = 2;
                    else MessageBox.Show("Phải sống thật với bản thân mình chứ, đừng níu kéo làm giề\r\nClick OK để vote cho VKL & NCC đẹp trai nhất lớp");
                } while (handsome == 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radBF.Enabled = true;
            radFF.Enabled = true;
            radWF.Enabled = true;
            panel1.Controls.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (picbox2[i] != null)
                {
                    picbox[i] = null;
                    check[i] = check2[i];
                    checkend[i] = checkend2[i];
                    order[i] = order2[i];
                    NameBox[i] = NameBox2[i];
                    MB[i] = MB2[i];
                    picbox[i] = new TextBox();
                    picbox[i].Multiline = true;
                    picbox[i].Location = picbox2[i].Location;
                    picbox[i].Size = picbox2[i].Size;
                    picbox[i].BackColor = picbox2[i].BackColor;
                    picbox[i].BorderStyle = BorderStyle.FixedSingle;
                    picbox[i].ReadOnly = true;
                    picbox[i].Text = picbox2[i].Text;
                }
            }
            for (int i = 0; i < 100; i++)
            {
                panel1.Controls.Add(picbox[i]);
            }
        }

    }
}
