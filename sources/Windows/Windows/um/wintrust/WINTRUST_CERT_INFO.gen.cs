// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINTRUST_CERT_INFO.xml' path='doc/member[@name="WINTRUST_CERT_INFO"]/*'/>
public unsafe partial struct WINTRUST_CERT_INFO
{
    /// <include file='WINTRUST_CERT_INFO.xml' path='doc/member[@name="WINTRUST_CERT_INFO.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='WINTRUST_CERT_INFO.xml' path='doc/member[@name="WINTRUST_CERT_INFO.pcwszDisplayName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszDisplayName;
    /// <include file='WINTRUST_CERT_INFO.xml' path='doc/member[@name="WINTRUST_CERT_INFO.psCertContext"]/*'/>
    public CERT_CONTEXT* psCertContext;
    /// <include file='WINTRUST_CERT_INFO.xml' path='doc/member[@name="WINTRUST_CERT_INFO.chStores"]/*'/>
    [NativeTypeName("DWORD")]
    public uint chStores;
    /// <include file='WINTRUST_CERT_INFO.xml' path='doc/member[@name="WINTRUST_CERT_INFO.pahStores"]/*'/>
    public HCERTSTORE* pahStores;
    /// <include file='WINTRUST_CERT_INFO.xml' path='doc/member[@name="WINTRUST_CERT_INFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='WINTRUST_CERT_INFO.xml' path='doc/member[@name="WINTRUST_CERT_INFO.psftVerifyAsOf"]/*'/>
    public FILETIME* psftVerifyAsOf;
}