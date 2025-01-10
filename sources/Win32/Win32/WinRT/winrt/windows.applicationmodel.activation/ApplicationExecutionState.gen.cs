// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ApplicationExecutionState
{
    ApplicationExecutionState_NotRunning = 0,
    ApplicationExecutionState_Running = 1,
    ApplicationExecutionState_Suspended = 2,
    ApplicationExecutionState_Terminated = 3,
    ApplicationExecutionState_ClosedByUser = 4,
}
