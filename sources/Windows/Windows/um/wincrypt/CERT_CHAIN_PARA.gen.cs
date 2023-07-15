// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_CHAIN_PARA.xml' path='doc/member[@name="CERT_CHAIN_PARA"]/*'/>
public partial struct CERT_CHAIN_PARA
{
    /// <include file='CERT_CHAIN_PARA.xml' path='doc/member[@name="CERT_CHAIN_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_CHAIN_PARA.xml' path='doc/member[@name="CERT_CHAIN_PARA.RequestedUsage"]/*'/>
    public CERT_USAGE_MATCH RequestedUsage;
}