// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_DES_KEY_STATE.xml' path='doc/member[@name="CRYPT_DES_KEY_STATE"]/*'/>
public unsafe partial struct CRYPT_DES_KEY_STATE
{
    /// <include file='CRYPT_DES_KEY_STATE.xml' path='doc/member[@name="CRYPT_DES_KEY_STATE.Key"]/*'/>
    [NativeTypeName("unsigned char[8]")]
    public fixed byte Key[8];
    /// <include file='CRYPT_DES_KEY_STATE.xml' path='doc/member[@name="CRYPT_DES_KEY_STATE.IV"]/*'/>
    [NativeTypeName("unsigned char[8]")]
    public fixed byte IV[8];
    /// <include file='CRYPT_DES_KEY_STATE.xml' path='doc/member[@name="CRYPT_DES_KEY_STATE.Feedback"]/*'/>
    [NativeTypeName("unsigned char[8]")]
    public fixed byte Feedback[8];
}