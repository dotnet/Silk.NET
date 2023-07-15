// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPVALUETYPE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType"]/*'/>
public enum SpeechDiscardType
{
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTProperty"]/*'/>
    SDTProperty = SPDF_PROPERTY,
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTReplacement"]/*'/>
    SDTReplacement = SPDF_REPLACEMENT,
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTRule"]/*'/>
    SDTRule = SPDF_RULE,
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTDisplayText"]/*'/>
    SDTDisplayText = SPDF_DISPLAYTEXT,
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTLexicalForm"]/*'/>
    SDTLexicalForm = SPDF_LEXICALFORM,
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTPronunciation"]/*'/>
    SDTPronunciation = SPDF_PRONUNCIATION,
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTAudio"]/*'/>
    SDTAudio = SPDF_AUDIO,
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTAlternates"]/*'/>
    SDTAlternates = SPDF_ALTERNATES,
    /// <include file='SpeechDiscardType.xml' path='doc/member[@name="SpeechDiscardType.SDTAll"]/*'/>
    SDTAll = SPDF_ALL,
}