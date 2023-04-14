namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int n,i,op,opa,pit,maz,ex,l1,l2,l3;
        string valor1, valor2;
        char signo;
        int[,] matriz = new int[8, 3];
        bool m;
        bool[] valora1 = new bool[100];
        bool[] valora2 = new bool[100];
        bool[] valora3 = new bool[100];
        bool[] res = new bool[100];
        dynamic[] res1 = new dynamic[100];
        dynamic[] res2 = new dynamic[100];
        dynamic[] res3 = new dynamic[100];
        bool[] a = new bool[100];
        bool[] b = new bool[100];
        bool[] c = new bool[100];
        bool[] d = new bool[100];
        string ab;

        public Form1()
        {
            InitializeComponent();
            for (n = 0; n < 8; n++)
            {
                if (n >= 4)
                {
                    a[n] = true;
                }
                else
                {
                    a[n] = false;
                }
            }

            for (n = 0; n <= 8; n++)
            {
                switch (n)
                {
                    case 0:
                        b[n] = false;
                        break;
                    case 1:
                        b[n] = false;
                        break;
                    case 2:
                        b[n] = true;
                        break;
                    case 3:
                        b[n] = true;
                        break;
                    case 4:
                        b[n] = false;
                        break;
                    case 5:
                        b[n] = false;
                        break;
                    case 6:
                        b[n] = true;
                        break;
                    case 7:
                        b[n] = true;
                        break;
                }
            }

            for (n = 0; n <= 8; n++)
            {
                if ((n % 2) == 0)
                {
                    c[n] = false;
                }
                else
                {
                    c[n] = true;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            A.Items.Clear();
            ab = textBox1.Text;
           
            A.Items.Add("A" + " " + "B" + " " + "C" + "  " + ab);
            for (n = 0;n<8;n++)
            {
                              
                A.Items.Add(Convert.ToInt32(a[n]) + "  " + Convert.ToInt32(b[n]) + "  " + Convert.ToInt32(c[n]) + "   " + Convert.ToInt32(m));
            }
            //for (i = 0; i < 2; i++)
            //{
                DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
                columna1.HeaderText = ab;
                columna1.Width = 50;
                dgv.Columns.Add(columna1);
            //}
            for (n = 0; n < 8; n++)
            {
                switch (ab)
                {
                    case "AB":
                        m = !a[n] & b[n];
                        ab = textBox1.Text;                 
                        dgv.Rows.Add();
                        dgv.Rows[n].Cells[0].Value = Convert.ToInt32(m);
                        break;
                    case "AC":
                        m= a[n] | c[n];
                        ab = textBox1.Text;
                        dgv.Rows.Add();
                        dgv.Rows[n].Cells[1].Value = Convert.ToInt32(m);
                        break;
                }
            }
        }
        private void agregarletra(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            textBox1.Text += boton.Text;           
            if (textBox1.Text == "A")
            {
                l1 = 1;
                for (n = 0; n < 8; n++)
                {
                    valora1[n] = a[n];                    
                    //textBox1.Text = " ";
                }
            } 
            
            if (textBox1.Text == "B")
            {
                l2 = 1;
                for (n = 0; n < 8; n++)
                {
                    valora2[n] = b[n];                    
                    //textBox1.Text = " ";
                }
            }            
            if (textBox1.Text == "C")
            {
                l3= 1;
                for (n = 0; n < 8; n++)
                {
                    valora3[n] = c[n];                    
                }
            }
        }
        private void agregaroperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            textBox1.Text += boton.Text;
            //valor1= textBox1.Text;
            label2.Text += textBox1.Text;
           
            signo = Convert.ToChar(boton.Text);
            textBox1.Text = "";
        }       
        private void button7_Click(object sender, EventArgs e)
        {
            
        }
        private void btnsum_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {          
            op = Convert.ToInt32(txtvariables.Text);
            label2.Text += textBox1.Text;

            if (l1 == 1 && l2 == 0 && l3 == 0)
            {
                pit = pit + 1;
                for (n = 0; n < 8; n++)
                {
                    res[n] = valora1[n];
                    valora1[n] = false;
                    valora2[n] = false;
                    valora3[n] = false;
                }
            }
            if (l1 == 0 && l2 == 1 && l3 == 0)
            {
                pit = pit + 1;
                for (n = 0; n < 8; n++)
                {
                    res[n] = valora2[n];
                    valora1[n] = false;
                    valora2[n] = false;
                    valora3[n] = false;
                }
            }
            if (l1 == 0 && l2 == 0 && l3 == 1)
            {
                pit = pit + 1;
                for (n = 0; n < 8; n++)
                {
                    res[n] = valora3[n];
                    valora1[n] = false;
                    valora2[n] = false;
                    valora3[n] = false;
                }
            }

            if (signo == '+')
            {
               
                if (l1 == 1 && l2 == 1 && l3 == 0)
                {
                    pit = pit + 1;
                    for (n = 0; n < 8; n++)
                    {
                        res[n] = valora1[n] | valora2[n];
                        valora1[n] = false;
                        valora2[n] = false;
                        valora3[n] = false;
                    }
                }
                if (l1 == 1 && l3 == 1 && l2 == 0)
                {
                    pit = pit + 1;
                    for (n = 0; n < 8; n++)
                    {
                        res[n] = valora1[n] | valora3[n];
                        valora1[n] = false;
                        valora2[n] = false;
                        valora3[n] = false;
                    }
                }
                if (l1 == 1 && l2 == 1 && l3 == 1)
                {
                    pit = pit + 1;
                    for (n = 0; n < 8; n++)
                    {
                        res[n] = valora1[n] | valora2[n] | valora3[n];
                        valora1[n] = false;
                        valora2[n] = false;
                        valora3[n] = false;
                    }
                }               
                l1 = 0; l2 = 0; l3 = 0;
            }            
            if (signo == '*')
            {

                pit = pit + 1;                                                         
                if (l1 == 1 && l2 == 1 && l3==0)
                {
                    for (n = 0; n < 8; n++)
                    {
                        res[n] = valora1[n] & valora2[n];
                        valora1[n] = false;
                        valora2[n] = false;
                        valora3[n] = false;
                    }
                }
                if (l1 == 1 && l3 == 1 && l2==0)
                {
                    for (n = 0; n < 8; n++)
                    {
                        res[n] = valora1[n] & valora3[n];
                        valora1[n] = false;
                        valora2[n] = false;
                        valora3[n] = false;
                    }
                }
                if (l1 == 0 && l3 == 1 && l2 == 1)
                {
                    for (n = 0; n < 8; n++)
                    {
                        res[n] = valora2[n] & valora3[n];
                        valora1[n] = false;
                        valora2[n] = false;
                        valora3[n] = false;
                    }
                }
                if (l1== 1 && l2 == 1 && l3==1)
                {
                    for (n = 0; n < 8; n++)
                    {
                        res[n] = valora1[n] & valora2[n] & valora3[n];
                        valora1[n] = false;
                        valora2[n] = false;
                        valora3[n] = false;
                    }                        
                }
                l1 = 0; l2 = 0; l3=0;
            }

            opa = op + pit;
            textBox1.Text = "";

        }
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label1.Text += "Se han realizado "; label1.Text += Convert.ToString(pit); label1.Text+=" operaciones" ;
            ex = (int)Math.Pow(2, op);
            dgv.ColumnCount = opa;
            dgv.RowCount= ex;
           for(i =0;i<opa;i++)
            {
                dgv.Columns[i].HeaderText = Convert.ToString(i + 1);
            }
            for (n = 0; n < ex; n++)
            {
                dgv.Rows[n].HeaderCell.Value = Convert.ToString(n + 1);
            }
            for(n =0; n <ex;n++)
            {
                for(i=0; i<opa; i++)
                {
                    switch (i)
                    {
                        case 0:
                            dgv.Rows[n].Cells[i].Value = Convert.ToInt32(a[n]);
                            dgv.Columns[i].HeaderText = Convert.ToString("A");
                            break;
                        case 1:
                            dgv.Rows[n].Cells[i].Value = Convert.ToInt32(b[n]);
                            dgv.Columns[i].HeaderText = Convert.ToString("B");
                            break;
                            case 2:
                            dgv.Rows[n].Cells[i].Value= Convert.ToInt32(c[n]);
                            dgv.Columns[i].HeaderText = Convert.ToString("C");
                            break;                            
                    }                                       
                }                               
            }
            for(n=0; n<ex;n++)
            {
                for (maz = i-1; maz < opa; maz++)
                {                 
                    dgv.Rows[n].Cells[maz].Value = Convert.ToInt32(res[n]);
                    res1[n] = Convert.ToBoolean((dgv.Rows[n].Cells[maz].Value));
                }
            }
            /*for (n = 0; n < ex; n++)
            {
                for (maz = i - 1; maz < opa; maz++)
                {
                    dgv.Rows[n].Cells[maz].Value = Convert.ToInt32(res[n]);
                    res1[n] = Convert.ToBoolean((dgv.Rows[n].Cells[maz].Value));
                }
            }*/
            /*for (n = 0; n < ex; n++)
            {
                for (maz = i - 1; maz < opa; maz++)
                {
                    res1[n] = Convert.ToBoolean((dgv.Rows[n].Cells[maz].Value));
                }
            }*/

            for (n = 0; n < ex; n++)
            {
                for (i = 3; i < maz-1; i++)
                {
                    res2[n] = Convert.ToBoolean((dgv.Rows[n].Cells[i].Value));
                }
            }

            for (n = 0; n < ex; n++)
            {
                for (i = 0; i < maz; i++)
                {
                    res3[n] = res1[n] | res2[n];
                }
            }
        }       
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 8;           
            for (i = 0; i < 1; i++)
            {
                dataGridView1.Columns[i].HeaderText = Convert.ToString(i + 1);
            }
            for (n = 0; n < 8; n++)
            {
                dataGridView1.Rows[n].HeaderCell.Value = Convert.ToString(n + 1);
            }
            for(i=0;i<1;i++)
            {
                for(n=0; n<8; n++)
                {
                    dataGridView1.Rows[n].Cells[i].Value= Convert.ToInt32( res3[n]);
                }
            }
        }
    }
}