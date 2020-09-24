using System;

namespace Hello_World
    // namespace can be viewed as an organisaton tool. For better organization of classes the namespae should follow 
    // the organization of your folders. Namespaces can have subnamespaces too.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point point= new Point();
            // Here we creted the instance of that class. When we use the keyword "new", we are creating a new instance
            // of given class(object). 
            point.x = 5;
            point.y = 4;
            Console.WriteLine("Integer x= {0}",point.x);
            int fact=5;
            for (int i=fact-1; i>0; i-- )
                {
                fact = i * fact;
                }
            Console.WriteLine(fact);
        }
    }

    class Point
    {
        public int x, y;

    }


}
