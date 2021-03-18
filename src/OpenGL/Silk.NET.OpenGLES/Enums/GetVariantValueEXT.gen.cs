// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetVariantValueEXT")]
    public enum GetVariantValueEXT : int
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
