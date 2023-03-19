// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiLightSourceType")]
    public enum LightSourceType : int
    {
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "aiLightSource_UNDEFINED")]
        LightSourceUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Directional\"")]
        [NativeName("Name", "aiLightSource_DIRECTIONAL")]
        LightSourceDirectional = 0x1,
        [Obsolete("Deprecated in favour of \"Point\"")]
        [NativeName("Name", "aiLightSource_POINT")]
        LightSourcePoint = 0x2,
        [Obsolete("Deprecated in favour of \"Spot\"")]
        [NativeName("Name", "aiLightSource_SPOT")]
        LightSourceSpot = 0x3,
        [Obsolete("Deprecated in favour of \"Ambient\"")]
        [NativeName("Name", "aiLightSource_AMBIENT")]
        LightSourceAmbient = 0x4,
        [Obsolete("Deprecated in favour of \"Area\"")]
        [NativeName("Name", "aiLightSource_AREA")]
        LightSourceArea = 0x5,
        [NativeName("Name", "aiLightSource_UNDEFINED")]
        Undefined = 0x0,
        [NativeName("Name", "aiLightSource_DIRECTIONAL")]
        Directional = 0x1,
        [NativeName("Name", "aiLightSource_POINT")]
        Point = 0x2,
        [NativeName("Name", "aiLightSource_SPOT")]
        Spot = 0x3,
        [NativeName("Name", "aiLightSource_AMBIENT")]
        Ambient = 0x4,
        [NativeName("Name", "aiLightSource_AREA")]
        Area = 0x5,
    }
}
