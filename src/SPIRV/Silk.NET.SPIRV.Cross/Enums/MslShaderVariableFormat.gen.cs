// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [Flags]
    [NativeName("Name", "spvc_msl_shader_variable_format")]
    public enum MslShaderVariableFormat : int
    {
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_FORMAT_OTHER")]
        ShaderVariableFormatOther = 0x0,
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT8")]
        ShaderVariableFormatUint8 = 0x1,
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT16")]
        ShaderVariableFormatUint16 = 0x2,
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_FORMAT_ANY16")]
        ShaderVariableFormatAny16 = 0x3,
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_FORMAT_ANY32")]
        ShaderVariableFormatAny32 = 0x4,
        [NativeName("Name", "SPVC_MSL_VERTEX_FORMAT_OTHER")]
        VertexFormatOther = 0x0,
        [NativeName("Name", "SPVC_MSL_VERTEX_FORMAT_UINT8")]
        VertexFormatUint8 = 0x1,
        [NativeName("Name", "SPVC_MSL_VERTEX_FORMAT_UINT16")]
        VertexFormatUint16 = 0x2,
        [NativeName("Name", "SPVC_MSL_SHADER_INPUT_FORMAT_OTHER")]
        ShaderInputFormatOther = 0x0,
        [NativeName("Name", "SPVC_MSL_SHADER_INPUT_FORMAT_UINT8")]
        ShaderInputFormatUint8 = 0x1,
        [NativeName("Name", "SPVC_MSL_SHADER_INPUT_FORMAT_UINT16")]
        ShaderInputFormatUint16 = 0x2,
        [NativeName("Name", "SPVC_MSL_SHADER_INPUT_FORMAT_ANY16")]
        ShaderInputFormatAny16 = 0x3,
        [NativeName("Name", "SPVC_MSL_SHADER_INPUT_FORMAT_ANY32")]
        ShaderInputFormatAny32 = 0x4,
        [NativeName("Name", "SPVC_MSL_SHADER_INPUT_FORMAT_INT_MAX")]
        ShaderInputFormatIntMax = 0x7FFFFFFF,
    }
}
