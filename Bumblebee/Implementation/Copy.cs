﻿using Bumblebee.Interfaces;
using OpenQA.Selenium;

namespace Bumblebee.Implementation
{
    public class Copy<TResult> : Element, ICopy<TResult> where TResult : Block
    {
        public Copy(IBlock parent, By by) : base(parent, by)
        {
        }

        public Copy(IBlock parent, IWebElement element) : base(parent, element)
        {
        }

        public TResult Then()
        {
            return Then<TResult>();
        }
    }
}