// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO"]/*'/>
public unsafe partial struct BINDINFO
{
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.szExtraInfo"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* szExtraInfo;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.stgmedData"]/*'/>
    public STGMEDIUM stgmedData;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.grfBindInfoF"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfBindInfoF;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.dwBindVerb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBindVerb;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.szCustomVerb"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* szCustomVerb;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.cbstgmedData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbstgmedData;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.dwOptions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOptions;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.dwOptionsFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOptionsFlags;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.dwCodePage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCodePage;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.securityAttributes"]/*'/>
    public SECURITY_ATTRIBUTES securityAttributes;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.iid"]/*'/>
    [NativeTypeName("IID")]
    public Guid iid;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.pUnk"]/*'/>
    public IUnknown* pUnk;
    /// <include file='BINDINFO.xml' path='doc/member[@name="BINDINFO.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
}