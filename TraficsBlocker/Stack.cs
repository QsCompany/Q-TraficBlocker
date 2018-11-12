using System.Linq;

namespace _
{
    public class Stack<T> : System.Collections.Generic.Stack<T>
    {
        public static implicit operator T(Stack<T> f)
        {
            if (f.Count == 0) return default(T);
            return f.Last();
        }
    }
}