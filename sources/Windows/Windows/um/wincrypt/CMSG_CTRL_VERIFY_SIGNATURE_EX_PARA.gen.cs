// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.xml' path='doc/member[@name="CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA"]/*'/>
public unsafe partial struct CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA
{
    /// <include file='CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.xml' path='doc/member[@name="CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.xml' path='doc/member[@name="CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.hCryptProv"]/*'/>
    public HCRYPTPROV_LEGACY hCryptProv;
    /// <include file='CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.xml' path='doc/member[@name="CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.dwSignerIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignerIndex;
    /// <include file='CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.xml' path='doc/member[@name="CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.dwSignerType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignerType;
    /// <include file='CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.xml' path='doc/member[@name="CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA.pvSigner"]/*'/>
    public void* pvSigner;
}