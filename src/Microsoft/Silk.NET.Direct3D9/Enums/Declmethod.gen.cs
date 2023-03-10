// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDECLMETHOD")]
    public enum Declmethod : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D3DDECLMETHOD_DEFAULT")]
        DeclmethodDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Partialu\"")]
        [NativeName("Name", "D3DDECLMETHOD_PARTIALU")]
        DeclmethodPartialu = 0x1,
        [Obsolete("Deprecated in favour of \"Partialv\"")]
        [NativeName("Name", "D3DDECLMETHOD_PARTIALV")]
        DeclmethodPartialv = 0x2,
        [Obsolete("Deprecated in favour of \"Crossuv\"")]
        [NativeName("Name", "D3DDECLMETHOD_CROSSUV")]
        DeclmethodCrossuv = 0x3,
        [Obsolete("Deprecated in favour of \"UV\"")]
        [NativeName("Name", "D3DDECLMETHOD_UV")]
        DeclmethodUV = 0x4,
        [Obsolete("Deprecated in favour of \"Lookup\"")]
        [NativeName("Name", "D3DDECLMETHOD_LOOKUP")]
        DeclmethodLookup = 0x5,
        [Obsolete("Deprecated in favour of \"Lookuppresampled\"")]
        [NativeName("Name", "D3DDECLMETHOD_LOOKUPPRESAMPLED")]
        DeclmethodLookuppresampled = 0x6,
        [NativeName("Name", "D3DDECLMETHOD_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D3DDECLMETHOD_PARTIALU")]
        Partialu = 0x1,
        [NativeName("Name", "D3DDECLMETHOD_PARTIALV")]
        Partialv = 0x2,
        [NativeName("Name", "D3DDECLMETHOD_CROSSUV")]
        Crossuv = 0x3,
        [NativeName("Name", "D3DDECLMETHOD_UV")]
        UV = 0x4,
        [NativeName("Name", "D3DDECLMETHOD_LOOKUP")]
        Lookup = 0x5,
        [NativeName("Name", "D3DDECLMETHOD_LOOKUPPRESAMPLED")]
        Lookuppresampled = 0x6,
    }
}
