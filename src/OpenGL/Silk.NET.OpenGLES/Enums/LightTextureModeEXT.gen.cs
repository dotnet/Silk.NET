// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "LightTextureModeEXT")]
    public enum LightTextureModeEXT
    {
        [NativeName("Name", "GL_FRAGMENT_MATERIAL_EXT")]
        FragmentMaterialExt = 0x8349,
        [NativeName("Name", "GL_FRAGMENT_NORMAL_EXT")]
        FragmentNormalExt = 0x834A,
        [NativeName("Name", "GL_FRAGMENT_COLOR_EXT")]
        FragmentColorExt = 0x834C,
        [NativeName("Name", "GL_FRAGMENT_DEPTH_EXT")]
        FragmentDepthExt = 0x8452,
    }
}
