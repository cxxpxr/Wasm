using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.JSInterop.WebAssembly;

namespace nkast.Wasm.Dom
{
    public class Div : JSObject
    {
        internal Div(int uid) : base(uid)
        {
        }

        public int ClientWidth
        {
            get { return InvokeRet<int>("nkElement.GetClientWidth"); }
        }

        public int ClientHeight
        {
            get { return InvokeRet<int>("nkElement.GetClientHeight"); }
        }
    }
}
