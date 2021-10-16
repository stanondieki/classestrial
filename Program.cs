using System;

namespace classestrial
{
    class Quotes
    {
        public virtual void strongQuotes()
        {
            Console.WriteLine("If you read it then you'll like it. Have self believe");
        }
    }
    class Destoh: Quotes
    {
        public override void strongQuotes()
        {
            Console.WriteLine("Destoh said:         Never give up because the person who discovered a bulb tried 1000 times to make the bulb light but 999 ways failed and the 1000 way worked out, Never Quit Easily!");
        }
    }
    class Don: Quotes
    {
        public override void strongQuotes()
        {
            Console.WriteLine("Don gave an ice breaker thought:         'Great ideas are achieved early in the weak hours of the day at exactly 3.00am'Wake Up Early ");
        }
    }
    class Ben: Quotes
    {
        public override void strongQuotes()
        {
            Console.WriteLine("Ben had to discover:         Evil plans are always for the weak and meek guys, Never allow yourself be weak beacuase you are strong than you think yo are. Stay Strong");
        }
    }
    class Raph: Quotes
    {
        public override void strongQuotes()
        {
            Console.WriteLine(" Raph:       No man gets fat by eating one big meal, However the main killer is egocentrism. Avoid Ego");
        }
    }
    class AgentX: Quotes
    {
        public override void strongQuotes()
        {
            Console.WriteLine("Agentx:      The thing you see is not the thing but the thing behind the thing we see is the thing. Aspect of Patience");
        }
    }
    class AgentY : Quotes
    {
        public override void strongQuotes()
        {
            Console.WriteLine("AgentY:           No one knows better than another, We speak to motivate and progress but not regress. Pride Comes After A Fall");
        }
    }
        class Cyro: Quotes
        {
            public override void strongQuotes()
            {
                Console.WriteLine("Cryo said:           You cannot milk a cow while pocketing, for you to get milk from that cow something needs to be done. No Success Without Effort");
            }
        }
    class Stanlee: Quotes
    {
        public override void strongQuotes()
        {


            Console.WriteLine("Stanlee crowned:          Mentally we believe the sky is the limit but why do we forget the  number of footsteps we make daily. A step at a time. Focus");


        }
    }
    class General: Quotes
    {
        public override void strongQuotes()
        {



            Console.WriteLine("General assumption:           Be a windshiled of a car but not a rear view mirror, Because windshield helps to focus our direction but rear view mirror distracts us by making us concentrate on the past scenes preventing us from focusing on the future");


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Quotes quote1= new Quotes();
            Quotes quote2= new Destoh();
            Quotes quote3 = new Don();
            Quotes quote4 = new Ben();
            Quotes quote5 = new Raph();
            Quotes quote6 = new AgentX();
            Quotes quote7 = new AgentY();
            Quotes quote8 = new Cyro();
            Quotes quote9 = new Stanlee();
            Quotes quote10 = new General();

            quote1.strongQuotes();
            quote2.strongQuotes();
            quote3.strongQuotes();
            quote4.strongQuotes();
            quote5.strongQuotes();
            quote6.strongQuotes();
            quote7.strongQuotes();
            quote8.strongQuotes();
            quote9.strongQuotes();
            quote10.strongQuotes();
        }
    }
}
