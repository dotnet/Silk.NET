// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpaceStorageLocationFB")]
    public enum SpaceStorageLocationFB : int
    {
        [NativeName("Name", "XR_SPACE_STORAGE_LOCATION_INVALID_FB")]
        SpaceStorageLocationInvalidFB = 0,
        [NativeName("Name", "XR_SPACE_STORAGE_LOCATION_LOCAL_FB")]
        SpaceStorageLocationLocalFB = 1,
    }
}
