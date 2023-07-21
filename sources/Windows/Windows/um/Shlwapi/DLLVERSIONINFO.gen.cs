// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DLLVERSIONINFO.xml' path='doc/member[@name="DLLVERSIONINFO"]/*' />
public partial struct DLLVERSIONINFO
{
    /// <include file='DLLVERSIONINFO.xml' path='doc/member[@name="DLLVERSIONINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='DLLVERSIONINFO.xml' path='doc/member[@name="DLLVERSIONINFO.dwMajorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;

    /// <include file='DLLVERSIONINFO.xml' path='doc/member[@name="DLLVERSIONINFO.dwMinorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;

    /// <include file='DLLVERSIONINFO.xml' path='doc/member[@name="DLLVERSIONINFO.dwBuildNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBuildNumber;

    /// <include file='DLLVERSIONINFO.xml' path='doc/member[@name="DLLVERSIONINFO.dwPlatformID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPlatformID;
}
