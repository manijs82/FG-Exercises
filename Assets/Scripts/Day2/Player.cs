namespace Scripts.Day2
{
    public class Player : GameObject, ILife
    {
        private string _name;
        private int _life;
        
        public void TakeDamage(int damage) { }
        public int GetLife() => _life;
        
        public string GetName() => _name;
        public void SetName(string name) { }
        public void Shoot() { }
    }
}