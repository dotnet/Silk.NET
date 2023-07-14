// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FACTORY_TYPE")]
    public enum FactoryType : int
    {
        [NativeName("Name", "DWRITE_FACTORY_TYPE_SHARED")]
        Shared = 0x0,
        [NativeName("Name", "DWRITE_FACTORY_TYPE_ISOLATED")]
        Isolated = 0x1,
    }
}
