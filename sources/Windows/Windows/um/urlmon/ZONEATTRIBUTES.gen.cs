// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES"]/*' />
public unsafe partial struct ZONEATTRIBUTES
{
    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.szDisplayName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szDisplayName[260];

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.szDescription"]/*' />
    [NativeTypeName("WCHAR[200]")]
    public fixed ushort szDescription[200];

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.szIconPath"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szIconPath[260];

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.dwTemplateMinLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTemplateMinLevel;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.dwTemplateRecommended"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTemplateRecommended;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.dwTemplateCurrentLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTemplateCurrentLevel;

    /// <include file='ZONEATTRIBUTES.xml' path='doc/member[@name="ZONEATTRIBUTES.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
