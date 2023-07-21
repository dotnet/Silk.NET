// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_TIMESTAMP_CONTEXT.xml' path='doc/member[@name="CRYPT_TIMESTAMP_CONTEXT"]/*' />
public unsafe partial struct CRYPT_TIMESTAMP_CONTEXT
{
    /// <include file='CRYPT_TIMESTAMP_CONTEXT.xml' path='doc/member[@name="CRYPT_TIMESTAMP_CONTEXT.cbEncoded"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbEncoded;

    /// <include file='CRYPT_TIMESTAMP_CONTEXT.xml' path='doc/member[@name="CRYPT_TIMESTAMP_CONTEXT.pbEncoded"]/*' />
    public byte* pbEncoded;

    /// <include file='CRYPT_TIMESTAMP_CONTEXT.xml' path='doc/member[@name="CRYPT_TIMESTAMP_CONTEXT.pTimeStamp"]/*' />
    [NativeTypeName("PCRYPT_TIMESTAMP_INFO")]
    public CRYPT_TIMESTAMP_INFO* pTimeStamp;
}
