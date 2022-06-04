// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpacePersistenceModeFB")]
    public enum SpacePersistenceModeFB : int
    {
        [NativeName("Name", "XR_SPACE_PERSISTENCE_MODE_INVALID_FB")]
        SpacePersistenceModeInvalidFB = 0,
        [NativeName("Name", "XR_SPACE_PERSISTENCE_MODE_INDEFINITE_FB")]
        SpacePersistenceModeIndefiniteFB = 1,
    }
}
