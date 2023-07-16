// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT"]/*'/>
[SupportedOSPlatform("windows10.0.16299.0")]
public unsafe partial struct IMAGE_ENCLAVE_IMPORT
{
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.MatchType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MatchType;
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.MinimumSecurityVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MinimumSecurityVersion;
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.UniqueOrAuthorID"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte UniqueOrAuthorID[32];
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.FamilyID"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte FamilyID[16];
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.ImageID"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte ImageID[16];
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.ImportName"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImportName;
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}