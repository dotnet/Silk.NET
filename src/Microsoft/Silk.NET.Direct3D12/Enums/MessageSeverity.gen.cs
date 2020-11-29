// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MESSAGE_SEVERITY")]
    public enum MessageSeverity
    {
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_CORRUPTION")]
        MessageSeverityCorruption = 0x0,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_ERROR")]
        MessageSeverityError = 0x1,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_WARNING")]
        MessageSeverityWarning = 0x2,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_INFO")]
        MessageSeverityInfo = 0x3,
        [NativeName("Name", "D3D12_MESSAGE_SEVERITY_MESSAGE")]
        MessageSeverityMessage = 0x4,
    }
}
