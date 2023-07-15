// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_CRYPTO_KEY32.xml' path='doc/member[@name="KERB_CRYPTO_KEY32"]/*'/>
public partial struct KERB_CRYPTO_KEY32
{
    /// <include file='KERB_CRYPTO_KEY32.xml' path='doc/member[@name="KERB_CRYPTO_KEY32.KeyType"]/*'/>
    [NativeTypeName("LONG")]
    public int KeyType;
    /// <include file='KERB_CRYPTO_KEY32.xml' path='doc/member[@name="KERB_CRYPTO_KEY32.Length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Length;
    /// <include file='KERB_CRYPTO_KEY32.xml' path='doc/member[@name="KERB_CRYPTO_KEY32.Offset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Offset;
}