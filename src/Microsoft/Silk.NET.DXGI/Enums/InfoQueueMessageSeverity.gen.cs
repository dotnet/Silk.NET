// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY")]
    public enum InfoQueueMessageSeverity : int
    {
        [Obsolete("Deprecated in favour of \"Corruption\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_CORRUPTION")]
        InfoQueueMessageSeverityCorruption = 0x0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_ERROR")]
        InfoQueueMessageSeverityError = 0x1,
        [Obsolete("Deprecated in favour of \"Warning\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_WARNING")]
        InfoQueueMessageSeverityWarning = 0x2,
        [Obsolete("Deprecated in favour of \"Info\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_INFO")]
        InfoQueueMessageSeverityInfo = 0x3,
        [Obsolete("Deprecated in favour of \"Message\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_MESSAGE")]
        InfoQueueMessageSeverityMessage = 0x4,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_CORRUPTION")]
        Corruption = 0x0,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_ERROR")]
        Error = 0x1,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_WARNING")]
        Warning = 0x2,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_INFO")]
        Info = 0x3,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY_MESSAGE")]
        Message = 0x4,
    }
}
