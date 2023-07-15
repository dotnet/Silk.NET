// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPRECOEVENTFLAGS;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechRecognitionType.xml' path='doc/member[@name="SpeechRecognitionType"]/*'/>
public enum SpeechRecognitionType
{
    /// <include file='SpeechRecognitionType.xml' path='doc/member[@name="SpeechRecognitionType.SRTStandard"]/*'/>
    SRTStandard = 0,
    /// <include file='SpeechRecognitionType.xml' path='doc/member[@name="SpeechRecognitionType.SRTAutopause"]/*'/>
    SRTAutopause = SPREF_AutoPause,
    /// <include file='SpeechRecognitionType.xml' path='doc/member[@name="SpeechRecognitionType.SRTEmulated"]/*'/>
    SRTEmulated = SPREF_Emulated,
    /// <include file='SpeechRecognitionType.xml' path='doc/member[@name="SpeechRecognitionType.SRTSMLTimeout"]/*'/>
    SRTSMLTimeout = SPREF_SMLTimeout,
    /// <include file='SpeechRecognitionType.xml' path='doc/member[@name="SpeechRecognitionType.SRTExtendableParse"]/*'/>
    SRTExtendableParse = SPREF_ExtendableParse,
    /// <include file='SpeechRecognitionType.xml' path='doc/member[@name="SpeechRecognitionType.SRTReSent"]/*'/>
    SRTReSent = SPREF_ReSent,
}