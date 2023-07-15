// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='DIEFFECTINFO.xml' path='doc/member[@name="DIEFFECTINFO"]/*'/>
public unsafe partial struct DIEFFECTINFO
{
    /// <include file='DIEFFECTINFO.xml' path='doc/member[@name="DIEFFECTINFO.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIEFFECTINFO.xml' path='doc/member[@name="DIEFFECTINFO.guid"]/*'/>
    public Guid guid;
    /// <include file='DIEFFECTINFO.xml' path='doc/member[@name="DIEFFECTINFO.dwEffType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEffType;
    /// <include file='DIEFFECTINFO.xml' path='doc/member[@name="DIEFFECTINFO.dwStaticParams"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStaticParams;
    /// <include file='DIEFFECTINFO.xml' path='doc/member[@name="DIEFFECTINFO.dwDynamicParams"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDynamicParams;
    /// <include file='DIEFFECTINFO.xml' path='doc/member[@name="DIEFFECTINFO.tszName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort tszName[260];
}