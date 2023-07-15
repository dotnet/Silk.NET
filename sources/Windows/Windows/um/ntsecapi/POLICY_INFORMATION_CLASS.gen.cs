// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS"]/*'/>
public enum POLICY_INFORMATION_CLASS
{
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyAuditLogInformation"]/*'/>
    PolicyAuditLogInformation = 1,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyAuditEventsInformation"]/*'/>
    PolicyAuditEventsInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyPrimaryDomainInformation"]/*'/>
    PolicyPrimaryDomainInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyPdAccountInformation"]/*'/>
    PolicyPdAccountInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyAccountDomainInformation"]/*'/>
    PolicyAccountDomainInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyLsaServerRoleInformation"]/*'/>
    PolicyLsaServerRoleInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyReplicaSourceInformation"]/*'/>
    PolicyReplicaSourceInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyDefaultQuotaInformation"]/*'/>
    PolicyDefaultQuotaInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyModificationInformation"]/*'/>
    PolicyModificationInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyAuditFullSetInformation"]/*'/>
    PolicyAuditFullSetInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyAuditFullQueryInformation"]/*'/>
    PolicyAuditFullQueryInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyDnsDomainInformation"]/*'/>
    PolicyDnsDomainInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyDnsDomainInformationInt"]/*'/>
    PolicyDnsDomainInformationInt,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyLocalAccountDomainInformation"]/*'/>
    PolicyLocalAccountDomainInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyMachineAccountInformation"]/*'/>
    PolicyMachineAccountInformation,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyMachineAccountInformation2"]/*'/>
    PolicyMachineAccountInformation2,
    /// <include file='POLICY_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_INFORMATION_CLASS.PolicyLastEntry"]/*'/>
    PolicyLastEntry,
}