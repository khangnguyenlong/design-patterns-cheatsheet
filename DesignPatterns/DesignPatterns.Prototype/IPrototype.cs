namespace DesignPatterns.Prototype
{
    internal interface IPrototype<T> where T : class
    {
        T DeepClone();
    }
}
