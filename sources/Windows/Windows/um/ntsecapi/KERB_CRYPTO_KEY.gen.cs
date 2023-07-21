// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KERB_CRYPTO_KEY.xml' path='doc/member[@name="KERB_CRYPTO_KEY"]/*' />
public unsafe partial struct KERB_CRYPTO_KEY
{
    /// <include file='KERB_CRYPTO_KEY.xml' path='doc/member[@name="KERB_CRYPTO_KEY.KeyType"]/*' />
    [NativeTypeName("LONG")]
    public int KeyType;

    /// <include file='KERB_CRYPTO_KEY.xml' path='doc/member[@name="KERB_CRYPTO_KEY.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='KERB_CRYPTO_KEY.xml' path='doc/member[@name="KERB_CRYPTO_KEY.Value"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* Value;
}
