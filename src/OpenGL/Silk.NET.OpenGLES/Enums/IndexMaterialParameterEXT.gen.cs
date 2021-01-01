// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "IndexMaterialParameterEXT")]
    public enum IndexMaterialParameterEXT : int
    {
        [NativeName("Name", "GL_INDEX_OFFSET")]
        IndexOffset = 0xD13,
    }
}
