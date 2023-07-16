// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EC_SUBSCRIPTION_DELIVERY_MODE.xml' path='doc/member[@name="EC_SUBSCRIPTION_DELIVERY_MODE"]/*'/>
public enum EC_SUBSCRIPTION_DELIVERY_MODE
{
    /// <include file='EC_SUBSCRIPTION_DELIVERY_MODE.xml' path='doc/member[@name="EC_SUBSCRIPTION_DELIVERY_MODE.EcDeliveryModePull"]/*'/>
    EcDeliveryModePull = 1,
    /// <include file='EC_SUBSCRIPTION_DELIVERY_MODE.xml' path='doc/member[@name="EC_SUBSCRIPTION_DELIVERY_MODE.EcDeliveryModePush"]/*'/>
    EcDeliveryModePush,
}