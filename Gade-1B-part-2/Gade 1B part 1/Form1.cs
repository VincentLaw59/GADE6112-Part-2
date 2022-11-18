namespace GADE6112_POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Generate Map
        private GameEngine gameEngine = new GameEngine();

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();
            gameEngine.GameMap.UpdateVision();

            UpdateEnemies();
        }

        private void bntUp_Click(object sender, EventArgs e)
        {

            gameEngine.MovePlayer(Character.MovementEnum.Up);
            gameEngine.GameMap.gameMap[gameEngine.GameMap.Player.X, gameEngine.GameMap.Player.Y] = gameEngine.GameMap.Player;
            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Clear();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();

            gameEngine.EnemiesMove();
            gameEngine.EnemyAttacks();
            UpdateEnemies();

            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            gameEngine.MovePlayer(Character.MovementEnum.Left);
            gameEngine.GameMap.gameMap[gameEngine.GameMap.Player.X, gameEngine.GameMap.Player.Y] = gameEngine.GameMap.Player;
            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Clear();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();

            gameEngine.EnemiesMove();
            gameEngine.EnemyAttacks();
            UpdateEnemies();

            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            gameEngine.MovePlayer(Character.MovementEnum.Down);
            gameEngine.GameMap.gameMap[gameEngine.GameMap.Player.X, gameEngine.GameMap.Player.Y] = gameEngine.GameMap.Player;
            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Clear();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();

            gameEngine.EnemiesMove();
            gameEngine.EnemyAttacks();
            UpdateEnemies();

            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

            gameEngine.MovePlayer(Character.MovementEnum.Right);
            gameEngine.GameMap.gameMap[gameEngine.GameMap.Player.X, gameEngine.GameMap.Player.Y] = gameEngine.GameMap.Player;
            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Clear();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();
            
            gameEngine.EnemiesMove();
            gameEngine.EnemyAttacks();
            UpdateEnemies();

            redPlayArea.Text = gameEngine.GameMap.ToString();
            RedOutput.Text = gameEngine.GameMap.Player.ToString();
        }

        private void UpdateEnemies()
        {
            redEnemies.Clear();

            CmbListOfEnemies.Items.Clear();
            for (int i = 0; i < gameEngine.GameMap.Enemies.Length; i++)
            {
                CmbListOfEnemies.Items.Add(gameEngine.GameMap.Enemies[i].ToString());
                redEnemies.Text = redEnemies.Text + gameEngine.GameMap.Enemies[i].ToString() + "Health: " + gameEngine.GameMap.Enemies[i].HP + "\n";
            }
            redPlayArea.Text = gameEngine.GameMap.ToString();

            CmbListOfEnemies.ResetText();
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            gameEngine.EnemyAttacks();
            UpdateEnemies();

            if (CmbListOfEnemies.SelectedItem != null)
            {
                gameEngine.AttackEnemy(gameEngine.GameMap.Enemies[CmbListOfEnemies.SelectedIndex]);
                redPlayArea.Text = gameEngine.GameMap.ToString();
            }
            else MessageBox.Show("No enemy selected!");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gameEngine.JSONSave("SaveFile.txt");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            gameEngine.JSONLoad("SaveFile.txt");
        }
    }
}