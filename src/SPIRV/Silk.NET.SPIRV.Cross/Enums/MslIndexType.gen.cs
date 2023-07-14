// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_index_type")]
    public enum MslIndexType : int
    {
        [NativeName("Name", "SPVC_MSL_INDEX_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "SPVC_MSL_INDEX_TYPE_UINT16")]
        Uint16 = 0x1,
        [NativeName("Name", "SPVC_MSL_INDEX_TYPE_UINT32")]
        Uint32 = 0x2,
        [NativeName("Name", "SPVC_MSL_INDEX_TYPE_MAX_INT")]
        MaxInt = 0x7FFFFFFF,
    }
}
