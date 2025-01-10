// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYSKIND
{
    SYS_WIN16 = 0,
    SYS_WIN32 = (SYS_WIN16 + 1),
    SYS_MAC = (SYS_WIN32 + 1),
    SYS_WIN64 = (SYS_MAC + 1),
}
