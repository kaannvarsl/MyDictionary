// See https://aka.ms/new-console-template for more information
namespace MyDictionary
{
    class MyDictionary<T,J>
    {
        T[] keys;
        J[] values;
        T[] tempKey;
        J[] tempValue;

        public MyDictionary()
        {
            keys = new T[0];
            values = new J[0];

        }
         public void Add(T key, J value)
        {
            tempKey = keys;
            tempValue = values;
            keys = new T[keys.Length + 1];
            values = new J[values.Length + 1];

            for (int i = 0 ;  i< tempKey.Length; i++)
            {
                keys[i]= tempKey[i];
                values[i] = tempValue[i];
            }
             keys[keys.Length-1] = key;
            values[keys.Length - 1] = value;
            Console.WriteLine("Eklendi");
        }
        
     }
}    
   
