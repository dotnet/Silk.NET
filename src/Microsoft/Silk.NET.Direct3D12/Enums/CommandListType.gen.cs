// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_LIST_TYPE")]
    public enum CommandListType : int
    {
        [Obsolete("Deprecated in favour of \"Direct\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_DIRECT")]
        CommandListTypeDirect = 0x0,
        [Obsolete("Deprecated in favour of \"Bundle\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_BUNDLE")]
        CommandListTypeBundle = 0x1,
        [Obsolete("Deprecated in favour of \"Compute\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_COMPUTE")]
        CommandListTypeCompute = 0x2,
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_COPY")]
        CommandListTypeCopy = 0x3,
        [Obsolete("Deprecated in favour of \"VideoDecode\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE")]
        CommandListTypeVideoDecode = 0x4,
        [Obsolete("Deprecated in favour of \"VideoProcess\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS")]
        CommandListTypeVideoProcess = 0x5,
        [Obsolete("Deprecated in favour of \"VideoEncode\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE")]
        CommandListTypeVideoEncode = 0x6,
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_NONE")]
        CommandListTypeNone = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_DIRECT")]
        Direct = 0x0,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_BUNDLE")]
        Bundle = 0x1,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_COMPUTE")]
        Compute = 0x2,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_COPY")]
        Copy = 0x3,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE")]
        VideoDecode = 0x4,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS")]
        VideoProcess = 0x5,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE")]
        VideoEncode = 0x6,
        [NativeName("Name", "D3D12_COMMAND_LIST_TYPE_NONE")]
        None = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
