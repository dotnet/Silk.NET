// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID"]/*'/>
public enum EC_SUBSCRIPTION_PROPERTY_ID
{
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionEnabled"]/*'/>
    EcSubscriptionEnabled = 0,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionEventSources"]/*'/>
    EcSubscriptionEventSources,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionEventSourceAddress"]/*'/>
    EcSubscriptionEventSourceAddress,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionEventSourceEnabled"]/*'/>
    EcSubscriptionEventSourceEnabled,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionEventSourceUserName"]/*'/>
    EcSubscriptionEventSourceUserName,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionEventSourcePassword"]/*'/>
    EcSubscriptionEventSourcePassword,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionDescription"]/*'/>
    EcSubscriptionDescription,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionURI"]/*'/>
    EcSubscriptionURI,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionConfigurationMode"]/*'/>
    EcSubscriptionConfigurationMode,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionExpires"]/*'/>
    EcSubscriptionExpires,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionQuery"]/*'/>
    EcSubscriptionQuery,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionTransportName"]/*'/>
    EcSubscriptionTransportName,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionTransportPort"]/*'/>
    EcSubscriptionTransportPort,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionDeliveryMode"]/*'/>
    EcSubscriptionDeliveryMode,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionDeliveryMaxItems"]/*'/>
    EcSubscriptionDeliveryMaxItems,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionDeliveryMaxLatencyTime"]/*'/>
    EcSubscriptionDeliveryMaxLatencyTime,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionHeartbeatInterval"]/*'/>
    EcSubscriptionHeartbeatInterval,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionLocale"]/*'/>
    EcSubscriptionLocale,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionContentFormat"]/*'/>
    EcSubscriptionContentFormat,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionLogFile"]/*'/>
    EcSubscriptionLogFile,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionPublisherName"]/*'/>
    EcSubscriptionPublisherName,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionCredentialsType"]/*'/>
    EcSubscriptionCredentialsType,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionCommonUserName"]/*'/>
    EcSubscriptionCommonUserName,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionCommonPassword"]/*'/>
    EcSubscriptionCommonPassword,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionHostName"]/*'/>
    EcSubscriptionHostName,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionReadExistingEvents"]/*'/>
    EcSubscriptionReadExistingEvents,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionDialect"]/*'/>
    EcSubscriptionDialect,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionType"]/*'/>
    EcSubscriptionType,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionAllowedIssuerCAs"]/*'/>
    EcSubscriptionAllowedIssuerCAs,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionAllowedSubjects"]/*'/>
    EcSubscriptionAllowedSubjects,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionDeniedSubjects"]/*'/>
    EcSubscriptionDeniedSubjects,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionAllowedSourceDomainComputers"]/*'/>
    EcSubscriptionAllowedSourceDomainComputers,
    /// <include file='EC_SUBSCRIPTION_PROPERTY_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_PROPERTY_ID.EcSubscriptionPropertyIdEND"]/*'/>
    EcSubscriptionPropertyIdEND,
}