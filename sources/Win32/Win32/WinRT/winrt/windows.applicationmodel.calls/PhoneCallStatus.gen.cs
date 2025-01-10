// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PhoneCallStatus
{
    PhoneCallStatus_Lost = 0,
    PhoneCallStatus_Incoming = 1,
    PhoneCallStatus_Dialing = 2,
    PhoneCallStatus_Talking = 3,
    PhoneCallStatus_Held = 4,
    PhoneCallStatus_Ended = 5,
}
