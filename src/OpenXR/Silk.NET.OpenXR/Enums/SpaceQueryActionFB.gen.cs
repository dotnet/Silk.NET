// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpaceQueryActionFB")]
    public enum SpaceQueryActionFB : int
    {
        [Obsolete("Deprecated in favour of \"LoadFB\"")]
        [NativeName("Name", "XR_SPACE_QUERY_ACTION_LOAD_FB")]
        SpaceQueryActionLoadFB = 0,
        [NativeName("Name", "XR_SPACE_QUERY_ACTION_LOAD_FB")]
        LoadFB = 0,
    }
}
