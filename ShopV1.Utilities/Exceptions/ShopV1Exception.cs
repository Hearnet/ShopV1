using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV1.Utilities.Exceptions
{
    public class ShopV1Exception : Exception
    {
        public ShopV1Exception()
        {
        }

        public ShopV1Exception(string message)
            : base(message)
        {
        }

        public ShopV1Exception(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
