// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY"]/*'/>
public unsafe partial struct CENTRAL_ACCESS_POLICY_ENTRY
{
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.Name"]/*'/>
    public LSA_UNICODE_STRING Name;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.Description"]/*'/>
    public LSA_UNICODE_STRING Description;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.ChangeId"]/*'/>
    public LSA_UNICODE_STRING ChangeId;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.LengthAppliesTo"]/*'/>
    [NativeTypeName("ULONG")]
    public uint LengthAppliesTo;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.AppliesTo"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* AppliesTo;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.LengthSD"]/*'/>
    [NativeTypeName("ULONG")]
    public uint LengthSD;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.SD"]/*'/>
    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* SD;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.LengthStagedSD"]/*'/>
    [NativeTypeName("ULONG")]
    public uint LengthStagedSD;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.StagedSD"]/*'/>
    [NativeTypeName("PSECURITY_DESCRIPTOR")]
    public void* StagedSD;
    /// <include file='CENTRAL_ACCESS_POLICY_ENTRY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY_ENTRY.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
}