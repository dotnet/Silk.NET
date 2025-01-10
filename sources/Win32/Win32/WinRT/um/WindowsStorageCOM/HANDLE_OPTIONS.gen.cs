// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Flags]
[SupportedOSPlatform("windows10.0")]
public enum HANDLE_OPTIONS
{
    HO_NONE = 0,
    HO_OPEN_REQUIRING_OPLOCK = 0x40000,
    HO_DELETE_ON_CLOSE = 0x4000000,
    HO_SEQUENTIAL_SCAN = 0x8000000,
    HO_RANDOM_ACCESS = 0x10000000,
    HO_NO_BUFFERING = 0x20000000,
    HO_OVERLAPPED = 0x40000000,
    HO_WRITE_THROUGH = unchecked((int)(0x80000000)),
}
