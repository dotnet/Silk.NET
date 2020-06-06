// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Reflection;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    public abstract class NativeApiContainer
    {
        protected NativeApiContainer(INativeContext ctx)
        {
            Context = ctx;
            GcUtility = new GcUtility();
        }
        
        public INativeContext Context { get; }
        public GcUtility GcUtility { get; }
        protected IntPtr LoadFunction(string func) => Context.GetProcAddress(func);
    }
}
