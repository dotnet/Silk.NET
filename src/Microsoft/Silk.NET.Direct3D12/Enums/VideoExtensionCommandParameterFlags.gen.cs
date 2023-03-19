// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS")]
    public enum VideoExtensionCommandParameterFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_NONE")]
        VideoExtensionCommandParameterFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Read\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_READ")]
        VideoExtensionCommandParameterFlagRead = 0x1,
        [Obsolete("Deprecated in favour of \"Write\"")]
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_WRITE")]
        VideoExtensionCommandParameterFlagWrite = 0x2,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_READ")]
        Read = 0x1,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_WRITE")]
        Write = 0x2,
    }
}
