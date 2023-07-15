// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CENTRAL_ACCESS_POLICY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY"]/*'/>
public unsafe partial struct CENTRAL_ACCESS_POLICY
{
    /// <include file='CENTRAL_ACCESS_POLICY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY.CAPID"]/*'/>
    [NativeTypeName("PSID")]
    public void* CAPID;
    /// <include file='CENTRAL_ACCESS_POLICY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY.Name"]/*'/>
    public LSA_UNICODE_STRING Name;
    /// <include file='CENTRAL_ACCESS_POLICY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY.Description"]/*'/>
    public LSA_UNICODE_STRING Description;
    /// <include file='CENTRAL_ACCESS_POLICY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY.ChangeId"]/*'/>
    public LSA_UNICODE_STRING ChangeId;
    /// <include file='CENTRAL_ACCESS_POLICY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='CENTRAL_ACCESS_POLICY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY.CAPECount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CAPECount;
    /// <include file='CENTRAL_ACCESS_POLICY.xml' path='doc/member[@name="CENTRAL_ACCESS_POLICY.CAPEs"]/*'/>
    [NativeTypeName("PCENTRAL_ACCESS_POLICY_ENTRY *")]
    public CENTRAL_ACCESS_POLICY_ENTRY** CAPEs;
}