// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_chroma_location")]
    public enum MslChromaLocation : int
    {
        [NativeName("Name", "SPVC_MSL_CHROMA_LOCATION_COSITED_EVEN")]
        CositedEven = 0x0,
        [NativeName("Name", "SPVC_MSL_CHROMA_LOCATION_MIDPOINT")]
        Midpoint = 0x1,
        [NativeName("Name", "SPVC_MSL_CHROMA_LOCATION_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
