// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PKCS12_PBES2_EXPORT_PARAMS.xml' path='doc/member[@name="PKCS12_PBES2_EXPORT_PARAMS"]/*'/>
public unsafe partial struct PKCS12_PBES2_EXPORT_PARAMS
{
    /// <include file='PKCS12_PBES2_EXPORT_PARAMS.xml' path='doc/member[@name="PKCS12_PBES2_EXPORT_PARAMS.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='PKCS12_PBES2_EXPORT_PARAMS.xml' path='doc/member[@name="PKCS12_PBES2_EXPORT_PARAMS.hNcryptDescriptor"]/*'/>
    [NativeTypeName("PVOID")]
    public void* hNcryptDescriptor;
    /// <include file='PKCS12_PBES2_EXPORT_PARAMS.xml' path='doc/member[@name="PKCS12_PBES2_EXPORT_PARAMS.pwszPbes2Alg"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszPbes2Alg;
}