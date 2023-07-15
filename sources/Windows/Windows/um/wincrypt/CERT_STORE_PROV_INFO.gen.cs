// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_STORE_PROV_INFO.xml' path='doc/member[@name="CERT_STORE_PROV_INFO"]/*'/>
public unsafe partial struct CERT_STORE_PROV_INFO
{
    /// <include file='CERT_STORE_PROV_INFO.xml' path='doc/member[@name="CERT_STORE_PROV_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_STORE_PROV_INFO.xml' path='doc/member[@name="CERT_STORE_PROV_INFO.cStoreProvFunc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cStoreProvFunc;
    /// <include file='CERT_STORE_PROV_INFO.xml' path='doc/member[@name="CERT_STORE_PROV_INFO.rgpvStoreProvFunc"]/*'/>
    public void** rgpvStoreProvFunc;
    /// <include file='CERT_STORE_PROV_INFO.xml' path='doc/member[@name="CERT_STORE_PROV_INFO.hStoreProv"]/*'/>
    public HCERTSTOREPROV hStoreProv;
    /// <include file='CERT_STORE_PROV_INFO.xml' path='doc/member[@name="CERT_STORE_PROV_INFO.dwStoreProvFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStoreProvFlags;
    /// <include file='CERT_STORE_PROV_INFO.xml' path='doc/member[@name="CERT_STORE_PROV_INFO.hStoreProvFuncAddr2"]/*'/>
    public HCRYPTOIDFUNCADDR hStoreProvFuncAddr2;
}