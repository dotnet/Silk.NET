// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.SilkTouch.Configuration
{
    [Flags]
    public enum FormFactors
    {
        None = 0,
        Roslyn = 1 << 0,
        CLI = 1 << 1
     }
}
