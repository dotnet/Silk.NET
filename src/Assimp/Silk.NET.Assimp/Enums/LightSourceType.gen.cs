// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiLightSourceType")]
    public enum LightSourceType
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
