// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpaceComponentTypeFB")]
    public enum SpaceComponentTypeFB : int
    {
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_LOCATABLE_FB")]
        SpaceComponentTypeLocatableFB = 0,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_STORABLE_FB")]
        SpaceComponentTypeStorableFB = 1,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_SPACE_CONTAINER_FB")]
        SpaceComponentTypeSpaceContainerFB = 7,
    }
}
