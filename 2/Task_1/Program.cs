#undef c
using System;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // C#
            SByte a = 0;
            Byte b = 0; 
            Int16 c = 0; 
            Int32 d = 0; 
            System.Int64 e = 0; 
            string s = "";
            Exception ex = new Exception();

            // C#
            object[] types = { a, b, c, d, e, s, ex };

            // C#
            foreach (object _vars in types)
            {
                string type;
                if (_vars.GetType().IsValueType) type = "Value type";
                else
                    type = "Reference Type";
                Console.WriteLine("{0}: {1}", _vars.GetType(), type);
            }
        }
    }
}
