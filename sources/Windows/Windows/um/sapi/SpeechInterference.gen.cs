// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPINTERFERENCE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechInterference.xml' path='doc/member[@name="SpeechInterference"]/*'/>
public enum SpeechInterference
{
    /// <include file='SpeechInterference.xml' path='doc/member[@name="SpeechInterference.SINone"]/*'/>
    SINone = SPINTERFERENCE_NONE,
    /// <include file='SpeechInterference.xml' path='doc/member[@name="SpeechInterference.SINoise"]/*'/>
    SINoise = SPINTERFERENCE_NOISE,
    /// <include file='SpeechInterference.xml' path='doc/member[@name="SpeechInterference.SINoSignal"]/*'/>
    SINoSignal = SPINTERFERENCE_NOSIGNAL,
    /// <include file='SpeechInterference.xml' path='doc/member[@name="SpeechInterference.SITooLoud"]/*'/>
    SITooLoud = SPINTERFERENCE_TOOLOUD,
    /// <include file='SpeechInterference.xml' path='doc/member[@name="SpeechInterference.SITooQuiet"]/*'/>
    SITooQuiet = SPINTERFERENCE_TOOQUIET,
    /// <include file='SpeechInterference.xml' path='doc/member[@name="SpeechInterference.SITooFast"]/*'/>
    SITooFast = SPINTERFERENCE_TOOFAST,
    /// <include file='SpeechInterference.xml' path='doc/member[@name="SpeechInterference.SITooSlow"]/*'/>
    SITooSlow = SPINTERFERENCE_TOOSLOW,
}