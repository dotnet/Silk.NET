// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_REGISTRY_STORE_ROAMING_PARA.xml' path='doc/member[@name="CERT_REGISTRY_STORE_ROAMING_PARA"]/*' />
public unsafe partial struct CERT_REGISTRY_STORE_ROAMING_PARA
{
    /// <include file='CERT_REGISTRY_STORE_ROAMING_PARA.xml' path='doc/member[@name="CERT_REGISTRY_STORE_ROAMING_PARA.hKey"]/*' />
    public HKEY hKey;

    /// <include file='CERT_REGISTRY_STORE_ROAMING_PARA.xml' path='doc/member[@name="CERT_REGISTRY_STORE_ROAMING_PARA.pwszStoreDirectory"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszStoreDirectory;
}
