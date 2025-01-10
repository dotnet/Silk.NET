// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ACTIVATION_CONTEXT_DETAILED_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint ulFormatVersion;

    [NativeTypeName("DWORD")]
    public uint ulAssemblyCount;

    [NativeTypeName("DWORD")]
    public uint ulRootManifestPathType;

    [NativeTypeName("DWORD")]
    public uint ulRootManifestPathChars;

    [NativeTypeName("DWORD")]
    public uint ulRootConfigurationPathType;

    [NativeTypeName("DWORD")]
    public uint ulRootConfigurationPathChars;

    [NativeTypeName("DWORD")]
    public uint ulAppDirPathType;

    [NativeTypeName("DWORD")]
    public uint ulAppDirPathChars;

    [NativeTypeName("PCWSTR")]
    public ushort* lpRootManifestPath;

    [NativeTypeName("PCWSTR")]
    public ushort* lpRootConfigurationPath;

    [NativeTypeName("PCWSTR")]
    public ushort* lpAppDirPath;
}
