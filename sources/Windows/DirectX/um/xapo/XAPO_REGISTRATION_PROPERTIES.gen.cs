// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAPO_REGISTRATION_PROPERTIES
{
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.clsid"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsid;
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.FriendlyName"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort FriendlyName[256];
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.CopyrightInfo"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort CopyrightInfo[256];
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MajorVersion"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MajorVersion;
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MinorVersion"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MinorVersion;
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.Flags"]/*'/>
    [NativeTypeName("UINT32")]
    public uint Flags;
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MinInputBufferCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MinInputBufferCount;
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MaxInputBufferCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MaxInputBufferCount;
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MinOutputBufferCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MinOutputBufferCount;
    /// <include file='XAPO_REGISTRATION_PROPERTIES.xml' path='doc/member[@name="XAPO_REGISTRATION_PROPERTIES.MaxOutputBufferCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint MaxOutputBufferCount;
}