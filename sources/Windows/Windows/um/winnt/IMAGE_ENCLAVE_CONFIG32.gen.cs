// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32"]/*'/>
[SupportedOSPlatform("windows10.0.16299.0")]
public unsafe partial struct IMAGE_ENCLAVE_CONFIG32
{
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.MinimumRequiredConfigSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MinimumRequiredConfigSize;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.PolicyFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PolicyFlags;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.NumberOfImports"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfImports;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.ImportList"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImportList;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.ImportEntrySize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImportEntrySize;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.FamilyID"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte FamilyID[16];
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.ImageID"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte ImageID[16];
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.ImageVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImageVersion;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.SecurityVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SecurityVersion;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.EnclaveSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EnclaveSize;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.NumberOfThreads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfThreads;
    /// <include file='IMAGE_ENCLAVE_CONFIG32.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG32.EnclaveFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EnclaveFlags;
}