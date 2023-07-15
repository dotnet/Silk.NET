// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO"]/*'/>
public unsafe partial struct WINTRUST_CATALOG_INFO
{
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.dwCatalogVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCatalogVersion;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.pcwszCatalogFilePath"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszCatalogFilePath;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.pcwszMemberTag"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszMemberTag;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.pcwszMemberFilePath"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszMemberFilePath;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.hMemberFile"]/*'/>
    public HANDLE hMemberFile;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.pbCalculatedFileHash"]/*'/>
    public byte* pbCalculatedFileHash;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.cbCalculatedFileHash"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCalculatedFileHash;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.pcCatalogContext"]/*'/>
    [NativeTypeName("PCCTL_CONTEXT")]
    public CTL_CONTEXT* pcCatalogContext;
    /// <include file='WINTRUST_CATALOG_INFO.xml' path='doc/member[@name="WINTRUST_CATALOG_INFO.hCatAdmin"]/*'/>
    public HCATADMIN hCatAdmin;
}