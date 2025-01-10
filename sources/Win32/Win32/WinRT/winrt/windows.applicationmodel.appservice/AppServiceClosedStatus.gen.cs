// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppServiceClosedStatus
{
    AppServiceClosedStatus_Completed = 0,
    AppServiceClosedStatus_Canceled = 1,
    AppServiceClosedStatus_ResourceLimitsExceeded = 2,
    AppServiceClosedStatus_Unknown = 3,
}
