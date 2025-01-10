// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FD_FLAGS
{
    FD_CLSID = 0x00000001,
    FD_SIZEPOINT = 0x00000002,
    FD_ATTRIBUTES = 0x00000004,
    FD_CREATETIME = 0x00000008,
    FD_ACCESSTIME = 0x00000010,
    FD_WRITESTIME = 0x00000020,
    FD_FILESIZE = 0x00000040,
    FD_PROGRESSUI = 0x00004000,
    FD_LINKUI = 0x00008000,
    FD_UNICODE = unchecked((int)(0x80000000)),
}
