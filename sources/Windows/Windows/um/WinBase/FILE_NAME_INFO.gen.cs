// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_NAME_INFO.xml' path='doc/member[@name="FILE_NAME_INFO"]/*' />
public unsafe partial struct FILE_NAME_INFO
{
    /// <include file='FILE_NAME_INFO.xml' path='doc/member[@name="FILE_NAME_INFO.FileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    /// <include file='FILE_NAME_INFO.xml' path='doc/member[@name="FILE_NAME_INFO.FileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort FileName[1];
}
