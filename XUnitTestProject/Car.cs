using System;
using System.Collections.Generic;

namespace XUnitTestProject
{
    public  class Car
    {
        public int Power { get; internal set; }

        public void Start()
        {
            Power = 100;
        }

        public void Stop()
        {
            Power = 0;
        }

        public void Back()
        {
            Power = -100;
        }
    }
}