// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_TOPOLOGY_ID.xml' path='doc/member[@name="DISPLAYCONFIG_TOPOLOGY_ID"]/*'/>
public enum DISPLAYCONFIG_TOPOLOGY_ID
{
    /// <include file='DISPLAYCONFIG_TOPOLOGY_ID.xml' path='doc/member[@name="DISPLAYCONFIG_TOPOLOGY_ID.DISPLAYCONFIG_TOPOLOGY_INTERNAL"]/*'/>
    DISPLAYCONFIG_TOPOLOGY_INTERNAL = 0x00000001,
    /// <include file='DISPLAYCONFIG_TOPOLOGY_ID.xml' path='doc/member[@name="DISPLAYCONFIG_TOPOLOGY_ID.DISPLAYCONFIG_TOPOLOGY_CLONE"]/*'/>
    DISPLAYCONFIG_TOPOLOGY_CLONE = 0x00000002,
    /// <include file='DISPLAYCONFIG_TOPOLOGY_ID.xml' path='doc/member[@name="DISPLAYCONFIG_TOPOLOGY_ID.DISPLAYCONFIG_TOPOLOGY_EXTEND"]/*'/>
    DISPLAYCONFIG_TOPOLOGY_EXTEND = 0x00000004,
    /// <include file='DISPLAYCONFIG_TOPOLOGY_ID.xml' path='doc/member[@name="DISPLAYCONFIG_TOPOLOGY_ID.DISPLAYCONFIG_TOPOLOGY_EXTERNAL"]/*'/>
    DISPLAYCONFIG_TOPOLOGY_EXTERNAL = 0x00000008,
    /// <include file='DISPLAYCONFIG_TOPOLOGY_ID.xml' path='doc/member[@name="DISPLAYCONFIG_TOPOLOGY_ID.DISPLAYCONFIG_TOPOLOGY_FORCE_UINT32"]/*'/>
    DISPLAYCONFIG_TOPOLOGY_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}