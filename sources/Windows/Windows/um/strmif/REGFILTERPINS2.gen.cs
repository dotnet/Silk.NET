// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='REGFILTERPINS2.xml' path='doc/member[@name="REGFILTERPINS2"]/*'/>
public unsafe partial struct REGFILTERPINS2
{
    /// <include file='REGFILTERPINS2.xml' path='doc/member[@name="REGFILTERPINS2.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='REGFILTERPINS2.xml' path='doc/member[@name="REGFILTERPINS2.cInstances"]/*'/>
    public uint cInstances;
    /// <include file='REGFILTERPINS2.xml' path='doc/member[@name="REGFILTERPINS2.nMediaTypes"]/*'/>
    public uint nMediaTypes;
    /// <include file='REGFILTERPINS2.xml' path='doc/member[@name="REGFILTERPINS2.lpMediaType"]/*'/>
    [NativeTypeName("const REGPINTYPES *")]
    public REGPINTYPES* lpMediaType;
    /// <include file='REGFILTERPINS2.xml' path='doc/member[@name="REGFILTERPINS2.nMediums"]/*'/>
    public uint nMediums;
    /// <include file='REGFILTERPINS2.xml' path='doc/member[@name="REGFILTERPINS2.lpMedium"]/*'/>
    [NativeTypeName("const REGPINMEDIUM *")]
    public REGPINMEDIUM* lpMedium;
    /// <include file='REGFILTERPINS2.xml' path='doc/member[@name="REGFILTERPINS2.clsPinCategory"]/*'/>
    [NativeTypeName("const CLSID *")]
    public Guid* clsPinCategory;
}