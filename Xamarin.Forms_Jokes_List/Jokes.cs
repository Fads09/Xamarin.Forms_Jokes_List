using System;
using System.Collections.Generic;

namespace Xamarin.Forms_Jokes_List
{
    public class Jokes
    {
        public string type { get; set; }
        public List<Value> value { get; set; }
    }

    public class Value
    {
        public int id { get; set; }
        public string joke { get; set; }
        public List<string> categories { get; set; }
    }

}
