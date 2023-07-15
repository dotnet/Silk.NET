// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct FILEDESCRIPTORA
{
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.clsid"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsid;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.sizel"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE sizel;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.pointl"]/*'/>
    public POINTL pointl;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.dwFileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.ftCreationTime"]/*'/>
    public FILETIME ftCreationTime;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.ftLastAccessTime"]/*'/>
    public FILETIME ftLastAccessTime;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.ftLastWriteTime"]/*'/>
    public FILETIME ftLastWriteTime;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.nFileSizeHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.nFileSizeLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;
    /// <include file='FILEDESCRIPTORA.xml' path='doc/member[@name="FILEDESCRIPTORA.cFileName"]/*'/>
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte cFileName[260];
}