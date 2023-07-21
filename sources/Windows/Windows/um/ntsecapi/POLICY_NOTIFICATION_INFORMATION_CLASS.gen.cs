// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS"]/*' />
public enum POLICY_NOTIFICATION_INFORMATION_CLASS
{
    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyAuditEventsInformation"]/*' />
    PolicyNotifyAuditEventsInformation = 1,

    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyAccountDomainInformation"]/*' />
    PolicyNotifyAccountDomainInformation,

    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyServerRoleInformation"]/*' />
    PolicyNotifyServerRoleInformation,

    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyDnsDomainInformation"]/*' />
    PolicyNotifyDnsDomainInformation,

    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyDomainEfsInformation"]/*' />
    PolicyNotifyDomainEfsInformation,

    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyDomainKerberosTicketInformation"]/*' />
    PolicyNotifyDomainKerberosTicketInformation,

    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyMachineAccountPasswordInformation"]/*' />
    PolicyNotifyMachineAccountPasswordInformation,

    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyGlobalSaclInformation"]/*' />
    PolicyNotifyGlobalSaclInformation,

    /// <include file='POLICY_NOTIFICATION_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_NOTIFICATION_INFORMATION_CLASS.PolicyNotifyMax"]/*' />
    PolicyNotifyMax,
}
