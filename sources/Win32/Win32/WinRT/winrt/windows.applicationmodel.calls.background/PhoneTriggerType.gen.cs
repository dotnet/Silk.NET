// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PhoneTriggerType
{
    PhoneTriggerType_NewVoicemailMessage = 0,
    PhoneTriggerType_CallHistoryChanged = 1,
    PhoneTriggerType_LineChanged = 2,
    PhoneTriggerType_AirplaneModeDisabledForEmergencyCall = 3,

    [Obsolete(
        "CallOriginDataRequest is deprecated and might not work for all platforms. For more info, see MSDN."
    )]
    PhoneTriggerType_CallOriginDataRequest = 4,
    PhoneTriggerType_CallBlocked = 5,

    [Obsolete(
        "IncomingCallDismissed is deprecated and might not work for all platforms. For more info, see MSDN."
    )]
    PhoneTriggerType_IncomingCallDismissed = 6,
    PhoneTriggerType_IncomingCallNotification = 7,
}
