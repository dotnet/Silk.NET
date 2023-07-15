// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MANIPULATION_RAILS_STATE.xml' path='doc/member[@name="MANIPULATION_RAILS_STATE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MANIPULATION_RAILS_STATE
{
    /// <include file='MANIPULATION_RAILS_STATE.xml' path='doc/member[@name="MANIPULATION_RAILS_STATE.MANIPULATION_RAILS_STATE_UNDECIDED"]/*'/>
    MANIPULATION_RAILS_STATE_UNDECIDED = 0x00000000,
    /// <include file='MANIPULATION_RAILS_STATE.xml' path='doc/member[@name="MANIPULATION_RAILS_STATE.MANIPULATION_RAILS_STATE_FREE"]/*'/>
    MANIPULATION_RAILS_STATE_FREE = 0x00000001,
    /// <include file='MANIPULATION_RAILS_STATE.xml' path='doc/member[@name="MANIPULATION_RAILS_STATE.MANIPULATION_RAILS_STATE_RAILED"]/*'/>
    MANIPULATION_RAILS_STATE_RAILED = 0x00000002,
    /// <include file='MANIPULATION_RAILS_STATE.xml' path='doc/member[@name="MANIPULATION_RAILS_STATE.MANIPULATION_RAILS_STATE_MAX"]/*'/>
    MANIPULATION_RAILS_STATE_MAX = unchecked((int)(0xffffffff)),
}