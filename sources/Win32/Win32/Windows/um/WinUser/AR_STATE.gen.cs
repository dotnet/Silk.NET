// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum AR_STATE
{
    AR_ENABLED = 0x0,
    AR_DISABLED = 0x1,
    AR_SUPPRESSED = 0x2,
    AR_REMOTESESSION = 0x4,
    AR_MULTIMON = 0x8,
    AR_NOSENSOR = 0x10,
    AR_NOT_SUPPORTED = 0x20,
    AR_DOCKED = 0x40,
    AR_LAPTOP = 0x80,
}
