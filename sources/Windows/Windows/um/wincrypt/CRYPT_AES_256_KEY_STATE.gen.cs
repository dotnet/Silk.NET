// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE"]/*'/>
public unsafe partial struct CRYPT_AES_256_KEY_STATE
{
    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.Key"]/*'/>
    [NativeTypeName("unsigned char[32]")]
    public fixed byte Key[32];
    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.IV"]/*'/>
    [NativeTypeName("unsigned char[16]")]
    public fixed byte IV[16];
    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.EncryptionState"]/*'/>
    [NativeTypeName("unsigned char[15][16]")]
    public fixed byte EncryptionState[15 * 16];
    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.DecryptionState"]/*'/>
    [NativeTypeName("unsigned char[15][16]")]
    public fixed byte DecryptionState[15 * 16];
    /// <include file='CRYPT_AES_256_KEY_STATE.xml' path='doc/member[@name="CRYPT_AES_256_KEY_STATE.Feedback"]/*'/>
    [NativeTypeName("unsigned char[16]")]
    public fixed byte Feedback[16];
}