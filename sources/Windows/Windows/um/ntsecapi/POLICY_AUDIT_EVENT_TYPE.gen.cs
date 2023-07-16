// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE"]/*'/>
public enum POLICY_AUDIT_EVENT_TYPE
{
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategorySystem"]/*'/>
    AuditCategorySystem = 0,
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategoryLogon"]/*'/>
    AuditCategoryLogon,
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategoryObjectAccess"]/*'/>
    AuditCategoryObjectAccess,
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategoryPrivilegeUse"]/*'/>
    AuditCategoryPrivilegeUse,
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategoryDetailedTracking"]/*'/>
    AuditCategoryDetailedTracking,
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategoryPolicyChange"]/*'/>
    AuditCategoryPolicyChange,
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategoryAccountManagement"]/*'/>
    AuditCategoryAccountManagement,
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategoryDirectoryServiceAccess"]/*'/>
    AuditCategoryDirectoryServiceAccess,
    /// <include file='POLICY_AUDIT_EVENT_TYPE.xml' path='doc/member[@name="POLICY_AUDIT_EVENT_TYPE.AuditCategoryAccountLogon"]/*'/>
    AuditCategoryAccountLogon,
}