using LabPoke.Pokemon;

namespace LabPoke
{
    public partial class Form1 : Form
    {
        List<Pokemons> pokemons;
        Pokemons selectedPokemon;
        Pokemons monster;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Pokemons>();
            pokemons.Add(new Pidgey());
            pokemons.Add(new Squirtle());
            pokemons.Add(new Seel());
            pokemons.Add(new Poliwag());
            

            this.monster = new Vulpix();
            this.pictureBox2.Image = this.monster.getImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
           /* int HP = int.Parse(textBox2.Text);*/
            this.textBox2.Text = selectedPokemon.getHP().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int damage = this.monster.getDefense()
                - this.selectedPokemon.getAttack();
            this.monster.takeDamage(damage);
            
            //display data
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}