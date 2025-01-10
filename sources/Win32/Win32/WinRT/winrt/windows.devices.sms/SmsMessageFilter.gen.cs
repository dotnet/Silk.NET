// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Obsolete("SmsMessageFilter may be altered or unavailable for releases after Windows 10.")]
public enum SmsMessageFilter
{
    SmsMessageFilter_All = 0,
    SmsMessageFilter_Unread = 1,
    SmsMessageFilter_Read = 2,
    SmsMessageFilter_Sent = 3,
    SmsMessageFilter_Draft = 4,
}
