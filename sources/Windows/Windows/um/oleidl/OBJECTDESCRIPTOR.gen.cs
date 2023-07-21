// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR"]/*' />
public partial struct OBJECTDESCRIPTOR
{
    /// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR.clsid"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsid;

    /// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR.dwDrawAspect"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDrawAspect;

    /// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR.sizel"]/*' />
    [NativeTypeName("SIZEL")]
    public SIZE sizel;

    /// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR.pointl"]/*' />
    public POINTL pointl;

    /// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR.dwStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStatus;

    /// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR.dwFullUserTypeName"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFullUserTypeName;

    /// <include file='OBJECTDESCRIPTOR.xml' path='doc/member[@name="OBJECTDESCRIPTOR.dwSrcOfCopy"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSrcOfCopy;
}
