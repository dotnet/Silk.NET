// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_ENCODE_PARA.xml' path='doc/member[@name="CRYPT_ENCODE_PARA"]/*'/>
public unsafe partial struct CRYPT_ENCODE_PARA
{
    /// <include file='CRYPT_ENCODE_PARA.xml' path='doc/member[@name="CRYPT_ENCODE_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_ENCODE_PARA.xml' path='doc/member[@name="CRYPT_ENCODE_PARA.pfnAlloc"]/*'/>
    [NativeTypeName("PFN_CRYPT_ALLOC")]
    public delegate* unmanaged<nuint, void*> pfnAlloc;
    /// <include file='CRYPT_ENCODE_PARA.xml' path='doc/member[@name="CRYPT_ENCODE_PARA.pfnFree"]/*'/>
    [NativeTypeName("PFN_CRYPT_FREE")]
    public delegate* unmanaged<void*, void> pfnFree;
}