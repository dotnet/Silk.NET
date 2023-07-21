// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_OID_FUNC_ENTRY.xml' path='doc/member[@name="CRYPT_OID_FUNC_ENTRY"]/*' />
public unsafe partial struct CRYPT_OID_FUNC_ENTRY
{
    /// <include file='CRYPT_OID_FUNC_ENTRY.xml' path='doc/member[@name="CRYPT_OID_FUNC_ENTRY.pszOID"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszOID;

    /// <include file='CRYPT_OID_FUNC_ENTRY.xml' path='doc/member[@name="CRYPT_OID_FUNC_ENTRY.pvFuncAddr"]/*' />
    public void* pvFuncAddr;
}
