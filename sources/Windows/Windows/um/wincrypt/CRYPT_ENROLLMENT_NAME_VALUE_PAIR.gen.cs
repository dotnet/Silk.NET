// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_ENROLLMENT_NAME_VALUE_PAIR.xml' path='doc/member[@name="CRYPT_ENROLLMENT_NAME_VALUE_PAIR"]/*' />
public unsafe partial struct CRYPT_ENROLLMENT_NAME_VALUE_PAIR
{
    /// <include file='CRYPT_ENROLLMENT_NAME_VALUE_PAIR.xml' path='doc/member[@name="CRYPT_ENROLLMENT_NAME_VALUE_PAIR.pwszName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszName;

    /// <include file='CRYPT_ENROLLMENT_NAME_VALUE_PAIR.xml' path='doc/member[@name="CRYPT_ENROLLMENT_NAME_VALUE_PAIR.pwszValue"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszValue;
}
