// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION"]/*' />
public unsafe partial struct FILE_NOTIFY_INFORMATION
{
    /// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION.NextEntryOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    /// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION.Action"]/*' />
    [NativeTypeName("DWORD")]
    public uint Action;

    /// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION.FileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    /// <include file='FILE_NOTIFY_INFORMATION.xml' path='doc/member[@name="FILE_NOTIFY_INFORMATION.FileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort FileName[1];
}
