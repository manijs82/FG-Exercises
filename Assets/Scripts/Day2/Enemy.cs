namespace Scripts.Day2
{
    public class Enemy : GameObject, ILife
    {
        private int _life;
        
        public void Shoot() { }

        public int GetLife()
        {
            return _life;
        }

        public void TakeDamage(int damage)
        {
            
        }
    }
}