// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAGS")]
    public enum CommandListSupportFlags
    {
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_NONE")]
        CommandListSupportFlagNone = 0x0,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_DIRECT")]
        CommandListSupportFlagDirect = 0x1,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_BUNDLE")]
        CommandListSupportFlagBundle = 0x2,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_COMPUTE")]
        CommandListSupportFlagCompute = 0x4,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_COPY")]
        CommandListSupportFlagCopy = 0x8,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_DECODE")]
        CommandListSupportFlagVideoDecode = 0x10,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_PROCESS")]
        CommandListSupportFlagVideoProcess = 0x20,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_ENCODE")]
        CommandListSupportFlagVideoEncode = 0x40,
    }
}
