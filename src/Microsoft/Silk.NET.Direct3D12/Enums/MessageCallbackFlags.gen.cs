// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_MESSAGE_CALLBACK_FLAGS")]
    public enum MessageCallbackFlags : int
    {
        [NativeName("Name", "D3D12_MESSAGE_CALLBACK_FLAG_NONE")]
        MessageCallbackFlagNone = 0x0,
        [NativeName("Name", "D3D12_MESSAGE_CALLBACK_IGNORE_FILTERS")]
        MessageCallbackIgnoreFilters = 0x1,
    }
}
