// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
