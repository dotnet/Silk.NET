// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POLICY_AUDIT_LOG_INFO.xml' path='doc/member[@name="POLICY_AUDIT_LOG_INFO"]/*'/>
public partial struct POLICY_AUDIT_LOG_INFO
{
    /// <include file='POLICY_AUDIT_LOG_INFO.xml' path='doc/member[@name="POLICY_AUDIT_LOG_INFO.AuditLogPercentFull"]/*'/>
    [NativeTypeName("ULONG")]
    public uint AuditLogPercentFull;
    /// <include file='POLICY_AUDIT_LOG_INFO.xml' path='doc/member[@name="POLICY_AUDIT_LOG_INFO.MaximumLogSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaximumLogSize;
    /// <include file='POLICY_AUDIT_LOG_INFO.xml' path='doc/member[@name="POLICY_AUDIT_LOG_INFO.AuditRetentionPeriod"]/*'/>
    public LARGE_INTEGER AuditRetentionPeriod;
    /// <include file='POLICY_AUDIT_LOG_INFO.xml' path='doc/member[@name="POLICY_AUDIT_LOG_INFO.AuditLogFullShutdownInProgress"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AuditLogFullShutdownInProgress;
    /// <include file='POLICY_AUDIT_LOG_INFO.xml' path='doc/member[@name="POLICY_AUDIT_LOG_INFO.TimeToShutdown"]/*'/>
    public LARGE_INTEGER TimeToShutdown;
    /// <include file='POLICY_AUDIT_LOG_INFO.xml' path='doc/member[@name="POLICY_AUDIT_LOG_INFO.NextAuditRecordId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NextAuditRecordId;
}