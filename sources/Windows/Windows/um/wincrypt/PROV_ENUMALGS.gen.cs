// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROV_ENUMALGS.xml' path='doc/member[@name="PROV_ENUMALGS"]/*'/>
public unsafe partial struct PROV_ENUMALGS
{
    /// <include file='PROV_ENUMALGS.xml' path='doc/member[@name="PROV_ENUMALGS.aiAlgid"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint aiAlgid;
    /// <include file='PROV_ENUMALGS.xml' path='doc/member[@name="PROV_ENUMALGS.dwBitLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBitLen;
    /// <include file='PROV_ENUMALGS.xml' path='doc/member[@name="PROV_ENUMALGS.dwNameLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNameLen;
    /// <include file='PROV_ENUMALGS.xml' path='doc/member[@name="PROV_ENUMALGS.szName"]/*'/>
    [NativeTypeName("CHAR[20]")]
    public fixed sbyte szName[20];
}