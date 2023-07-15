// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPEAKFLAGS;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags"]/*'/>
public enum SpeechVoiceSpeakFlags
{
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFDefault"]/*'/>
    SVSFDefault = SPF_DEFAULT,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFlagsAsync"]/*'/>
    SVSFlagsAsync = SPF_ASYNC,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak"]/*'/>
    SVSFPurgeBeforeSpeak = SPF_PURGEBEFORESPEAK,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFIsFilename"]/*'/>
    SVSFIsFilename = SPF_IS_FILENAME,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFIsXML"]/*'/>
    SVSFIsXML = SPF_IS_XML,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFIsNotXML"]/*'/>
    SVSFIsNotXML = SPF_IS_NOT_XML,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFPersistXML"]/*'/>
    SVSFPersistXML = SPF_PERSIST_XML,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFNLPSpeakPunc"]/*'/>
    SVSFNLPSpeakPunc = SPF_NLP_SPEAK_PUNC,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFParseSapi"]/*'/>
    SVSFParseSapi = SPF_PARSE_SAPI,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFParseSsml"]/*'/>
    SVSFParseSsml = SPF_PARSE_SSML,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFParseAutodetect"]/*'/>
    SVSFParseAutodetect = SPF_PARSE_AUTODETECT,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFNLPMask"]/*'/>
    SVSFNLPMask = SPF_NLP_MASK,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFParseMask"]/*'/>
    SVSFParseMask = SPF_PARSE_MASK,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFVoiceMask"]/*'/>
    SVSFVoiceMask = SPF_VOICE_MASK,
    /// <include file='SpeechVoiceSpeakFlags.xml' path='doc/member[@name="SpeechVoiceSpeakFlags.SVSFUnusedFlags"]/*'/>
    SVSFUnusedFlags = SPF_UNUSED_FLAGS,
}