// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE"]/*'/>
public unsafe partial struct CRYPT_RC4_KEY_STATE
{
    /// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE.Key"]/*'/>
    [NativeTypeName("unsigned char[16]")]
    public fixed byte Key[16];
    /// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE.SBox"]/*'/>
    [NativeTypeName("unsigned char[256]")]
    public fixed byte SBox[256];
    /// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE.i"]/*'/>
    [NativeTypeName("unsigned char")]
    public byte i;
    /// <include file='CRYPT_RC4_KEY_STATE.xml' path='doc/member[@name="CRYPT_RC4_KEY_STATE.j"]/*'/>
    [NativeTypeName("unsigned char")]
    public byte j;
}