// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE")]
    public enum VideoExtensionCommandParameterType : int
    {
        [Obsolete("Deprecated in favour of \"Uint8\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT8")]
        VideoExtensionCommandParameterTypeUint8 = 0x0,
        [Obsolete("Deprecated in favour of \"Uint16\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT16")]
        VideoExtensionCommandParameterTypeUint16 = 0x1,
        [Obsolete("Deprecated in favour of \"Uint32\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT32")]
        VideoExtensionCommandParameterTypeUint32 = 0x2,
        [Obsolete("Deprecated in favour of \"Uint64\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT64")]
        VideoExtensionCommandParameterTypeUint64 = 0x3,
        [Obsolete("Deprecated in favour of \"Sint8\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT8")]
        VideoExtensionCommandParameterTypeSint8 = 0x4,
        [Obsolete("Deprecated in favour of \"Sint16\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT16")]
        VideoExtensionCommandParameterTypeSint16 = 0x5,
        [Obsolete("Deprecated in favour of \"Sint32\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT32")]
        VideoExtensionCommandParameterTypeSint32 = 0x6,
        [Obsolete("Deprecated in favour of \"Sint64\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT64")]
        VideoExtensionCommandParameterTypeSint64 = 0x7,
        [Obsolete("Deprecated in favour of \"Float\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_FLOAT")]
        VideoExtensionCommandParameterTypeFloat = 0x8,
        [Obsolete("Deprecated in favour of \"Double\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_DOUBLE")]
        VideoExtensionCommandParameterTypeDouble = 0x9,
        [Obsolete("Deprecated in favour of \"Resource\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_RESOURCE")]
        VideoExtensionCommandParameterTypeResource = 0xA,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT8")]
        Uint8 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT16")]
        Uint16 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT32")]
        Uint32 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT64")]
        Uint64 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT8")]
        Sint8 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT16")]
        Sint16 = 0x5,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT32")]
        Sint32 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT64")]
        Sint64 = 0x7,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_FLOAT")]
        Float = 0x8,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_DOUBLE")]
        Double = 0x9,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_RESOURCE")]
        Resource = 0xA,
    }
}
