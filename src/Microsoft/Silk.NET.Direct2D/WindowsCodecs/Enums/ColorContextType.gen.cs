// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICColorContextType")]
    public enum ColorContextType : int
    {
        [NativeName("Name", "WICColorContextUninitialized")]
        Uninitialized = 0x0,
        [NativeName("Name", "WICColorContextProfile")]
        Profile = 0x1,
        [NativeName("Name", "WICColorContextExifColorSpace")]
        ExifColorSpace = 0x2,
    }
}
