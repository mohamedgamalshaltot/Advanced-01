namespace C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 in C# Advanced
            //Q1: What is a generic class? Why use generics?
            // A generic class is a class that allows you to define a blueprint with a placeholder for data types, typically represented by a type parameter enclosed in angle brackets ⁠<T>⁠. This allows the class to operate on any data type (such as ⁠int⁠, ⁠string⁠, or custom classes) without being hardcoded to a specific type during its design.
            // why use generics? Generics provide several benefits, including:
            // 1. Type Safety: Generics allow you to catch type-related errors at compile time, reducing the risk of runtime exceptions.
            // 2. Code Reusability: You can create a single generic class or method that works with different data types, reducing code duplication.
            // 3. Performance: Generics can improve performance by avoiding boxing and unboxing operations for value types, as well as reducing the need for type casting.
            // 4. Maintainability: Generics make code easier to read and maintain, as they clearly indicate the intended data types and reduce the need for multiple overloads or specialized implementations.
            // 5. Flexibility: Generics allow you to create more flexible and adaptable code that can work with a wide range of data types, making it easier to extend and modify your codebase in the future.

            #endregion
            #region Q2 in C# Advanced
            //Q2: Write a generic class Container<T> with Add and Get methods.
            // A generic class Container<T> can be implemented as follows:
            /*
             public class Container<T>
            {
             private List<T> items = new List<T>();
             public void Add(T item)
             {
                 items.Add(item);
             }
             public T Get(int index)
             {
                 if (index < 0 || index >= items.Count)
                 {
                     throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                 }
                 return items[index];
             }
            }
            */

            #endregion
            #region Q3 in C# Advanced
            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            // Multiple type parameters allow you to define a generic class or method that can work with more than one type. This is useful when you want to create a relationship between two or more types in your generic implementation.
            // A generic class Pair<TKey, TValue> can be implemented as follows:
            /*
             public class Pair<TKey, TValue>
            
            // {
            // public TKey Key { get; set; }
            // public TValue Value { get; set; }
            // public Pair(TKey key, TValue value)
            // {
            //     Key = key;
            //     Value = value;
            // }
            */
            #endregion
        }


    }

}
