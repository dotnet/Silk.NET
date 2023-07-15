// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EC_SUBSCRIPTION_TYPE.xml' path='doc/member[@name="EC_SUBSCRIPTION_TYPE"]/*'/>
public enum EC_SUBSCRIPTION_TYPE
{
    /// <include file='EC_SUBSCRIPTION_TYPE.xml' path='doc/member[@name="EC_SUBSCRIPTION_TYPE.EcSubscriptionTypeSourceInitiated"]/*'/>
    EcSubscriptionTypeSourceInitiated = 0,
    /// <include file='EC_SUBSCRIPTION_TYPE.xml' path='doc/member[@name="EC_SUBSCRIPTION_TYPE.EcSubscriptionTypeCollectorInitiated"]/*'/>
    EcSubscriptionTypeCollectorInitiated = 1,
}