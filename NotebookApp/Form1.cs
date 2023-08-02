namespace NotebookApp
{
    public partial class Form1 : Form
    {
        private Note selectedNote = null;
        public Form1()
        {
            InitializeComponent();
            Refresh();
        }
        public void Refresh()
        {
            S�zler.DataSource = null;
            S�zler.DataSource = DataStore.Notes;
            S�zler.DisplayMember = "Description";
            S�zler.ValueMember = "Id";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //uygulamay� tamamen kapatmak i�in buray� kulland�k.
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* son kayd� �ekerim son kayd�n idsini al�r�m*/
            if (!string.IsNullOrEmpty(txtNote.Text))
            {


                var addedNote = new Note();
                addedNote.Description = txtNote.Text;

                var lastNote = DataStore.Notes[DataStore.Notes.Count - 1];
                addedNote.Id = lastNote.Id + 1;


                DataStore.Notes.Add(addedNote);

                Refresh();


                txtNote.Text = string.Empty;
            }


            //listBox1.Items.Add(addedNote);

            //listBox1.Items.Add(txtNote.Text);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (S�zler.SelectedItem != null)
            {
                selectedNote = (Note)S�zler.SelectedItem;
                txtNote.Text = selectedNote.Description;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataStore.Notes.Remove(selectedNote);
            selectedNote = null;
            txtNote.Text = string.Empty;
            Refresh();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNote.Text))
            {
                selectedNote.Description = txtNote.Text;

                Refresh();
            }
        }


    }
}