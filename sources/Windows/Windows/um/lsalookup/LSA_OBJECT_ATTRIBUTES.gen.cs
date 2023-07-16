// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LSA_OBJECT_ATTRIBUTES.xml' path='doc/member[@name="LSA_OBJECT_ATTRIBUTES"]/*'/>
public unsafe partial struct LSA_OBJECT_ATTRIBUTES
{
    /// <include file='LSA_OBJECT_ATTRIBUTES.xml' path='doc/member[@name="LSA_OBJECT_ATTRIBUTES.Length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Length;
    /// <include file='LSA_OBJECT_ATTRIBUTES.xml' path='doc/member[@name="LSA_OBJECT_ATTRIBUTES.RootDirectory"]/*'/>
    public HANDLE RootDirectory;
    /// <include file='LSA_OBJECT_ATTRIBUTES.xml' path='doc/member[@name="LSA_OBJECT_ATTRIBUTES.ObjectName"]/*'/>
    [NativeTypeName("PLSA_UNICODE_STRING")]
    public LSA_UNICODE_STRING* ObjectName;
    /// <include file='LSA_OBJECT_ATTRIBUTES.xml' path='doc/member[@name="LSA_OBJECT_ATTRIBUTES.Attributes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Attributes;
    /// <include file='LSA_OBJECT_ATTRIBUTES.xml' path='doc/member[@name="LSA_OBJECT_ATTRIBUTES.SecurityDescriptor"]/*'/>
    [NativeTypeName("PVOID")]
    public void* SecurityDescriptor;
    /// <include file='LSA_OBJECT_ATTRIBUTES.xml' path='doc/member[@name="LSA_OBJECT_ATTRIBUTES.SecurityQualityOfService"]/*'/>
    [NativeTypeName("PVOID")]
    public void* SecurityQualityOfService;
}