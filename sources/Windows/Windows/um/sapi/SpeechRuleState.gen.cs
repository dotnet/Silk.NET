// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPRULESTATE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechRuleState.xml' path='doc/member[@name="SpeechRuleState"]/*'/>
public enum SpeechRuleState
{
    /// <include file='SpeechRuleState.xml' path='doc/member[@name="SpeechRuleState.SGDSInactive"]/*'/>
    SGDSInactive = SPRS_INACTIVE,
    /// <include file='SpeechRuleState.xml' path='doc/member[@name="SpeechRuleState.SGDSActive"]/*'/>
    SGDSActive = SPRS_ACTIVE,
    /// <include file='SpeechRuleState.xml' path='doc/member[@name="SpeechRuleState.SGDSActiveWithAutoPause"]/*'/>
    SGDSActiveWithAutoPause = SPRS_ACTIVE_WITH_AUTO_PAUSE,
    /// <include file='SpeechRuleState.xml' path='doc/member[@name="SpeechRuleState.SGDSActiveUserDelimited"]/*'/>
    SGDSActiveUserDelimited = SPRS_ACTIVE_USER_DELIMITED,
}