// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum INTERACTION_ID
{
    /// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID.INTERACTION_ID_NONE"]/*'/>
    INTERACTION_ID_NONE = 0x00000000,
    /// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID.INTERACTION_ID_MANIPULATION"]/*'/>
    INTERACTION_ID_MANIPULATION = 0x00000001,
    /// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID.INTERACTION_ID_TAP"]/*'/>
    INTERACTION_ID_TAP = 0x00000002,
    /// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID.INTERACTION_ID_SECONDARY_TAP"]/*'/>
    INTERACTION_ID_SECONDARY_TAP = 0x00000003,
    /// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID.INTERACTION_ID_HOLD"]/*'/>
    INTERACTION_ID_HOLD = 0x00000004,
    /// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID.INTERACTION_ID_DRAG"]/*'/>
    INTERACTION_ID_DRAG = 0x00000005,
    /// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID.INTERACTION_ID_CROSS_SLIDE"]/*'/>
    INTERACTION_ID_CROSS_SLIDE = 0x00000006,
    /// <include file='INTERACTION_ID.xml' path='doc/member[@name="INTERACTION_ID.INTERACTION_ID_MAX"]/*'/>
    INTERACTION_ID_MAX = unchecked((int)(0xffffffff)),
}