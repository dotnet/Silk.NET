// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINTRUST_SGNR_INFO.xml' path='doc/member[@name="WINTRUST_SGNR_INFO"]/*'/>
public unsafe partial struct WINTRUST_SGNR_INFO
{
    /// <include file='WINTRUST_SGNR_INFO.xml' path='doc/member[@name="WINTRUST_SGNR_INFO.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='WINTRUST_SGNR_INFO.xml' path='doc/member[@name="WINTRUST_SGNR_INFO.pcwszDisplayName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszDisplayName;
    /// <include file='WINTRUST_SGNR_INFO.xml' path='doc/member[@name="WINTRUST_SGNR_INFO.psSignerInfo"]/*'/>
    public CMSG_SIGNER_INFO* psSignerInfo;
    /// <include file='WINTRUST_SGNR_INFO.xml' path='doc/member[@name="WINTRUST_SGNR_INFO.chStores"]/*'/>
    [NativeTypeName("DWORD")]
    public uint chStores;
    /// <include file='WINTRUST_SGNR_INFO.xml' path='doc/member[@name="WINTRUST_SGNR_INFO.pahStores"]/*'/>
    public HCERTSTORE* pahStores;
}