﻿using System;

namespace HelloWorldService
{
    public class HelloWorldService : IHelloWorldService
    {
        public string GetMessage(string name)
        {
            return "Hello world from " + name + "!";
        }
    }
}
