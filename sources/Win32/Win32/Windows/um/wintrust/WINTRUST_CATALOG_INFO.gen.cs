// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WINTRUST_CATALOG_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwCatalogVersion;

    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszCatalogFilePath;

    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszMemberTag;

    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszMemberFilePath;
    public HANDLE hMemberFile;
    public byte* pbCalculatedFileHash;

    [NativeTypeName("DWORD")]
    public uint cbCalculatedFileHash;

    [NativeTypeName("PCCTL_CONTEXT")]
    public CTL_CONTEXT* pcCatalogContext;
    public HCATADMIN hCatAdmin;
}
