using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoins
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<State> GetStates()
        {
            List <State> states = new List<State>
        { 
            new State { Id = 1, Name = "Hyderabad" },
            new State { Id = 2, Name = "Bangalore" },
            new State { Id = 3, Name = "Chennai" },
            new State { Id = 4, Name = "Mumbai" }
        };

        return states;

        }

    }
}
