// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_LIST_TYPE")]
    public enum CommandListType : int
    {
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_DIRECT")]
        CommandListTypeDirect = 0x0,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_BUNDLE")]
        CommandListTypeBundle = 0x1,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_COMPUTE")]
        CommandListTypeCompute = 0x2,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_COPY")]
        CommandListTypeCopy = 0x3,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE")]
        CommandListTypeVideoDecode = 0x4,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS")]
        CommandListTypeVideoProcess = 0x5,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE")]
        CommandListTypeVideoEncode = 0x6,
    }
}
