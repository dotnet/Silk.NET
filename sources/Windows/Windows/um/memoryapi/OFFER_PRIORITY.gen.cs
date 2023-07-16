// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OFFER_PRIORITY.xml' path='doc/member[@name="OFFER_PRIORITY"]/*'/>
public enum OFFER_PRIORITY
{
    /// <include file='OFFER_PRIORITY.xml' path='doc/member[@name="OFFER_PRIORITY.VmOfferPriorityVeryLow"]/*'/>
    VmOfferPriorityVeryLow = 1,
    /// <include file='OFFER_PRIORITY.xml' path='doc/member[@name="OFFER_PRIORITY.VmOfferPriorityLow"]/*'/>
    VmOfferPriorityLow,
    /// <include file='OFFER_PRIORITY.xml' path='doc/member[@name="OFFER_PRIORITY.VmOfferPriorityBelowNormal"]/*'/>
    VmOfferPriorityBelowNormal,
    /// <include file='OFFER_PRIORITY.xml' path='doc/member[@name="OFFER_PRIORITY.VmOfferPriorityNormal"]/*'/>
    VmOfferPriorityNormal,
}