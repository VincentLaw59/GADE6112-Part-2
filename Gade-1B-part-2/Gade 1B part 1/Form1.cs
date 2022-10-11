namespace Gade_1B_part_1
{
    public partial class frmGame : Form
    {
        private static GameEngine gameEngine = new GameEngine();
        
        public static GameEngine GameEngine { get { return gameEngine; } set { gameEngine = value; } } //Error Trying to cast Mage to SwampCreature "(SwampCreature)Mage"

        public frmGame() 
        {
            InitializeComponent();
        }
               
                
        private void btnStart_Click(object sender, EventArgs e)
       {
            //Generate Map
            
            redPlayArea.Text = GameEngine.Map.ToString();
            RedOutput.Text = GameEngine.Map.Player.ToString();
            
            for (int i = 0; i < GameEngine.Map.Enemies.Length ; i++)
            {
                CmbListOfEnemies.Items.Add(GameEngine.Map.Enemies[i].ToString());
            }

            
       }

        private void btnLeft_Click(object sender, EventArgs e)
        {            
            GameEngine.MovePlayer(Character.MovementEnum.Left);
            GameEngine.Map.gameMap[GameEngine.Map.Player.Y, GameEngine.Map.Player.X] = GameEngine.Map.Player;
            redPlayArea.Text = GameEngine.Map.ToString();
            RedOutput.Text = GameEngine.Map.Player.ToString();            
        }

        private void bntUp_Click(object sender, EventArgs e)
        {
            GameEngine.MovePlayer(Character.MovementEnum.Up);
            GameEngine.Map.gameMap[GameEngine.Map.Player.Y, GameEngine.Map.Player.X] = GameEngine.Map.Player;
            redPlayArea.Text = GameEngine.Map.ToString();
            RedOutput.Text = GameEngine.Map.Player.ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            GameEngine.MovePlayer(Character.MovementEnum.Right);
            GameEngine.Map.gameMap[GameEngine.Map.Player.Y, GameEngine.Map.Player.X] = GameEngine.Map.Player;
            redPlayArea.Text = GameEngine.Map.ToString();
            RedOutput.Text = GameEngine.Map.Player.ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            GameEngine.MovePlayer(Character.MovementEnum.Down);
            GameEngine.Map.gameMap[GameEngine.Map.Player.Y, GameEngine.Map.Player.X] = GameEngine.Map.Player;
            redPlayArea.Text = GameEngine.Map.ToString();
            RedOutput.Text = GameEngine.Map.Player.ToString();
        }

        private void AttackBtn_Click(object sender, EventArgs e)
        {
            if (CmbListOfEnemies.SelectedIndex == -1) return;
           bool inRange =  GameEngine.Map.player.CheckRange(GameEngine.Map.Enemies[CmbListOfEnemies.SelectedIndex]);

          if (inRange)
          {
                MessageBox.Show("I am Attacking!!!!!");
                //redOutput.Lines.Append("I have attacked!");
          }
            else
            {
                MessageBox.Show("I can not Attack????");
                //redOutput.Lines.Append("I cannot attack?");
            }

        }

        private void ListOfEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListOfEnemies_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
                
    }
}