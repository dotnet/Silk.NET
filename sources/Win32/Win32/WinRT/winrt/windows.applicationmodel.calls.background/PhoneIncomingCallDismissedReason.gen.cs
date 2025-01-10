// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Obsolete(
    "PhoneIncomingCallDismissedReason is deprecated and might not work for all platforms. For more info, see MSDN."
)]
public enum PhoneIncomingCallDismissedReason
{
    PhoneIncomingCallDismissedReason_Unknown = 0,
    PhoneIncomingCallDismissedReason_CallRejected = 1,
    PhoneIncomingCallDismissedReason_TextReply = 2,
    PhoneIncomingCallDismissedReason_ConnectionLost = 3,
}
