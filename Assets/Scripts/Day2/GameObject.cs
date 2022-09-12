namespace Scripts.Day2
{
    public class GameObject
    {
        private string _id;
        protected Vector3 _position;

        public void MoveTo(Vector3 position) { }

        public Vector3 GetPosition() => _position;

        private void UpdatePosition() { }
    }
}
