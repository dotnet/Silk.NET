// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [Flags]
    [NativeName("Name", "aiLightSourceType")]
    public enum LightSourceType : int
    {
        [NativeName("Name", "aiLightSource_UNDEFINED")]
        LightSourceUndefined = 0x0,
        [NativeName("Name", "aiLightSource_DIRECTIONAL")]
        LightSourceDirectional = 0x1,
        [NativeName("Name", "aiLightSource_POINT")]
        LightSourcePoint = 0x2,
        [NativeName("Name", "aiLightSource_SPOT")]
        LightSourceSpot = 0x3,
        [NativeName("Name", "aiLightSource_AMBIENT")]
        LightSourceAmbient = 0x4,
        [NativeName("Name", "aiLightSource_AREA")]
        LightSourceArea = 0x5,
    }
}
