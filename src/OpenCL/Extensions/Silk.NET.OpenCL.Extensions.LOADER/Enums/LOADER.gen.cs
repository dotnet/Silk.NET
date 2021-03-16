// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.LOADER
{
    [NativeName("Name", "GLenum")]
    public enum LOADER : int
    {
        [NativeName("Name", "CL_LAYER_API_VERSION")]
        LayerApiVersion = 0x4240,
        [NativeName("Name", "CL_LAYER_API_VERSION_100")]
        LayerApiVersion100 = 0x100,
    }
}
