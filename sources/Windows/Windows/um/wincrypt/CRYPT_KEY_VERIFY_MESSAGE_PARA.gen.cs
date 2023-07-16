// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_KEY_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_VERIFY_MESSAGE_PARA"]/*'/>
public partial struct CRYPT_KEY_VERIFY_MESSAGE_PARA
{
    /// <include file='CRYPT_KEY_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_VERIFY_MESSAGE_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_KEY_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_VERIFY_MESSAGE_PARA.dwMsgEncodingType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMsgEncodingType;
    /// <include file='CRYPT_KEY_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_KEY_VERIFY_MESSAGE_PARA.hCryptProv"]/*'/>
    public HCRYPTPROV_LEGACY hCryptProv;
}