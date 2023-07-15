// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='INTERACTION_STATE.xml' path='doc/member[@name="INTERACTION_STATE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum INTERACTION_STATE
{
    /// <include file='INTERACTION_STATE.xml' path='doc/member[@name="INTERACTION_STATE.INTERACTION_STATE_IDLE"]/*'/>
    INTERACTION_STATE_IDLE = 0x00000000,
    /// <include file='INTERACTION_STATE.xml' path='doc/member[@name="INTERACTION_STATE.INTERACTION_STATE_IN_INTERACTION"]/*'/>
    INTERACTION_STATE_IN_INTERACTION = 0x00000001,
    /// <include file='INTERACTION_STATE.xml' path='doc/member[@name="INTERACTION_STATE.INTERACTION_STATE_POSSIBLE_DOUBLE_TAP"]/*'/>
    INTERACTION_STATE_POSSIBLE_DOUBLE_TAP = 0x00000002,
    /// <include file='INTERACTION_STATE.xml' path='doc/member[@name="INTERACTION_STATE.INTERACTION_STATE_MAX"]/*'/>
    INTERACTION_STATE_MAX = unchecked((int)(0xffffffff)),
}