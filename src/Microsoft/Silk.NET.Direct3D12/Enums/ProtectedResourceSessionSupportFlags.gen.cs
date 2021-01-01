// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS")]
    public enum ProtectedResourceSessionSupportFlags : int
    {
        [NativeName("Name", "D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_NONE")]
        ProtectedResourceSessionSupportFlagNone = 0x0,
        [NativeName("Name", "D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_SUPPORTED")]
        ProtectedResourceSessionSupportFlagSupported = 0x1,
    }
}
