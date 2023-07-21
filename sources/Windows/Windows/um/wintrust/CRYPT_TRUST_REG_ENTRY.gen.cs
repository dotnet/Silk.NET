// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_TRUST_REG_ENTRY.xml' path='doc/member[@name="CRYPT_TRUST_REG_ENTRY"]/*' />
public unsafe partial struct CRYPT_TRUST_REG_ENTRY
{
    /// <include file='CRYPT_TRUST_REG_ENTRY.xml' path='doc/member[@name="CRYPT_TRUST_REG_ENTRY.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='CRYPT_TRUST_REG_ENTRY.xml' path='doc/member[@name="CRYPT_TRUST_REG_ENTRY.pwszDLLName"]/*' />
    [NativeTypeName("WCHAR *")]
    public ushort* pwszDLLName;

    /// <include file='CRYPT_TRUST_REG_ENTRY.xml' path='doc/member[@name="CRYPT_TRUST_REG_ENTRY.pwszFunctionName"]/*' />
    [NativeTypeName("WCHAR *")]
    public ushort* pwszFunctionName;
}
