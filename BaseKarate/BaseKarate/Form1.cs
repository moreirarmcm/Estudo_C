using System.Data.SQLite;

namespace BaseKarate
{
    public partial class Form1 : Form
    {
        Administracao administracao = new Administracao();
        SQLiteConnection conexao = null;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                administracao.CriandoBaseDados();
                FormMenu form_menu = new FormMenu();
                this.Hide();
                form_menu.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
