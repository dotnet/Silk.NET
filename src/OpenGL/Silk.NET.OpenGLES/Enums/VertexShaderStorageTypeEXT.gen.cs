// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexShaderStorageTypeEXT")]
    public enum VertexShaderStorageTypeEXT : int
    {
        [NativeName("Name", "GL_VARIANT_EXT")]
        VariantExt = 0x87C1,
        [NativeName("Name", "GL_INVARIANT_EXT")]
        InvariantExt = 0x87C2,
        [NativeName("Name", "GL_LOCAL_CONSTANT_EXT")]
        LocalConstantExt = 0x87C3,
        [NativeName("Name", "GL_LOCAL_EXT")]
        LocalExt = 0x87C4,
    }
}
