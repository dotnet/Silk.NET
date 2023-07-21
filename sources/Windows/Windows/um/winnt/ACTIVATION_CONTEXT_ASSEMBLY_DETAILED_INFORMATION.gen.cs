// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION"]/*' />
public unsafe partial struct ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION
{
    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulFlags;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulEncodedAssemblyIdentityLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulEncodedAssemblyIdentityLength;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulManifestPathType"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulManifestPathType;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulManifestPathLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulManifestPathLength;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.liManifestLastWriteTime"]/*' />
    public LARGE_INTEGER liManifestLastWriteTime;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulPolicyPathType"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulPolicyPathType;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulPolicyPathLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulPolicyPathLength;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.liPolicyLastWriteTime"]/*' />
    public LARGE_INTEGER liPolicyLastWriteTime;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulMetadataSatelliteRosterIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulMetadataSatelliteRosterIndex;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulManifestVersionMajor"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulManifestVersionMajor;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulManifestVersionMinor"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulManifestVersionMinor;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulPolicyVersionMajor"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulPolicyVersionMajor;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulPolicyVersionMinor"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulPolicyVersionMinor;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulAssemblyDirectoryNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulAssemblyDirectoryNameLength;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.lpAssemblyEncodedAssemblyIdentity"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpAssemblyEncodedAssemblyIdentity;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.lpAssemblyManifestPath"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpAssemblyManifestPath;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.lpAssemblyPolicyPath"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpAssemblyPolicyPath;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.lpAssemblyDirectoryName"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* lpAssemblyDirectoryName;

    /// <include file='ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION.ulFileCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulFileCount;
}
