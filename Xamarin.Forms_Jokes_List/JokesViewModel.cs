using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;

namespace Xamarin.Forms_Jokes_List
{
    public class JokesViewModel
    {
        public Jokes JokeList { get; set; }
        public JokesViewModel()
        {
            JokeList = JokeMockData();           
        }

        private Jokes JokeMockData()
        {
            var jokeList = new Jokes {
                type = "", value = new List<Value> { new Value { id= 2, joke="hello word"} }
            };
            return jokeList;
        }
    }
}
