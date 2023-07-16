// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='POLICY_AUDIT_EVENTS_INFO.xml' path='doc/member[@name="POLICY_AUDIT_EVENTS_INFO"]/*'/>
public unsafe partial struct POLICY_AUDIT_EVENTS_INFO
{
    /// <include file='POLICY_AUDIT_EVENTS_INFO.xml' path='doc/member[@name="POLICY_AUDIT_EVENTS_INFO.AuditingMode"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AuditingMode;
    /// <include file='POLICY_AUDIT_EVENTS_INFO.xml' path='doc/member[@name="POLICY_AUDIT_EVENTS_INFO.EventAuditingOptions"]/*'/>
    [NativeTypeName("PPOLICY_AUDIT_EVENT_OPTIONS")]
    public uint* EventAuditingOptions;
    /// <include file='POLICY_AUDIT_EVENTS_INFO.xml' path='doc/member[@name="POLICY_AUDIT_EVENTS_INFO.MaximumAuditEventCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaximumAuditEventCount;
}