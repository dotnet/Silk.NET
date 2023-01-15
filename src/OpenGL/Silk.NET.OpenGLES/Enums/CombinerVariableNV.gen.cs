// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "CombinerVariableNV")]
    public enum CombinerVariableNV : int
    {
        [Obsolete("Deprecated in favour of \"ANV\"")]
        [NativeName("Name", "GL_VARIABLE_A_NV")]
        VariableANV = 0x8523,
        [Obsolete("Deprecated in favour of \"BNV\"")]
        [NativeName("Name", "GL_VARIABLE_B_NV")]
        VariableBNV = 0x8524,
        [Obsolete("Deprecated in favour of \"CNV\"")]
        [NativeName("Name", "GL_VARIABLE_C_NV")]
        VariableCNV = 0x8525,
        [Obsolete("Deprecated in favour of \"DNV\"")]
        [NativeName("Name", "GL_VARIABLE_D_NV")]
        VariableDNV = 0x8526,
        [Obsolete("Deprecated in favour of \"ENV\"")]
        [NativeName("Name", "GL_VARIABLE_E_NV")]
        VariableENV = 0x8527,
        [Obsolete("Deprecated in favour of \"FNV\"")]
        [NativeName("Name", "GL_VARIABLE_F_NV")]
        VariableFNV = 0x8528,
        [Obsolete("Deprecated in favour of \"GNV\"")]
        [NativeName("Name", "GL_VARIABLE_G_NV")]
        VariableGNV = 0x8529,
        [NativeName("Name", "GL_VARIABLE_A_NV")]
        ANV = 0x8523,
        [NativeName("Name", "GL_VARIABLE_B_NV")]
        BNV = 0x8524,
        [NativeName("Name", "GL_VARIABLE_C_NV")]
        CNV = 0x8525,
        [NativeName("Name", "GL_VARIABLE_D_NV")]
        DNV = 0x8526,
        [NativeName("Name", "GL_VARIABLE_E_NV")]
        ENV = 0x8527,
        [NativeName("Name", "GL_VARIABLE_F_NV")]
        FNV = 0x8528,
        [NativeName("Name", "GL_VARIABLE_G_NV")]
        GNV = 0x8529,
    }
}
