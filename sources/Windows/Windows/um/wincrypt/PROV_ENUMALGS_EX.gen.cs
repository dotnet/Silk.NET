// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX"]/*'/>
public unsafe partial struct PROV_ENUMALGS_EX
{
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.aiAlgid"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint aiAlgid;
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwDefaultLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDefaultLen;
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwMinLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinLen;
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwMaxLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxLen;
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwProtocols"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProtocols;
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwNameLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNameLen;
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.szName"]/*'/>
    [NativeTypeName("CHAR[20]")]
    public fixed sbyte szName[20];
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.dwLongNameLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLongNameLen;
    /// <include file='PROV_ENUMALGS_EX.xml' path='doc/member[@name="PROV_ENUMALGS_EX.szLongName"]/*'/>
    [NativeTypeName("CHAR[40]")]
    public fixed sbyte szLongName[40];
}