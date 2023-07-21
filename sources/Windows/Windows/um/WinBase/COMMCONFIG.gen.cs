// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG"]/*' />
public unsafe partial struct COMMCONFIG
{
    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.wVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort wVersion;

    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.wReserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved;

    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dcb"]/*' />
    public DCB dcb;

    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dwProviderSubType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProviderSubType;

    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dwProviderOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProviderOffset;

    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.dwProviderSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProviderSize;

    /// <include file='COMMCONFIG.xml' path='doc/member[@name="COMMCONFIG.wcProviderData"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort wcProviderData[1];
}
