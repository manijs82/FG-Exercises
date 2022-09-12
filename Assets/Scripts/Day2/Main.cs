namespace Scripts.Day2
{
    public class Main
    {
        public void Run()
        {
            GameObject go = new GameObject();
            go.MoveTo(new Vector3(10, 0, 10));

            Obstacle obstacle = new Obstacle();
            obstacle.MoveTo(new Vector3(5, 0, 5));
                
            Enemy enemy = new Enemy();
            enemy.MoveTo(go.GetPosition());

            Player player = new Player();
            player.Shoot();
        }
    }
}