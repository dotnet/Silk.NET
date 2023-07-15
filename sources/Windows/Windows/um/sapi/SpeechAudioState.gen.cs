// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPAUDIOSTATE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechAudioState.xml' path='doc/member[@name="SpeechAudioState"]/*'/>
public enum SpeechAudioState
{
    /// <include file='SpeechAudioState.xml' path='doc/member[@name="SpeechAudioState.SASClosed"]/*'/>
    SASClosed = SPAS_CLOSED,
    /// <include file='SpeechAudioState.xml' path='doc/member[@name="SpeechAudioState.SASStop"]/*'/>
    SASStop = SPAS_STOP,
    /// <include file='SpeechAudioState.xml' path='doc/member[@name="SpeechAudioState.SASPause"]/*'/>
    SASPause = SPAS_PAUSE,
    /// <include file='SpeechAudioState.xml' path='doc/member[@name="SpeechAudioState.SASRun"]/*'/>
    SASRun = SPAS_RUN,
}