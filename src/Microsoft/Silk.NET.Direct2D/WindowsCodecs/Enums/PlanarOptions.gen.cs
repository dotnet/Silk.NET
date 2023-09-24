// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPlanarOptions")]
    public enum PlanarOptions : int
    {
        [NativeName("Name", "WICPlanarOptionsDefault")]
        PlanarOptionsDefault = 0x0,
        [NativeName("Name", "WICPlanarOptionsPreserveSubsampling")]
        PlanarOptionsPreserveSubsampling = 0x1,
        [NativeName("Name", "WICPLANAROPTIONS_FORCE_DWORD")]
        LanaroptionsForceDword = 0x7FFFFFFF,
    }
}
