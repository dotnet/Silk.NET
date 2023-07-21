// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO"]/*' />
public unsafe partial struct SOFTDISTINFO
{
    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwAdState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAdState;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.szTitle"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* szTitle;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.szAbstract"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* szAbstract;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.szHREF"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* szHREF;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwInstalledVersionMS"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInstalledVersionMS;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwInstalledVersionLS"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInstalledVersionLS;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwUpdateVersionMS"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUpdateVersionMS;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwUpdateVersionLS"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUpdateVersionLS;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwAdvertisedVersionMS"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAdvertisedVersionMS;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwAdvertisedVersionLS"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAdvertisedVersionLS;

    /// <include file='SOFTDISTINFO.xml' path='doc/member[@name="SOFTDISTINFO.dwReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved;
}
