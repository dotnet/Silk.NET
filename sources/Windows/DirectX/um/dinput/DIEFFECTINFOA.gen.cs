// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='DIEFFECTINFOA.xml' path='doc/member[@name="DIEFFECTINFOA"]/*' />
public unsafe partial struct DIEFFECTINFOA
{
    /// <include file='DIEFFECTINFOA.xml' path='doc/member[@name="DIEFFECTINFOA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIEFFECTINFOA.xml' path='doc/member[@name="DIEFFECTINFOA.guid"]/*' />
    public Guid guid;

    /// <include file='DIEFFECTINFOA.xml' path='doc/member[@name="DIEFFECTINFOA.dwEffType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEffType;

    /// <include file='DIEFFECTINFOA.xml' path='doc/member[@name="DIEFFECTINFOA.dwStaticParams"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStaticParams;

    /// <include file='DIEFFECTINFOA.xml' path='doc/member[@name="DIEFFECTINFOA.dwDynamicParams"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDynamicParams;

    /// <include file='DIEFFECTINFOA.xml' path='doc/member[@name="DIEFFECTINFOA.tszName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte tszName[260];
}
