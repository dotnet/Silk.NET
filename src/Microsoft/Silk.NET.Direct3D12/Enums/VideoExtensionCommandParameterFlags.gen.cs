// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS")]
    public enum VideoExtensionCommandParameterFlags
    {
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_NONE")]
        VideoExtensionCommandParameterFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_READ")]
        VideoExtensionCommandParameterFlagRead = 0x1,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_WRITE")]
        VideoExtensionCommandParameterFlagWrite = 0x2,
    }
}
