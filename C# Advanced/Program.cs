namespace C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            /*
               A generic class uses type parameters that are replaced with actual types when you create an instance.
               
            Benefits of Generics : Type Safety , increase Performance ,Code Reuse
             
             */
            #endregion
            #region Q02
            /*
                   public static class Test <T>
                {
                private T _field;
                   public static T get() => _field;
                     public static void set(T field ) => _field = field;
            
                }
             
             */
            #endregion
            #region Q03
            /*
              Generic classes can have multiple type parameters. 

                 public class Pair <T1,T2>
        {
            public Pair(T1 frist, T2 secound)
            {
                Frist = frist;
                Secound = secound;
            }

            public T1 Frist{ get; set; }
            public T2 Secound{ get; set; }

            public override string ToString() => $"{Frist} - {Secound}";
    
             */
            #endregion
            #region Q04
            /*
               A generic method declares its own type parameter(s). It can exist in both generic and non-generic classes. The compiler often infers the type argument.

            public static class Swap
    {

        public static void swap<T>(ref T num01 , ref T num02)
        {
            T temp = num01;
            num01 = num02;
            num02 = temp;


        
        
        }

             
             */
            #endregion
            #region Q05
            /*
                public static T FindMax<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
             
             */

            #endregion
            #region Q06
            /*
             Generic interfaces define contracts with type parameters. Classes implementing them specify the actual types.

           public interface IRepository<T> where T : class
{
   T? GetById(int id);
   void Add(T entity);
   void Update(T entity);
   void Delete(int id);
}

            */

            #endregion
            #region Q07
            /*
                struct constraint: 	T must be a value type
               
               public void print<T>(T item) where T : struct
               {
               
                 Console.Writeline($"{item}")
            
            
              }

            int x =10;
            string y = "youssef"
            print(x)  // valid
            print(y)  // invalid
             
             */
            #endregion
            #region Q08
            /*
             
                             class constraint: 	T must be a reference  type
               
               public void print<T>(T item) where T : class
               {
               
                 Console.Writeline($"{item}")
            
            
              }

            int x =10;
            string y = "youssef"
            print(x)  // invalid
            print(y)  //  valid
             
             */



            #endregion
            #region Q09
            /*
               'new()' constraint : T must have parameterless constructor
                      
            public class Factory<T> where T : new()
{
    public T Create()
    {
        return new T(); //  Allowed because of new() constraint
    }
             */
            #endregion
            #region Q10
            /*
              interface constraint : T must implement interface
              public class Sorter<T> where T : IComparable<T>
{
    public void BubbleSort(T[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                //  CompareTo available because of constraint
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
             
             */
            #endregion
            #region Q11
            /*
             base class constraint: 	T must inherit from BaseClass

             
             */
            #endregion
            #region Q12
            /*
              multiple constraints: You can combine multiple constraints for a single type parameter, and have different constraints for different type parameters.
              public class EntityManager<T> 
    where T : class, IEntity, new()
{
    public T CreateAndSave()
    {
        var entity = new T();      //  new() constraint
        entity.Id = Guid.NewGuid(); //  IEntity constraint
        return entity;
    }
}
             
             */
            #endregion
            #region Q13
            /*
             
             default returns the default value for type T: null for reference types, 0/false for value types.
             
             */
            #endregion
            #region Q14
            /*
              public class SafeList<T>
{
    private List<T> _items = new();

    public T GetAt(int index)
    {
        if (index >= 0 && index < _items.Count)
            return _items[index];
        return default(T);
    }


             */
            #endregion
            #region Q15
            /*
             Covariance allows you to use a more derived type than originally specified. Marked with out keyword. T can only appear in output positions.

             */
            #endregion
            #region Q16
            /*
             Contravariance allows you to use a less derived type than originally specified. Marked with in keyword. T can only appear in input positions.
             */
            #endregion
            #region Q17
            /*
             
             	Covariance (out)	  Vs        Contravariance (in)
              	   Derived  Base	               Base  Derived
                Output only (return)	        Input only (parameter)
                IEnumerable<out T>	              Action<in T>
           	      Producer of T	                   Consumer of T
             
             */
            #endregion
            #region Q18
            /*
               Each closed generic type has its own copy of static fields.
             */
            #endregion
            #region Q19
            /* 
              Generic classes can inherit from other generic or non-generic classes. Several patterns are possible.

             */
            #endregion
           


        }
    }
}
