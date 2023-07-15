// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CREDENTIAL_PROVIDER_USAGE_SCENARIO.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_USAGE_SCENARIO"]/*'/>
public enum CREDENTIAL_PROVIDER_USAGE_SCENARIO
{
    /// <include file='CREDENTIAL_PROVIDER_USAGE_SCENARIO.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_USAGE_SCENARIO.CPUS_INVALID"]/*'/>
    CPUS_INVALID = 0,
    /// <include file='CREDENTIAL_PROVIDER_USAGE_SCENARIO.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_USAGE_SCENARIO.CPUS_LOGON"]/*'/>
    CPUS_LOGON = (CPUS_INVALID + 1),
    /// <include file='CREDENTIAL_PROVIDER_USAGE_SCENARIO.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_USAGE_SCENARIO.CPUS_UNLOCK_WORKSTATION"]/*'/>
    CPUS_UNLOCK_WORKSTATION = (CPUS_LOGON + 1),
    /// <include file='CREDENTIAL_PROVIDER_USAGE_SCENARIO.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_USAGE_SCENARIO.CPUS_CHANGE_PASSWORD"]/*'/>
    CPUS_CHANGE_PASSWORD = (CPUS_UNLOCK_WORKSTATION + 1),
    /// <include file='CREDENTIAL_PROVIDER_USAGE_SCENARIO.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_USAGE_SCENARIO.CPUS_CREDUI"]/*'/>
    CPUS_CREDUI = (CPUS_CHANGE_PASSWORD + 1),
    /// <include file='CREDENTIAL_PROVIDER_USAGE_SCENARIO.xml' path='doc/member[@name="CREDENTIAL_PROVIDER_USAGE_SCENARIO.CPUS_PLAP"]/*'/>
    CPUS_PLAP = (CPUS_CREDUI + 1),
}