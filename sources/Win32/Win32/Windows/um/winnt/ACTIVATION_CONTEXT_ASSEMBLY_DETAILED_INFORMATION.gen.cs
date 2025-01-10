// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ACTIVATION_CONTEXT_ASSEMBLY_DETAILED_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint ulFlags;

    [NativeTypeName("DWORD")]
    public uint ulEncodedAssemblyIdentityLength;

    [NativeTypeName("DWORD")]
    public uint ulManifestPathType;

    [NativeTypeName("DWORD")]
    public uint ulManifestPathLength;
    public LARGE_INTEGER liManifestLastWriteTime;

    [NativeTypeName("DWORD")]
    public uint ulPolicyPathType;

    [NativeTypeName("DWORD")]
    public uint ulPolicyPathLength;
    public LARGE_INTEGER liPolicyLastWriteTime;

    [NativeTypeName("DWORD")]
    public uint ulMetadataSatelliteRosterIndex;

    [NativeTypeName("DWORD")]
    public uint ulManifestVersionMajor;

    [NativeTypeName("DWORD")]
    public uint ulManifestVersionMinor;

    [NativeTypeName("DWORD")]
    public uint ulPolicyVersionMajor;

    [NativeTypeName("DWORD")]
    public uint ulPolicyVersionMinor;

    [NativeTypeName("DWORD")]
    public uint ulAssemblyDirectoryNameLength;

    [NativeTypeName("PCWSTR")]
    public ushort* lpAssemblyEncodedAssemblyIdentity;

    [NativeTypeName("PCWSTR")]
    public ushort* lpAssemblyManifestPath;

    [NativeTypeName("PCWSTR")]
    public ushort* lpAssemblyPolicyPath;

    [NativeTypeName("PCWSTR")]
    public ushort* lpAssemblyDirectoryName;

    [NativeTypeName("DWORD")]
    public uint ulFileCount;
}
