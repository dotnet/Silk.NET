// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS"]/*' />
public unsafe partial struct REGFILTERPINS
{
    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.strName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* strName;

    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.bRendered"]/*' />
    public BOOL bRendered;

    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.bOutput"]/*' />
    public BOOL bOutput;

    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.bZero"]/*' />
    public BOOL bZero;

    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.bMany"]/*' />
    public BOOL bMany;

    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.clsConnectsToFilter"]/*' />
    [NativeTypeName("const CLSID *")]
    public Guid* clsConnectsToFilter;

    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.strConnectsToPin"]/*' />
    [NativeTypeName("const WCHAR *")]
    public ushort* strConnectsToPin;

    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.nMediaTypes"]/*' />
    public uint nMediaTypes;

    /// <include file='REGFILTERPINS.xml' path='doc/member[@name="REGFILTERPINS.lpMediaType"]/*' />
    [NativeTypeName("const REGPINTYPES *")]
    public REGPINTYPES* lpMediaType;
}
