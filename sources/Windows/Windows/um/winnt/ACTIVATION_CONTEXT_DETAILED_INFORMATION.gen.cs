// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION"]/*' />
public unsafe partial struct ACTIVATION_CONTEXT_DETAILED_INFORMATION
{
    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulFormatVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulFormatVersion;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulAssemblyCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulAssemblyCount;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulRootManifestPathType"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulRootManifestPathType;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulRootManifestPathChars"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulRootManifestPathChars;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulRootConfigurationPathType"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulRootConfigurationPathType;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulRootConfigurationPathChars"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulRootConfigurationPathChars;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulAppDirPathType"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulAppDirPathType;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.ulAppDirPathChars"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulAppDirPathChars;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.lpRootManifestPath"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpRootManifestPath;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.lpRootConfigurationPath"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpRootConfigurationPath;

    /// <include file='ACTIVATION_CONTEXT_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_DETAILED_INFORMATION.lpAppDirPath"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpAppDirPath;
}
