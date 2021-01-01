// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE")]
    public enum VideoExtensionCommandParameterType : int
    {
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT8")]
        VideoExtensionCommandParameterTypeUint8 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT16")]
        VideoExtensionCommandParameterTypeUint16 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT32")]
        VideoExtensionCommandParameterTypeUint32 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_UINT64")]
        VideoExtensionCommandParameterTypeUint64 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT8")]
        VideoExtensionCommandParameterTypeSint8 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT16")]
        VideoExtensionCommandParameterTypeSint16 = 0x5,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT32")]
        VideoExtensionCommandParameterTypeSint32 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_SINT64")]
        VideoExtensionCommandParameterTypeSint64 = 0x7,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_FLOAT")]
        VideoExtensionCommandParameterTypeFloat = 0x8,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_DOUBLE")]
        VideoExtensionCommandParameterTypeDouble = 0x9,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_RESOURCE")]
        VideoExtensionCommandParameterTypeResource = 0xA,
    }
}
