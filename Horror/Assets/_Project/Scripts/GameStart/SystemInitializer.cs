namespace Game
{
    public abstract class SystemInitializer<T> where T : View
    {
        public abstract void Initialize(T view);
    }
}