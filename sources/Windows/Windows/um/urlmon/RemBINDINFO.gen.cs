// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO"]/*'/>
public unsafe partial struct RemBINDINFO
{
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.szExtraInfo"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* szExtraInfo;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.grfBindInfoF"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfBindInfoF;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.dwBindVerb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBindVerb;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.szCustomVerb"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* szCustomVerb;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.cbstgmedData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbstgmedData;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.dwOptions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOptions;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.dwOptionsFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOptionsFlags;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.dwCodePage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCodePage;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.securityAttributes"]/*'/>
    public REMSECURITY_ATTRIBUTES securityAttributes;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.iid"]/*'/>
    [NativeTypeName("IID")]
    public Guid iid;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.pUnk"]/*'/>
    public IUnknown* pUnk;
    /// <include file='RemBINDINFO.xml' path='doc/member[@name="RemBINDINFO.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
}