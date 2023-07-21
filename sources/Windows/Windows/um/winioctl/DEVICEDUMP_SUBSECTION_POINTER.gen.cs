// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='DEVICEDUMP_SUBSECTION_POINTER.xml' path='doc/member[@name="DEVICEDUMP_SUBSECTION_POINTER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DEVICEDUMP_SUBSECTION_POINTER
{
    /// <include file='DEVICEDUMP_SUBSECTION_POINTER.xml' path='doc/member[@name="DEVICEDUMP_SUBSECTION_POINTER.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DEVICEDUMP_SUBSECTION_POINTER.xml' path='doc/member[@name="DEVICEDUMP_SUBSECTION_POINTER.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DEVICEDUMP_SUBSECTION_POINTER.xml' path='doc/member[@name="DEVICEDUMP_SUBSECTION_POINTER.dwOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOffset;
}
