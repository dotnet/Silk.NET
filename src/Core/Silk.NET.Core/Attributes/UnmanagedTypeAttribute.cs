// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Core.Attributes
{
    [AttributeUsage(AttributeTargets.ReturnValue | AttributeTargets.Parameter)]
    public class UnmanagedTypeAttribute : Attribute
    {
        // the fields are not stored anywhere, they are to be accessed by SilkTouch via Roslyn
        public UnmanagedTypeAttribute(UnmanagedType unmanagedType) { }
    }
}
