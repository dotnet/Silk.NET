// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct FILEDESCRIPTORW
{
    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.clsid"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsid;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.sizel"]/*' />
    [NativeTypeName("SIZEL")]
    public SIZE sizel;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.pointl"]/*' />
    public POINTL pointl;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.dwFileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.ftCreationTime"]/*' />
    public FILETIME ftCreationTime;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.ftLastAccessTime"]/*' />
    public FILETIME ftLastAccessTime;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.ftLastWriteTime"]/*' />
    public FILETIME ftLastWriteTime;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.nFileSizeHigh"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.nFileSizeLow"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;

    /// <include file='FILEDESCRIPTORW.xml' path='doc/member[@name="FILEDESCRIPTORW.cFileName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort cFileName[260];
}
