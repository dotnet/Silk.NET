// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPGRAMMARSTATE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechGrammarState.xml' path='doc/member[@name="SpeechGrammarState"]/*'/>
public enum SpeechGrammarState
{
    /// <include file='SpeechGrammarState.xml' path='doc/member[@name="SpeechGrammarState.SGSEnabled"]/*'/>
    SGSEnabled = SPGS_ENABLED,
    /// <include file='SpeechGrammarState.xml' path='doc/member[@name="SpeechGrammarState.SGSDisabled"]/*'/>
    SGSDisabled = SPGS_DISABLED,
    /// <include file='SpeechGrammarState.xml' path='doc/member[@name="SpeechGrammarState.SGSExclusive"]/*'/>
    SGSExclusive = SPGS_EXCLUSIVE,
}