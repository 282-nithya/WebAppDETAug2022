namespace WebAppDETAug2022.Service
{
    public interface IHello
    {
        string SayHello(string name);
        //string SayHello(string v);
    }

    class Hello1 : IHello
    {
        public string SayHello(string name)
        {
            return $"hello {name} , welcome to Asp.net core";
        }
    }

    class Hello2 : IHello
    {
        public string SayHello(string name)
        {
            return $"hai ,hello{name} , how is your the day!{name}";
        }
    }
}
