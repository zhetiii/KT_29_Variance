namespace KT_Variance
{
    public class Animal { }
    public class Dog : Animal
    {
        public string Name { get; set; }
        public Dog(string name) => Name = name;
        public override string ToString() => $"Собака по кличке {Name}";
    }

    public interface IContainer<out T>
    {
        T GetItem();

    }

    public class Box<T> : IContainer<T>
    {
        private T _item;

        public Box(T item)
        {
            _item = item;
        }

        public T GetItem()
        {
            return _item;
        }
    }
}