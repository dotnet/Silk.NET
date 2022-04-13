// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mipmap_filter_mode_img")]
    public enum MipmapFilterModeImg : int
    {
        [NativeName("Name", "CL_MIPMAP_FILTER_ANY_IMG")]
        MipmapFilterAnyImg = 0x0,
        [NativeName("Name", "CL_MIPMAP_FILTER_BOX_IMG")]
        MipmapFilterBoxImg = 0x1,
    }
}
