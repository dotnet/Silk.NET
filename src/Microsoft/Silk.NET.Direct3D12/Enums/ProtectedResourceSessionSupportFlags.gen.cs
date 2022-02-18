// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS")]
    public enum ProtectedResourceSessionSupportFlags : int
    {
        [NativeName("Name", "D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_NONE")]
        ProtectedResourceSessionSupportFlagNone = 0x0,
        [NativeName("Name", "D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_SUPPORTED")]
        ProtectedResourceSessionSupportFlagSupported = 0x1,
    }
}
