// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE"]/*'/>
public enum KERB_PROTOCOL_MESSAGE_TYPE
{
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbDebugRequestMessage"]/*'/>
    KerbDebugRequestMessage = 0,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQueryTicketCacheMessage"]/*'/>
    KerbQueryTicketCacheMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbChangeMachinePasswordMessage"]/*'/>
    KerbChangeMachinePasswordMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbVerifyPacMessage"]/*'/>
    KerbVerifyPacMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbRetrieveTicketMessage"]/*'/>
    KerbRetrieveTicketMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbUpdateAddressesMessage"]/*'/>
    KerbUpdateAddressesMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbPurgeTicketCacheMessage"]/*'/>
    KerbPurgeTicketCacheMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbChangePasswordMessage"]/*'/>
    KerbChangePasswordMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbRetrieveEncodedTicketMessage"]/*'/>
    KerbRetrieveEncodedTicketMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbDecryptDataMessage"]/*'/>
    KerbDecryptDataMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbAddBindingCacheEntryMessage"]/*'/>
    KerbAddBindingCacheEntryMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbSetPasswordMessage"]/*'/>
    KerbSetPasswordMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbSetPasswordExMessage"]/*'/>
    KerbSetPasswordExMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbVerifyCredentialsMessage"]/*'/>
    KerbVerifyCredentialsMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQueryTicketCacheExMessage"]/*'/>
    KerbQueryTicketCacheExMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbPurgeTicketCacheExMessage"]/*'/>
    KerbPurgeTicketCacheExMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbRefreshSmartcardCredentialsMessage"]/*'/>
    KerbRefreshSmartcardCredentialsMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbAddExtraCredentialsMessage"]/*'/>
    KerbAddExtraCredentialsMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQuerySupplementalCredentialsMessage"]/*'/>
    KerbQuerySupplementalCredentialsMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbTransferCredentialsMessage"]/*'/>
    KerbTransferCredentialsMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQueryTicketCacheEx2Message"]/*'/>
    KerbQueryTicketCacheEx2Message,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbSubmitTicketMessage"]/*'/>
    KerbSubmitTicketMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbAddExtraCredentialsExMessage"]/*'/>
    KerbAddExtraCredentialsExMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQueryKdcProxyCacheMessage"]/*'/>
    KerbQueryKdcProxyCacheMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbPurgeKdcProxyCacheMessage"]/*'/>
    KerbPurgeKdcProxyCacheMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQueryTicketCacheEx3Message"]/*'/>
    KerbQueryTicketCacheEx3Message,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbCleanupMachinePkinitCredsMessage"]/*'/>
    KerbCleanupMachinePkinitCredsMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbAddBindingCacheEntryExMessage"]/*'/>
    KerbAddBindingCacheEntryExMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQueryBindingCacheMessage"]/*'/>
    KerbQueryBindingCacheMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbPurgeBindingCacheMessage"]/*'/>
    KerbPurgeBindingCacheMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbPinKdcMessage"]/*'/>
    KerbPinKdcMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbUnpinAllKdcsMessage"]/*'/>
    KerbUnpinAllKdcsMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQueryDomainExtendedPoliciesMessage"]/*'/>
    KerbQueryDomainExtendedPoliciesMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbQueryS4U2ProxyCacheMessage"]/*'/>
    KerbQueryS4U2ProxyCacheMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbRetrieveKeyTabMessage"]/*'/>
    KerbRetrieveKeyTabMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbRefreshPolicyMessage"]/*'/>
    KerbRefreshPolicyMessage,
    /// <include file='KERB_PROTOCOL_MESSAGE_TYPE.xml' path='doc/member[@name="KERB_PROTOCOL_MESSAGE_TYPE.KerbPrintCloudKerberosDebugMessage"]/*'/>
    KerbPrintCloudKerberosDebugMessage,
}