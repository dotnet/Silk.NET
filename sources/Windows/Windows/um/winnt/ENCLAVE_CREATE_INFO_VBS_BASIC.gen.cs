// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ENCLAVE_CREATE_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_CREATE_INFO_VBS_BASIC"]/*'/>
public unsafe partial struct ENCLAVE_CREATE_INFO_VBS_BASIC
{
    /// <include file='ENCLAVE_CREATE_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_CREATE_INFO_VBS_BASIC.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='ENCLAVE_CREATE_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_CREATE_INFO_VBS_BASIC.OwnerID"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte OwnerID[32];
}