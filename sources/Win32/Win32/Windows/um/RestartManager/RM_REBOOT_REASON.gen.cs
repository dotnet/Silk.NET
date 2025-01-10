// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum RM_REBOOT_REASON
{
    RmRebootReasonNone = 0x0,
    RmRebootReasonPermissionDenied = 0x1,
    RmRebootReasonSessionMismatch = 0x2,
    RmRebootReasonCriticalProcess = 0x4,
    RmRebootReasonCriticalService = 0x8,
    RmRebootReasonDetectedSelf = 0x10,
}
