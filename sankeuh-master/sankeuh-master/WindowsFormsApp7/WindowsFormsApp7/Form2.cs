using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        int i = 1;
        int initlblY = 71;
        int inittxtY = 99;
        int initpnlY = 12;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtnbr.Hide();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {

            btn_val.Hide();
            txtnbr.Hide();
            int nbr = int.Parse(txtnbr.Text);

            if (rbo.Checked && nbr < 4)
            {
                label3.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                txt_first.Hide();
                txt_last.Hide();
                dtp_wife.Hide();
                rbn.Hide();
                rbo.Hide();
                panel1.Hide();
                panel5.Hide();
                for (int j = 0; j < nbr; j++)
                {
                    Button btn_valid = new Button();
                    Panel pnl = new Panel();
                    Label lblfn = new Label();
                    Label lbldn = new Label();
                    Label lblns = new Label();
                    Label lblnum = new Label();
                    TextBox txt = new TextBox();
                    DateTimePicker dtp = new DateTimePicker();

                    ComboBox cmb_Sexe = new ComboBox();
                    cmb_Sexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin",
            });

                    pnl.Top = initpnlY;
                    pnl.Left = 33;
                    pnl.BackColor = Color.Gold;
                    pnl.Size = new Size(280, 164);


                    btn_val.Hide();
                    lblfn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbldn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblfn.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    lblns.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    lbldn.ForeColor = System.Drawing.SystemColors.ButtonFace;


                    btn_valid.Top = 521;
                    btn_valid.Left = 274;
                    btn_valid.BackColor = Color.Gold;
                    btn_valid.Text = "Valider";
                    txt.Top = 19;
                    txt.Left = 113;
                    txt.Width = 124;
                    txt.BackColor = Color.MediumTurquoise;
                    dtp.Top = 52;
                    dtp.Left = 113;
                    dtp.Width = 165;

                    cmb_Sexe.Top = 89;
                    cmb_Sexe.Left = 146;
                    cmb_Sexe.Width = 121;



                    lblfn.Left = 2;
                    lbldn.Left = 2;
                    lblns.Left = 2;



                    lblfn.Top = 17;
                    lbldn.Top = 51;
                    lblns.Top = 89;
                    lblfn.Width = 99;
                    lbldn.Width = 121;
                    lblns.Width = 144;

                    lblfn.Text = "First Name";
                    lbldn.Text = "Date Of Birth";
                    lblns.Text = "Sexe";



                    this.Controls.Add(pnl);
                    this.Controls.Add(btn_valid);
                    pnl.Controls.Add(txt);
                    pnl.Controls.Add(dtp);
                    pnl.Controls.Add(cmb_Sexe);
                    pnl.Controls.Add(lblfn);
                    pnl.Controls.Add(lbldn);
                    pnl.Controls.Add(lblns);
                    i++;
                    inittxtY += 72;
                    initlblY += 72;
                    initpnlY += 170;





                }



            }
            else
            {
                int initpY = 12;
                int initlY = 71;
                int inittY = 99;
                this.Size = new System.Drawing.Size(800, 620);
                label3.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                txt_first.Hide();
                txt_last.Hide();
                dtp_wife.Hide();
                rbn.Hide();
                rbo.Hide();
                panel1.Hide();
                panel5.Hide();
                btn_val.Hide();
                for (int j = 0; j < 3; j++)
                {
                    Button btn_valid = new Button();
                    Panel pnl = new Panel();
                    Label lblfn = new Label();
                    Label lbldn = new Label();
                    Label lblns = new Label();
                    Label lblnum = new Label();
                    TextBox txt = new TextBox();
                    DateTimePicker dtp = new DateTimePicker();
                    ComboBox cmb_Sexe = new ComboBox();
                    cmb_Sexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin",
            });

                    pnl.Top = initpY;
                    pnl.Left = 33;
                    pnl.BackColor = Color.Gold;
                    pnl.Size = new Size(280, 164);


                    btn_val.Hide();
                    lblfn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbldn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblfn.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    lblns.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    lbldn.ForeColor = System.Drawing.SystemColors.ButtonFace;



                    btn_valid.Top = 521;
                    btn_valid.Left = 330;
                    btn_valid.BackColor = Color.Gold;
                    btn_valid.Text = "Valider";

                    txt.Top = 19;
                    txt.Left = 113;
                    txt.Width = 124;
                    txt.BackColor = Color.MediumTurquoise;
                    dtp.Top = 52;
                    dtp.Left = 113;
                    dtp.Width = 165;

                    cmb_Sexe.Top = 89;
                    cmb_Sexe.Left = 146;
                    cmb_Sexe.Width = 121;



                    lblfn.Left = 2;
                    lbldn.Left = 2;
                    lblns.Left = 2;



                    lblfn.Top = 17;
                    lbldn.Top = 51;
                    lblns.Top = 89;
                    lblfn.Width = 99;
                    lbldn.Width = 121;
                    lblns.Width = 144;

                    lblfn.Text = "First Name";
                    lbldn.Text = "Date Of Birth";
                    lblns.Text = "Sexe";



                    this.Controls.Add(pnl);
                    this.Controls.Add(btn_valid);
                    pnl.Controls.Add(txt);
                    pnl.Controls.Add(dtp);
                    pnl.Controls.Add(cmb_Sexe);
                    pnl.Controls.Add(lblfn);
                    pnl.Controls.Add(lbldn);
                    pnl.Controls.Add(lblns);
                    i++;
                    inittY += 72;
                    initlY += 72;
                    initpY += 170;



                    //  initpnlY += 250;

                }
                btn_val.Hide();
                int initlblY = 71;
                int inittxtY = 99;
                int initpnlY = 12;
                for (int j = 0; j < nbr - 3; j++)
                {
                    Button btn_valid = new Button();
                    Panel pnl = new Panel();
                    Label lblfn = new Label();
                    Label lbldn = new Label();
                    Label lblns = new Label();
                    Label lblnum = new Label();
                    TextBox txt = new TextBox();
                    DateTimePicker dtp = new DateTimePicker();
                    ComboBox cmb_Sexe = new ComboBox();
                    cmb_Sexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin",
            });


                    pnl.Top = initpnlY;
                    pnl.Left = 417;
                    pnl.BackColor = Color.Gold;
                    pnl.Size = new Size(280, 164);


                    btn_val.Hide();
                    lblfn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbldn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblfn.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    lblns.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    lbldn.ForeColor = System.Drawing.SystemColors.ButtonFace;


                    btn_valid.Top = 521;
                    btn_valid.Left = 330;
                    btn_valid.BackColor = Color.Gold;
                    btn_valid.Text = "Valider";
                    txt.Top = 19;
                    txt.Left = 113;
                    txt.Width = 124;
                    txt.BackColor = Color.MediumTurquoise;
                    dtp.Top = 52;
                    dtp.Left = 113;
                    dtp.Width = 165;

                    cmb_Sexe.Top = 89;
                    cmb_Sexe.Left = 146;
                    cmb_Sexe.Width = 121;



                    lblfn.Left = 2;
                    lbldn.Left = 2;
                    lblns.Left = 2;



                    lblfn.Top = 17;
                    lbldn.Top = 51;
                    lblns.Top = 89;
                    lblfn.Width = 99;
                    lbldn.Width = 121;
                    lblns.Width = 144;

                    lblfn.Text = "First Name";
                    lbldn.Text = "Date Of Birth";
                    lblns.Text = "Sexe";



                    this.Controls.Add(pnl);
                    this.Controls.Add(btn_valid);
                    pnl.Controls.Add(txt);
                    pnl.Controls.Add(dtp);

                    pnl.Controls.Add(cmb_Sexe);
                    pnl.Controls.Add(lblfn);
                    pnl.Controls.Add(lbldn);
                    pnl.Controls.Add(lblns);
                    i++;
                    inittxtY += 72;
                    initlblY += 72;
                    initpnlY += 170;



                    //  initpnlY += 250;

                }

            }











            /*
                    private void button1_Click(object sender, EventArgs e)
                    {
                        Label lbl = new Label();
                        TextBox txt = new TextBox();
                        int initlblY = 228;
                        int inittxtY = 255;
                        //int nbr = int.Parse(txt_enf.Text);


                            lbl.Top = initlblY;
                            lbl.Left = 16;
                            lbl.Text = "Enfant " + this.i.ToString();
                            lbl.Name = "lbl_enf" + this.i.ToString();           
                            inittxtY += 72;
                            initlblY += 72;

                        this.Controls.Add(lbl);
                        i++;
                    }
                    */

        }

        private void rbo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbo.Checked)
            {
                txtnbr.Show();
            }
        }
    }
}
