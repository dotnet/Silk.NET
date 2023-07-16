// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_REGISTRY_STORE_CLIENT_GPT_PARA.xml' path='doc/member[@name="CERT_REGISTRY_STORE_CLIENT_GPT_PARA"]/*'/>
public unsafe partial struct CERT_REGISTRY_STORE_CLIENT_GPT_PARA
{
    /// <include file='CERT_REGISTRY_STORE_CLIENT_GPT_PARA.xml' path='doc/member[@name="CERT_REGISTRY_STORE_CLIENT_GPT_PARA.hKeyBase"]/*'/>
    public HKEY hKeyBase;
    /// <include file='CERT_REGISTRY_STORE_CLIENT_GPT_PARA.xml' path='doc/member[@name="CERT_REGISTRY_STORE_CLIENT_GPT_PARA.pwszRegPath"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszRegPath;
}