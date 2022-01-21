// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DDECLMETHOD")]
    public enum Declmethod : int
    {
        [NativeName("Name", "D3DDECLMETHOD_DEFAULT")]
        DeclmethodDefault = 0x0,
        [NativeName("Name", "D3DDECLMETHOD_PARTIALU")]
        DeclmethodPartialu = 0x1,
        [NativeName("Name", "D3DDECLMETHOD_PARTIALV")]
        DeclmethodPartialv = 0x2,
        [NativeName("Name", "D3DDECLMETHOD_CROSSUV")]
        DeclmethodCrossuv = 0x3,
        [NativeName("Name", "D3DDECLMETHOD_UV")]
        DeclmethodUV = 0x4,
        [NativeName("Name", "D3DDECLMETHOD_LOOKUP")]
        DeclmethodLookup = 0x5,
        [NativeName("Name", "D3DDECLMETHOD_LOOKUPPRESAMPLED")]
        DeclmethodLookuppresampled = 0x6,
    }
}
