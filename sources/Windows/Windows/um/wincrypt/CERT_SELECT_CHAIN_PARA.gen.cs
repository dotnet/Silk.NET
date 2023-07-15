// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_SELECT_CHAIN_PARA.xml' path='doc/member[@name="CERT_SELECT_CHAIN_PARA"]/*'/>
public unsafe partial struct CERT_SELECT_CHAIN_PARA
{
    /// <include file='CERT_SELECT_CHAIN_PARA.xml' path='doc/member[@name="CERT_SELECT_CHAIN_PARA.hChainEngine"]/*'/>
    public HCERTCHAINENGINE hChainEngine;
    /// <include file='CERT_SELECT_CHAIN_PARA.xml' path='doc/member[@name="CERT_SELECT_CHAIN_PARA.pTime"]/*'/>
    [NativeTypeName("PFILETIME")]
    public FILETIME* pTime;
    /// <include file='CERT_SELECT_CHAIN_PARA.xml' path='doc/member[@name="CERT_SELECT_CHAIN_PARA.hAdditionalStore"]/*'/>
    public HCERTSTORE hAdditionalStore;
    /// <include file='CERT_SELECT_CHAIN_PARA.xml' path='doc/member[@name="CERT_SELECT_CHAIN_PARA.pChainPara"]/*'/>
    [NativeTypeName("PCERT_CHAIN_PARA")]
    public CERT_CHAIN_PARA* pChainPara;
    /// <include file='CERT_SELECT_CHAIN_PARA.xml' path='doc/member[@name="CERT_SELECT_CHAIN_PARA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}