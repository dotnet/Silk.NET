// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SERVICE_ERROR_TYPE
{
    IgnoreError = 0x00000000,
    NormalError = 0x00000001,
    SevereError = 0x00000002,
    CriticalError = 0x00000003,
}
