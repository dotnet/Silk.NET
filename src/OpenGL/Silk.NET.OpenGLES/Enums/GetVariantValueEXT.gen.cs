// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetVariantValueEXT")]
    public enum GetVariantValueEXT
    {
        [NativeName("Name", "GL_VARIANT_VALUE_EXT")]
        VariantValueExt = 0x87E4,
        [NativeName("Name", "GL_VARIANT_DATATYPE_EXT")]
        VariantDatatypeExt = 0x87E5,
        [NativeName("Name", "GL_VARIANT_ARRAY_STRIDE_EXT")]
        VariantArrayStrideExt = 0x87E6,
        [NativeName("Name", "GL_VARIANT_ARRAY_TYPE_EXT")]
        VariantArrayTypeExt = 0x87E7,
    }
}
