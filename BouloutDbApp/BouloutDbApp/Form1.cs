namespace BouloutDbApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void formClosed(object? sender, FormClosedEventArgs e)
        { //T O  O P E N  M A I N  F O R M  A G A I N
            this.Show();
        }

        // b t n A d d C l i e n t
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //Open the Add Client form
            Form2 frmClient= new Form2 ();
            //show main form when child form is closed
            frmClient.FormClosed += formClosed;
            frmClient.Show();
            this.Hide();//hide main form

            // Non-modal pattern (put inside btnAddClient_Click)
            /*var frmClient = new Form2();
            frmClient.Owner = this;                  // set owner so ui focus/activation is correct
            frmClient.FormClosed += (s, ea) => this.Show();
            this.Hide();
            frmClient.Show();*/


        }

        private void btnAddClient_MouseEnter(object sender, EventArgs e)
        {
            // Mouse enter, font becomes a hyperlink look
            btnAddClient.ForeColor = Color.Blue;
            btnAddClient.Font = new Font(btnAddClient.Font, FontStyle.Italic | FontStyle.Bold);
            btnAddClient.Cursor = Cursors.Hand;
        }

        private void btnAddClient_MouseLeave(object sender, EventArgs e)
        {
            // Mouse leaves, font becomes regualr
            btnAddClient.ForeColor = Color.Black;
            btnAddClient.Font = new Font(btnAddClient.Font, FontStyle.Regular);
            btnAddClient.Cursor = Cursors.Default;
        }

        // b t n A d d T i c k e t

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            // Open the Add Ticket form
            Form4 frmTicket =new Form4();
            //when child form is closed, show main form
            frmTicket.FormClosed += formClosed;
            frmTicket.Show();
            this.Hide();//hide main form
            

        }

        private void btnAddTicket_MouseEnter(object sender, EventArgs e)
        {
            // Mouse enter, font becomes a hyperlink look
            btnAddTicket.ForeColor = Color.Blue;
            btnAddTicket.Font = new Font(btnAddTicket.Font, FontStyle.Italic | FontStyle.Bold);
            btnAddTicket.Cursor = Cursors.Hand;
        }
        private void btnAddTicket_MouseLeave(object sender, EventArgs e)
        {
            // Mouse leaves, font becomes regualr
            btnAddTicket.ForeColor = Color.Black;
            btnAddTicket.Font = new Font(btnAddTicket.Font, FontStyle.Regular);
            btnAddTicket.Cursor = Cursors.Default;
        }
        // b t n A d d R e p P r o f i l e

        private void btnAddRepProfile_Click(object sender, EventArgs e)
        {
            // Open the Add Rep Profile form
            Form3 frmRepProfile= new Form3();
            //when child form is closed, show main form
            frmRepProfile.FormClosed += formClosed;
            frmRepProfile.Show();
            this.Hide();//hide main form
        }
        private void btnAddRepProfile_MouseEnter(object sender, EventArgs e)
        {
            // Mouse enter, font becomes a hyperlink look
            btnAddRepProfile.ForeColor = Color.Blue;
            btnAddRepProfile.Font = new Font(btnAddRepProfile.Font, FontStyle.Italic | FontStyle.Bold);
            btnAddRepProfile.Cursor = Cursors.Hand;
        }
        private void btnAddRepProfile_MouseLeave(object sender, EventArgs e)
        {
            // Mouse leaves, font becomes regualr
            btnAddRepProfile.ForeColor = Color.Black;
            btnAddRepProfile.Font = new Font(btnAddRepProfile.Font, FontStyle.Regular);
            btnAddRepProfile.Cursor = Cursors.Default;
        }

        // b t n A d d R e p o r t
        private void btnAddReport_Click(object sender, EventArgs e)
        {
            // Open the Add Report form
            Form5 frmReport = new Form5();//new frm
            frmReport.FormClosed += formClosed;
            frmReport.Show();
            this.Hide();//hide main form
        }

        private void btnAddReport_MouseLeave(object sender, EventArgs e)
        {
            // Mouse leaves, font becomes regualr
            btnAddReport.ForeColor = Color.Black;
            btnAddReport.Font = new Font(btnAddReport.Font, FontStyle.Regular);
            btnAddReport.Cursor = Cursors.Default;
        }
        private void btnAddReport_MouseEnter(object sender, EventArgs e)
        {
            // Mouse enter, font becomes a hyperlink look
            btnAddReport.ForeColor = Color.Blue;
            btnAddReport.Font = new Font(btnAddReport.Font, FontStyle.Italic | FontStyle.Bold);
            btnAddReport.Cursor = Cursors.Hand;
        }


        // b t n A d d E m p l o y e e
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Open the Add Employee form
            Form6 frmEmployee = new Form6();
            frmEmployee.FormClosed += formClosed;
            frmEmployee.Show();
            this.Hide();//hide main form
        }
        private void btnAddEmployee_MouseEnter(object sender, EventArgs e)
        {
            // Mouse enter, font becomes a hyperlink look
            btnAddEmployee.ForeColor = Color.Blue;
            btnAddEmployee.Font = new Font(btnAddEmployee.Font, FontStyle.Italic | FontStyle.Bold);
            btnAddEmployee.Cursor = Cursors.Hand;
        }
        private void btnAddEmployee_MouseLeave(object sender, EventArgs e)
        {
            // Mouse leaves, font becomes regualr
            btnAddEmployee.ForeColor = Color.Black;
            btnAddEmployee.Font = new Font(btnAddEmployee.Font, FontStyle.Regular);
            btnAddEmployee.Cursor = Cursors.Default;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
