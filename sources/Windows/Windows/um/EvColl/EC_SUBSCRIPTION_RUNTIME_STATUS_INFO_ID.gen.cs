// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID"]/*' />
public enum EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID
{
    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.EcSubscriptionRunTimeStatusActive"]/*' />
    EcSubscriptionRunTimeStatusActive = 0,

    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.EcSubscriptionRunTimeStatusLastError"]/*' />
    EcSubscriptionRunTimeStatusLastError,

    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.EcSubscriptionRunTimeStatusLastErrorMessage"]/*' />
    EcSubscriptionRunTimeStatusLastErrorMessage,

    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.EcSubscriptionRunTimeStatusLastErrorTime"]/*' />
    EcSubscriptionRunTimeStatusLastErrorTime,

    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.EcSubscriptionRunTimeStatusNextRetryTime"]/*' />
    EcSubscriptionRunTimeStatusNextRetryTime,

    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.EcSubscriptionRunTimeStatusEventSources"]/*' />
    EcSubscriptionRunTimeStatusEventSources,

    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.EcSubscriptionRunTimeStatusLastHeartbeatTime"]/*' />
    EcSubscriptionRunTimeStatusLastHeartbeatTime,

    /// <include file='EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.xml' path='doc/member[@name="EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID.EcSubscriptionRunTimeStatusInfoIdEND"]/*' />
    EcSubscriptionRunTimeStatusInfoIdEND,
}
