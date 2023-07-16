// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.Windows;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "Audit_System_SecurityStateChange"/> property is correct.</summary>
    [Test]
    public static void Audit_System_SecurityStateChangeTest()
    {
        Assert.That(Audit_System_SecurityStateChange, Is.EqualTo(new Guid(0x0cce9210, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_System_SecuritySubsystemExtension"/> property is correct.</summary>
    [Test]
    public static void Audit_System_SecuritySubsystemExtensionTest()
    {
        Assert.That(Audit_System_SecuritySubsystemExtension, Is.EqualTo(new Guid(0x0cce9211, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_System_Integrity"/> property is correct.</summary>
    [Test]
    public static void Audit_System_IntegrityTest()
    {
        Assert.That(Audit_System_Integrity, Is.EqualTo(new Guid(0x0cce9212, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_System_IPSecDriverEvents"/> property is correct.</summary>
    [Test]
    public static void Audit_System_IPSecDriverEventsTest()
    {
        Assert.That(Audit_System_IPSecDriverEvents, Is.EqualTo(new Guid(0x0cce9213, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_System_Others"/> property is correct.</summary>
    [Test]
    public static void Audit_System_OthersTest()
    {
        Assert.That(Audit_System_Others, Is.EqualTo(new Guid(0x0cce9214, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_Logon"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_LogonTest()
    {
        Assert.That(Audit_Logon_Logon, Is.EqualTo(new Guid(0x0cce9215, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_Logoff"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_LogoffTest()
    {
        Assert.That(Audit_Logon_Logoff, Is.EqualTo(new Guid(0x0cce9216, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_AccountLockout"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_AccountLockoutTest()
    {
        Assert.That(Audit_Logon_AccountLockout, Is.EqualTo(new Guid(0x0cce9217, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_IPSecMainMode"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_IPSecMainModeTest()
    {
        Assert.That(Audit_Logon_IPSecMainMode, Is.EqualTo(new Guid(0x0cce9218, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_IPSecQuickMode"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_IPSecQuickModeTest()
    {
        Assert.That(Audit_Logon_IPSecQuickMode, Is.EqualTo(new Guid(0x0cce9219, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_IPSecUserMode"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_IPSecUserModeTest()
    {
        Assert.That(Audit_Logon_IPSecUserMode, Is.EqualTo(new Guid(0x0cce921a, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_SpecialLogon"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_SpecialLogonTest()
    {
        Assert.That(Audit_Logon_SpecialLogon, Is.EqualTo(new Guid(0x0cce921b, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_Others"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_OthersTest()
    {
        Assert.That(Audit_Logon_Others, Is.EqualTo(new Guid(0x0cce921c, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_FileSystem"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_FileSystemTest()
    {
        Assert.That(Audit_ObjectAccess_FileSystem, Is.EqualTo(new Guid(0x0cce921d, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_Registry"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_RegistryTest()
    {
        Assert.That(Audit_ObjectAccess_Registry, Is.EqualTo(new Guid(0x0cce921e, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_Kernel"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_KernelTest()
    {
        Assert.That(Audit_ObjectAccess_Kernel, Is.EqualTo(new Guid(0x0cce921f, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_Sam"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_SamTest()
    {
        Assert.That(Audit_ObjectAccess_Sam, Is.EqualTo(new Guid(0x0cce9220, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_CertificationServices"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_CertificationServicesTest()
    {
        Assert.That(Audit_ObjectAccess_CertificationServices, Is.EqualTo(new Guid(0x0cce9221, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_ApplicationGenerated"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_ApplicationGeneratedTest()
    {
        Assert.That(Audit_ObjectAccess_ApplicationGenerated, Is.EqualTo(new Guid(0x0cce9222, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_Handle"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_HandleTest()
    {
        Assert.That(Audit_ObjectAccess_Handle, Is.EqualTo(new Guid(0x0cce9223, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_Share"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_ShareTest()
    {
        Assert.That(Audit_ObjectAccess_Share, Is.EqualTo(new Guid(0x0cce9224, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_FirewallPacketDrops"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_FirewallPacketDropsTest()
    {
        Assert.That(Audit_ObjectAccess_FirewallPacketDrops, Is.EqualTo(new Guid(0x0cce9225, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_FirewallConnection"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_FirewallConnectionTest()
    {
        Assert.That(Audit_ObjectAccess_FirewallConnection, Is.EqualTo(new Guid(0x0cce9226, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_Other"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_OtherTest()
    {
        Assert.That(Audit_ObjectAccess_Other, Is.EqualTo(new Guid(0x0cce9227, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PrivilegeUse_Sensitive"/> property is correct.</summary>
    [Test]
    public static void Audit_PrivilegeUse_SensitiveTest()
    {
        Assert.That(Audit_PrivilegeUse_Sensitive, Is.EqualTo(new Guid(0x0cce9228, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PrivilegeUse_NonSensitive"/> property is correct.</summary>
    [Test]
    public static void Audit_PrivilegeUse_NonSensitiveTest()
    {
        Assert.That(Audit_PrivilegeUse_NonSensitive, Is.EqualTo(new Guid(0x0cce9229, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PrivilegeUse_Others"/> property is correct.</summary>
    [Test]
    public static void Audit_PrivilegeUse_OthersTest()
    {
        Assert.That(Audit_PrivilegeUse_Others, Is.EqualTo(new Guid(0x0cce922a, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DetailedTracking_ProcessCreation"/> property is correct.</summary>
    [Test]
    public static void Audit_DetailedTracking_ProcessCreationTest()
    {
        Assert.That(Audit_DetailedTracking_ProcessCreation, Is.EqualTo(new Guid(0x0cce922b, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DetailedTracking_ProcessTermination"/> property is correct.</summary>
    [Test]
    public static void Audit_DetailedTracking_ProcessTerminationTest()
    {
        Assert.That(Audit_DetailedTracking_ProcessTermination, Is.EqualTo(new Guid(0x0cce922c, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DetailedTracking_DpapiActivity"/> property is correct.</summary>
    [Test]
    public static void Audit_DetailedTracking_DpapiActivityTest()
    {
        Assert.That(Audit_DetailedTracking_DpapiActivity, Is.EqualTo(new Guid(0x0cce922d, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DetailedTracking_RpcCall"/> property is correct.</summary>
    [Test]
    public static void Audit_DetailedTracking_RpcCallTest()
    {
        Assert.That(Audit_DetailedTracking_RpcCall, Is.EqualTo(new Guid(0x0cce922e, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PolicyChange_AuditPolicy"/> property is correct.</summary>
    [Test]
    public static void Audit_PolicyChange_AuditPolicyTest()
    {
        Assert.That(Audit_PolicyChange_AuditPolicy, Is.EqualTo(new Guid(0x0cce922f, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PolicyChange_AuthenticationPolicy"/> property is correct.</summary>
    [Test]
    public static void Audit_PolicyChange_AuthenticationPolicyTest()
    {
        Assert.That(Audit_PolicyChange_AuthenticationPolicy, Is.EqualTo(new Guid(0x0cce9230, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PolicyChange_AuthorizationPolicy"/> property is correct.</summary>
    [Test]
    public static void Audit_PolicyChange_AuthorizationPolicyTest()
    {
        Assert.That(Audit_PolicyChange_AuthorizationPolicy, Is.EqualTo(new Guid(0x0cce9231, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PolicyChange_MpsscvRulePolicy"/> property is correct.</summary>
    [Test]
    public static void Audit_PolicyChange_MpsscvRulePolicyTest()
    {
        Assert.That(Audit_PolicyChange_MpsscvRulePolicy, Is.EqualTo(new Guid(0x0cce9232, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PolicyChange_WfpIPSecPolicy"/> property is correct.</summary>
    [Test]
    public static void Audit_PolicyChange_WfpIPSecPolicyTest()
    {
        Assert.That(Audit_PolicyChange_WfpIPSecPolicy, Is.EqualTo(new Guid(0x0cce9233, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PolicyChange_Others"/> property is correct.</summary>
    [Test]
    public static void Audit_PolicyChange_OthersTest()
    {
        Assert.That(Audit_PolicyChange_Others, Is.EqualTo(new Guid(0x0cce9234, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountManagement_UserAccount"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountManagement_UserAccountTest()
    {
        Assert.That(Audit_AccountManagement_UserAccount, Is.EqualTo(new Guid(0x0cce9235, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountManagement_ComputerAccount"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountManagement_ComputerAccountTest()
    {
        Assert.That(Audit_AccountManagement_ComputerAccount, Is.EqualTo(new Guid(0x0cce9236, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountManagement_SecurityGroup"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountManagement_SecurityGroupTest()
    {
        Assert.That(Audit_AccountManagement_SecurityGroup, Is.EqualTo(new Guid(0x0cce9237, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountManagement_DistributionGroup"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountManagement_DistributionGroupTest()
    {
        Assert.That(Audit_AccountManagement_DistributionGroup, Is.EqualTo(new Guid(0x0cce9238, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountManagement_ApplicationGroup"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountManagement_ApplicationGroupTest()
    {
        Assert.That(Audit_AccountManagement_ApplicationGroup, Is.EqualTo(new Guid(0x0cce9239, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountManagement_Others"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountManagement_OthersTest()
    {
        Assert.That(Audit_AccountManagement_Others, Is.EqualTo(new Guid(0x0cce923a, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DSAccess_DSAccess"/> property is correct.</summary>
    [Test]
    public static void Audit_DSAccess_DSAccessTest()
    {
        Assert.That(Audit_DSAccess_DSAccess, Is.EqualTo(new Guid(0x0cce923b, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DsAccess_AdAuditChanges"/> property is correct.</summary>
    [Test]
    public static void Audit_DsAccess_AdAuditChangesTest()
    {
        Assert.That(Audit_DsAccess_AdAuditChanges, Is.EqualTo(new Guid(0x0cce923c, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Ds_Replication"/> property is correct.</summary>
    [Test]
    public static void Audit_Ds_ReplicationTest()
    {
        Assert.That(Audit_Ds_Replication, Is.EqualTo(new Guid(0x0cce923d, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Ds_DetailedReplication"/> property is correct.</summary>
    [Test]
    public static void Audit_Ds_DetailedReplicationTest()
    {
        Assert.That(Audit_Ds_DetailedReplication, Is.EqualTo(new Guid(0x0cce923e, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountLogon_CredentialValidation"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountLogon_CredentialValidationTest()
    {
        Assert.That(Audit_AccountLogon_CredentialValidation, Is.EqualTo(new Guid(0x0cce923f, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountLogon_Kerberos"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountLogon_KerberosTest()
    {
        Assert.That(Audit_AccountLogon_Kerberos, Is.EqualTo(new Guid(0x0cce9240, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountLogon_Others"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountLogon_OthersTest()
    {
        Assert.That(Audit_AccountLogon_Others, Is.EqualTo(new Guid(0x0cce9241, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountLogon_KerbCredentialValidation"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountLogon_KerbCredentialValidationTest()
    {
        Assert.That(Audit_AccountLogon_KerbCredentialValidation, Is.EqualTo(new Guid(0x0cce9242, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_NPS"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_NPSTest()
    {
        Assert.That(Audit_Logon_NPS, Is.EqualTo(new Guid(0x0cce9243, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_DetailedFileShare"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_DetailedFileShareTest()
    {
        Assert.That(Audit_ObjectAccess_DetailedFileShare, Is.EqualTo(new Guid(0x0cce9244, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_RemovableStorage"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_RemovableStorageTest()
    {
        Assert.That(Audit_ObjectAccess_RemovableStorage, Is.EqualTo(new Guid(0x0cce9245, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess_CbacStaging"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccess_CbacStagingTest()
    {
        Assert.That(Audit_ObjectAccess_CbacStaging, Is.EqualTo(new Guid(0x0cce9246, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_Claims"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_ClaimsTest()
    {
        Assert.That(Audit_Logon_Claims, Is.EqualTo(new Guid(0x0cce9247, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DetailedTracking_PnpActivity"/> property is correct.</summary>
    [Test]
    public static void Audit_DetailedTracking_PnpActivityTest()
    {
        Assert.That(Audit_DetailedTracking_PnpActivity, Is.EqualTo(new Guid(0x0cce9248, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon_Groups"/> property is correct.</summary>
    [Test]
    public static void Audit_Logon_GroupsTest()
    {
        Assert.That(Audit_Logon_Groups, Is.EqualTo(new Guid(0x0cce9249, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DetailedTracking_TokenRightAdjusted"/> property is correct.</summary>
    [Test]
    public static void Audit_DetailedTracking_TokenRightAdjustedTest()
    {
        Assert.That(Audit_DetailedTracking_TokenRightAdjusted, Is.EqualTo(new Guid(0x0cce924a, 0x69ae, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_System"/> property is correct.</summary>
    [Test]
    public static void Audit_SystemTest()
    {
        Assert.That(Audit_System, Is.EqualTo(new Guid(0x69979848, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_Logon"/> property is correct.</summary>
    [Test]
    public static void Audit_LogonTest()
    {
        Assert.That(Audit_Logon, Is.EqualTo(new Guid(0x69979849, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_ObjectAccess"/> property is correct.</summary>
    [Test]
    public static void Audit_ObjectAccessTest()
    {
        Assert.That(Audit_ObjectAccess, Is.EqualTo(new Guid(0x6997984a, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PrivilegeUse"/> property is correct.</summary>
    [Test]
    public static void Audit_PrivilegeUseTest()
    {
        Assert.That(Audit_PrivilegeUse, Is.EqualTo(new Guid(0x6997984b, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DetailedTracking"/> property is correct.</summary>
    [Test]
    public static void Audit_DetailedTrackingTest()
    {
        Assert.That(Audit_DetailedTracking, Is.EqualTo(new Guid(0x6997984c, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_PolicyChange"/> property is correct.</summary>
    [Test]
    public static void Audit_PolicyChangeTest()
    {
        Assert.That(Audit_PolicyChange, Is.EqualTo(new Guid(0x6997984d, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountManagement"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountManagementTest()
    {
        Assert.That(Audit_AccountManagement, Is.EqualTo(new Guid(0x6997984e, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_DirectoryServiceAccess"/> property is correct.</summary>
    [Test]
    public static void Audit_DirectoryServiceAccessTest()
    {
        Assert.That(Audit_DirectoryServiceAccess, Is.EqualTo(new Guid(0x6997984f, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "Audit_AccountLogon"/> property is correct.</summary>
    [Test]
    public static void Audit_AccountLogonTest()
    {
        Assert.That(Audit_AccountLogon, Is.EqualTo(new Guid(0x69979850, 0x797a, 0x11d9, 0xbe, 0xd3, 0x50, 0x50, 0x54, 0x50, 0x30, 0x30)));
    }
}