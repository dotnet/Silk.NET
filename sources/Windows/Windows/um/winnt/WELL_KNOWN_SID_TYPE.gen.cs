// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE"]/*'/>
public enum WELL_KNOWN_SID_TYPE
{
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinNullSid"]/*'/>
    WinNullSid = 0,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinWorldSid"]/*'/>
    WinWorldSid = 1,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinLocalSid"]/*'/>
    WinLocalSid = 2,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCreatorOwnerSid"]/*'/>
    WinCreatorOwnerSid = 3,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCreatorGroupSid"]/*'/>
    WinCreatorGroupSid = 4,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCreatorOwnerServerSid"]/*'/>
    WinCreatorOwnerServerSid = 5,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCreatorGroupServerSid"]/*'/>
    WinCreatorGroupServerSid = 6,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinNtAuthoritySid"]/*'/>
    WinNtAuthoritySid = 7,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinDialupSid"]/*'/>
    WinDialupSid = 8,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinNetworkSid"]/*'/>
    WinNetworkSid = 9,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBatchSid"]/*'/>
    WinBatchSid = 10,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinInteractiveSid"]/*'/>
    WinInteractiveSid = 11,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinServiceSid"]/*'/>
    WinServiceSid = 12,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAnonymousSid"]/*'/>
    WinAnonymousSid = 13,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinProxySid"]/*'/>
    WinProxySid = 14,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinEnterpriseControllersSid"]/*'/>
    WinEnterpriseControllersSid = 15,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinSelfSid"]/*'/>
    WinSelfSid = 16,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAuthenticatedUserSid"]/*'/>
    WinAuthenticatedUserSid = 17,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinRestrictedCodeSid"]/*'/>
    WinRestrictedCodeSid = 18,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinTerminalServerSid"]/*'/>
    WinTerminalServerSid = 19,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinRemoteLogonIdSid"]/*'/>
    WinRemoteLogonIdSid = 20,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinLogonIdsSid"]/*'/>
    WinLogonIdsSid = 21,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinLocalSystemSid"]/*'/>
    WinLocalSystemSid = 22,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinLocalServiceSid"]/*'/>
    WinLocalServiceSid = 23,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinNetworkServiceSid"]/*'/>
    WinNetworkServiceSid = 24,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinDomainSid"]/*'/>
    WinBuiltinDomainSid = 25,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinAdministratorsSid"]/*'/>
    WinBuiltinAdministratorsSid = 26,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinUsersSid"]/*'/>
    WinBuiltinUsersSid = 27,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinGuestsSid"]/*'/>
    WinBuiltinGuestsSid = 28,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinPowerUsersSid"]/*'/>
    WinBuiltinPowerUsersSid = 29,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinAccountOperatorsSid"]/*'/>
    WinBuiltinAccountOperatorsSid = 30,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinSystemOperatorsSid"]/*'/>
    WinBuiltinSystemOperatorsSid = 31,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinPrintOperatorsSid"]/*'/>
    WinBuiltinPrintOperatorsSid = 32,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinBackupOperatorsSid"]/*'/>
    WinBuiltinBackupOperatorsSid = 33,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinReplicatorSid"]/*'/>
    WinBuiltinReplicatorSid = 34,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinPreWindows2000CompatibleAccessSid"]/*'/>
    WinBuiltinPreWindows2000CompatibleAccessSid = 35,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinRemoteDesktopUsersSid"]/*'/>
    WinBuiltinRemoteDesktopUsersSid = 36,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinNetworkConfigurationOperatorsSid"]/*'/>
    WinBuiltinNetworkConfigurationOperatorsSid = 37,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountAdministratorSid"]/*'/>
    WinAccountAdministratorSid = 38,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountGuestSid"]/*'/>
    WinAccountGuestSid = 39,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountKrbtgtSid"]/*'/>
    WinAccountKrbtgtSid = 40,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountDomainAdminsSid"]/*'/>
    WinAccountDomainAdminsSid = 41,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountDomainUsersSid"]/*'/>
    WinAccountDomainUsersSid = 42,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountDomainGuestsSid"]/*'/>
    WinAccountDomainGuestsSid = 43,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountComputersSid"]/*'/>
    WinAccountComputersSid = 44,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountControllersSid"]/*'/>
    WinAccountControllersSid = 45,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountCertAdminsSid"]/*'/>
    WinAccountCertAdminsSid = 46,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountSchemaAdminsSid"]/*'/>
    WinAccountSchemaAdminsSid = 47,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountEnterpriseAdminsSid"]/*'/>
    WinAccountEnterpriseAdminsSid = 48,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountPolicyAdminsSid"]/*'/>
    WinAccountPolicyAdminsSid = 49,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountRasAndIasServersSid"]/*'/>
    WinAccountRasAndIasServersSid = 50,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinNTLMAuthenticationSid"]/*'/>
    WinNTLMAuthenticationSid = 51,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinDigestAuthenticationSid"]/*'/>
    WinDigestAuthenticationSid = 52,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinSChannelAuthenticationSid"]/*'/>
    WinSChannelAuthenticationSid = 53,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinThisOrganizationSid"]/*'/>
    WinThisOrganizationSid = 54,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinOtherOrganizationSid"]/*'/>
    WinOtherOrganizationSid = 55,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinIncomingForestTrustBuildersSid"]/*'/>
    WinBuiltinIncomingForestTrustBuildersSid = 56,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinPerfMonitoringUsersSid"]/*'/>
    WinBuiltinPerfMonitoringUsersSid = 57,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinPerfLoggingUsersSid"]/*'/>
    WinBuiltinPerfLoggingUsersSid = 58,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinAuthorizationAccessSid"]/*'/>
    WinBuiltinAuthorizationAccessSid = 59,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinTerminalServerLicenseServersSid"]/*'/>
    WinBuiltinTerminalServerLicenseServersSid = 60,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinDCOMUsersSid"]/*'/>
    WinBuiltinDCOMUsersSid = 61,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinIUsersSid"]/*'/>
    WinBuiltinIUsersSid = 62,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinIUserSid"]/*'/>
    WinIUserSid = 63,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinCryptoOperatorsSid"]/*'/>
    WinBuiltinCryptoOperatorsSid = 64,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinUntrustedLabelSid"]/*'/>
    WinUntrustedLabelSid = 65,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinLowLabelSid"]/*'/>
    WinLowLabelSid = 66,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinMediumLabelSid"]/*'/>
    WinMediumLabelSid = 67,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinHighLabelSid"]/*'/>
    WinHighLabelSid = 68,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinSystemLabelSid"]/*'/>
    WinSystemLabelSid = 69,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinWriteRestrictedCodeSid"]/*'/>
    WinWriteRestrictedCodeSid = 70,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCreatorOwnerRightsSid"]/*'/>
    WinCreatorOwnerRightsSid = 71,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCacheablePrincipalsGroupSid"]/*'/>
    WinCacheablePrincipalsGroupSid = 72,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinNonCacheablePrincipalsGroupSid"]/*'/>
    WinNonCacheablePrincipalsGroupSid = 73,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinEnterpriseReadonlyControllersSid"]/*'/>
    WinEnterpriseReadonlyControllersSid = 74,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountReadonlyControllersSid"]/*'/>
    WinAccountReadonlyControllersSid = 75,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinEventLogReadersGroup"]/*'/>
    WinBuiltinEventLogReadersGroup = 76,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinNewEnterpriseReadonlyControllersSid"]/*'/>
    WinNewEnterpriseReadonlyControllersSid = 77,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinCertSvcDComAccessGroup"]/*'/>
    WinBuiltinCertSvcDComAccessGroup = 78,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinMediumPlusLabelSid"]/*'/>
    WinMediumPlusLabelSid = 79,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinLocalLogonSid"]/*'/>
    WinLocalLogonSid = 80,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinConsoleLogonSid"]/*'/>
    WinConsoleLogonSid = 81,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinThisOrganizationCertificateSid"]/*'/>
    WinThisOrganizationCertificateSid = 82,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinApplicationPackageAuthoritySid"]/*'/>
    WinApplicationPackageAuthoritySid = 83,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinAnyPackageSid"]/*'/>
    WinBuiltinAnyPackageSid = 84,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityInternetClientSid"]/*'/>
    WinCapabilityInternetClientSid = 85,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityInternetClientServerSid"]/*'/>
    WinCapabilityInternetClientServerSid = 86,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityPrivateNetworkClientServerSid"]/*'/>
    WinCapabilityPrivateNetworkClientServerSid = 87,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityPicturesLibrarySid"]/*'/>
    WinCapabilityPicturesLibrarySid = 88,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityVideosLibrarySid"]/*'/>
    WinCapabilityVideosLibrarySid = 89,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityMusicLibrarySid"]/*'/>
    WinCapabilityMusicLibrarySid = 90,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityDocumentsLibrarySid"]/*'/>
    WinCapabilityDocumentsLibrarySid = 91,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilitySharedUserCertificatesSid"]/*'/>
    WinCapabilitySharedUserCertificatesSid = 92,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityEnterpriseAuthenticationSid"]/*'/>
    WinCapabilityEnterpriseAuthenticationSid = 93,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityRemovableStorageSid"]/*'/>
    WinCapabilityRemovableStorageSid = 94,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinRDSRemoteAccessServersSid"]/*'/>
    WinBuiltinRDSRemoteAccessServersSid = 95,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinRDSEndpointServersSid"]/*'/>
    WinBuiltinRDSEndpointServersSid = 96,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinRDSManagementServersSid"]/*'/>
    WinBuiltinRDSManagementServersSid = 97,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinUserModeDriversSid"]/*'/>
    WinUserModeDriversSid = 98,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinHyperVAdminsSid"]/*'/>
    WinBuiltinHyperVAdminsSid = 99,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountCloneableControllersSid"]/*'/>
    WinAccountCloneableControllersSid = 100,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinAccessControlAssistanceOperatorsSid"]/*'/>
    WinBuiltinAccessControlAssistanceOperatorsSid = 101,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinRemoteManagementUsersSid"]/*'/>
    WinBuiltinRemoteManagementUsersSid = 102,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAuthenticationAuthorityAssertedSid"]/*'/>
    WinAuthenticationAuthorityAssertedSid = 103,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAuthenticationServiceAssertedSid"]/*'/>
    WinAuthenticationServiceAssertedSid = 104,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinLocalAccountSid"]/*'/>
    WinLocalAccountSid = 105,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinLocalAccountAndAdministratorSid"]/*'/>
    WinLocalAccountAndAdministratorSid = 106,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountProtectedUsersSid"]/*'/>
    WinAccountProtectedUsersSid = 107,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityAppointmentsSid"]/*'/>
    WinCapabilityAppointmentsSid = 108,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinCapabilityContactsSid"]/*'/>
    WinCapabilityContactsSid = 109,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountDefaultSystemManagedSid"]/*'/>
    WinAccountDefaultSystemManagedSid = 110,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinDefaultSystemManagedGroupSid"]/*'/>
    WinBuiltinDefaultSystemManagedGroupSid = 111,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinStorageReplicaAdminsSid"]/*'/>
    WinBuiltinStorageReplicaAdminsSid = 112,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountKeyAdminsSid"]/*'/>
    WinAccountKeyAdminsSid = 113,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAccountEnterpriseKeyAdminsSid"]/*'/>
    WinAccountEnterpriseKeyAdminsSid = 114,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAuthenticationKeyTrustSid"]/*'/>
    WinAuthenticationKeyTrustSid = 115,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAuthenticationKeyPropertyMFASid"]/*'/>
    WinAuthenticationKeyPropertyMFASid = 116,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAuthenticationKeyPropertyAttestationSid"]/*'/>
    WinAuthenticationKeyPropertyAttestationSid = 117,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinAuthenticationFreshKeyAuthSid"]/*'/>
    WinAuthenticationFreshKeyAuthSid = 118,
    /// <include file='WELL_KNOWN_SID_TYPE.xml' path='doc/member[@name="WELL_KNOWN_SID_TYPE.WinBuiltinDeviceOwnersSid"]/*'/>
    WinBuiltinDeviceOwnersSid = 119,
}