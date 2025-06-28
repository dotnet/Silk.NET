// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "_MF_HDCP_STATUS")]
    public enum HdcpStatus : int
    {
        [NativeName("Name", "MF_HDCP_STATUS_ON")]
        On = 0x0,
        [NativeName("Name", "MF_HDCP_STATUS_OFF")]
        Off = 0x1,
        [NativeName("Name", "MF_HDCP_STATUS_ON_WITH_TYPE_ENFORCEMENT")]
        OnWithTypeEnforcement = 0x2,
    }
}
