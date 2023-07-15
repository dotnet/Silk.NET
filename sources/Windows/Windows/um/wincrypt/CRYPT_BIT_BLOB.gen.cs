// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_BIT_BLOB.xml' path='doc/member[@name="CRYPT_BIT_BLOB"]/*'/>
public unsafe partial struct CRYPT_BIT_BLOB
{
    /// <include file='CRYPT_BIT_BLOB.xml' path='doc/member[@name="CRYPT_BIT_BLOB.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='CRYPT_BIT_BLOB.xml' path='doc/member[@name="CRYPT_BIT_BLOB.pbData"]/*'/>
    public byte* pbData;
    /// <include file='CRYPT_BIT_BLOB.xml' path='doc/member[@name="CRYPT_BIT_BLOB.cUnusedBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cUnusedBits;
}