// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EVENT_INFO_CLASS.xml' path='doc/member[@name="EVENT_INFO_CLASS"]/*'/>
public enum EVENT_INFO_CLASS
{
    /// <include file='EVENT_INFO_CLASS.xml' path='doc/member[@name="EVENT_INFO_CLASS.EventProviderBinaryTrackInfo"]/*'/>
    EventProviderBinaryTrackInfo,
    /// <include file='EVENT_INFO_CLASS.xml' path='doc/member[@name="EVENT_INFO_CLASS.EventProviderSetReserved1"]/*'/>
    EventProviderSetReserved1,
    /// <include file='EVENT_INFO_CLASS.xml' path='doc/member[@name="EVENT_INFO_CLASS.EventProviderSetTraits"]/*'/>
    EventProviderSetTraits,
    /// <include file='EVENT_INFO_CLASS.xml' path='doc/member[@name="EVENT_INFO_CLASS.EventProviderUseDescriptorType"]/*'/>
    EventProviderUseDescriptorType,
    /// <include file='EVENT_INFO_CLASS.xml' path='doc/member[@name="EVENT_INFO_CLASS.MaxEventInfo"]/*'/>
    MaxEventInfo,
}