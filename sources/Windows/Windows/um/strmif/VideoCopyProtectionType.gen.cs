// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VideoCopyProtectionType.xml' path='doc/member[@name="VideoCopyProtectionType"]/*'/>
public enum VideoCopyProtectionType
{
    /// <include file='VideoCopyProtectionType.xml' path='doc/member[@name="VideoCopyProtectionType.VideoCopyProtectionMacrovisionBasic"]/*'/>
    VideoCopyProtectionMacrovisionBasic = 0,
    /// <include file='VideoCopyProtectionType.xml' path='doc/member[@name="VideoCopyProtectionType.VideoCopyProtectionMacrovisionCBI"]/*'/>
    VideoCopyProtectionMacrovisionCBI = (VideoCopyProtectionMacrovisionBasic + 1),
}