// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAGS")]
    public enum CommandListSupportFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_NONE")]
        CommandListSupportFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Direct\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_DIRECT")]
        CommandListSupportFlagDirect = 0x1,
        [Obsolete("Deprecated in favour of \"Bundle\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_BUNDLE")]
        CommandListSupportFlagBundle = 0x2,
        [Obsolete("Deprecated in favour of \"Compute\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_COMPUTE")]
        CommandListSupportFlagCompute = 0x4,
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_COPY")]
        CommandListSupportFlagCopy = 0x8,
        [Obsolete("Deprecated in favour of \"VideoDecode\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_DECODE")]
        CommandListSupportFlagVideoDecode = 0x10,
        [Obsolete("Deprecated in favour of \"VideoProcess\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_PROCESS")]
        CommandListSupportFlagVideoProcess = 0x20,
        [Obsolete("Deprecated in favour of \"VideoEncode\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_ENCODE")]
        CommandListSupportFlagVideoEncode = 0x40,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_DIRECT")]
        Direct = 0x1,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_BUNDLE")]
        Bundle = 0x2,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_COMPUTE")]
        Compute = 0x4,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_COPY")]
        Copy = 0x8,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_DECODE")]
        VideoDecode = 0x10,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_PROCESS")]
        VideoProcess = 0x20,
        [NativeName("Name", "D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_ENCODE")]
        VideoEncode = 0x40,
    }
}
