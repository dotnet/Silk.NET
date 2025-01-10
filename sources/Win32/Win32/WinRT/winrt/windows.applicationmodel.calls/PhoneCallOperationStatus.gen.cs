// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PhoneCallOperationStatus
{
    PhoneCallOperationStatus_Succeeded = 0,
    PhoneCallOperationStatus_OtherFailure = 1,
    PhoneCallOperationStatus_TimedOut = 2,
    PhoneCallOperationStatus_ConnectionLost = 3,
    PhoneCallOperationStatus_InvalidCallState = 4,
}
