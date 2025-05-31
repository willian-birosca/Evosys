namespace Evosys.Components.Scripts
{
    public abstract class SingletonBase<T> where T : class, new()
    {
        private static readonly Lazy<T> _instance = new(() => new T());

        public static T Instance => _instance.Value;

        protected SingletonBase()
        {
        }
    }
}