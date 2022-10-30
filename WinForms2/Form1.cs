namespace WinForms2
{
    public partial class Form1 : Form
    {

       private int autoID = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myListView.Columns.Add("ID", 50, HorizontalAlignment.Center);

            myListView.Columns.Add("Name",130,HorizontalAlignment.Center) ;
            myListView.Columns.Add("Street", 130, HorizontalAlignment.Center);
            myListView.Columns.Add("City", 120, HorizontalAlignment.Center);
            myListView.Columns.Add("State", 120, HorizontalAlignment.Center);
            myListView.Columns.Add("ZIP", 120, HorizontalAlignment.Left);


           // addToListView("Vojkan", "Berlinska", "Modrica", "RS", "74480");
           




        }

        private void addToListView(String name, String street, String city, String state,String zip) {

            ListViewItem eachRow = new ListViewItem("" +  autoID);

            ListViewItem.ListViewSubItem rowName = new ListViewItem.ListViewSubItem(eachRow, name);
            ListViewItem.ListViewSubItem rowStreet = new ListViewItem.ListViewSubItem(eachRow, street);
            ListViewItem.ListViewSubItem rowCity = new ListViewItem.ListViewSubItem(eachRow, city);
            ListViewItem.ListViewSubItem rowState = new ListViewItem.ListViewSubItem(eachRow, state);
            ListViewItem.ListViewSubItem rowZip = new ListViewItem.ListViewSubItem(eachRow, zip);

            eachRow.SubItems.Add(rowName);
            eachRow.SubItems.Add(rowStreet);
            eachRow.SubItems.Add(rowCity);
            eachRow.SubItems.Add(rowState);
            eachRow.SubItems.Add(rowZip);

            myListView.Items.Add(eachRow);

            this.autoID++ ;

        }






        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userName = this.txtName.Text.ToString();
            string userStreet = this.txtStreet.Text.ToString();
            string userCity = this.txtCity.Text.ToString() ;
            string userState = this.txtState.Text.ToString() ;
            string userZip = this.txtZip.Text.ToString() ;


            if ((userName.Length > 1) && (userStreet.Length > 1) && (userCity.Length > 1) && (userState.Length > 1) && (userZip.Length > 1))
            {

                addToListView(userName, userStreet, userCity, userState, userZip);


            }
            else

                MessageBox.Show("Please fill out the form ");






        }

        private void button2_Click(object sender, EventArgs e)
        {
           clear();
        }


        void clear() {

            txtName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();

            txtName.Focus();

        }










    }
}