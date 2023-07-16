// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo"]/*'/>
public enum DISPID_SpeechPhraseInfo
{
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPILanguageId"]/*'/>
    DISPID_SPILanguageId = 1,
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIGrammarId"]/*'/>
    DISPID_SPIGrammarId = (DISPID_SPILanguageId + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIStartTime"]/*'/>
    DISPID_SPIStartTime = (DISPID_SPIGrammarId + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIAudioStreamPosition"]/*'/>
    DISPID_SPIAudioStreamPosition = (DISPID_SPIStartTime + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIAudioSizeBytes"]/*'/>
    DISPID_SPIAudioSizeBytes = (DISPID_SPIAudioStreamPosition + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIRetainedSizeBytes"]/*'/>
    DISPID_SPIRetainedSizeBytes = (DISPID_SPIAudioSizeBytes + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIAudioSizeTime"]/*'/>
    DISPID_SPIAudioSizeTime = (DISPID_SPIRetainedSizeBytes + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIRule"]/*'/>
    DISPID_SPIRule = (DISPID_SPIAudioSizeTime + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIProperties"]/*'/>
    DISPID_SPIProperties = (DISPID_SPIRule + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIElements"]/*'/>
    DISPID_SPIElements = (DISPID_SPIProperties + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIReplacements"]/*'/>
    DISPID_SPIReplacements = (DISPID_SPIElements + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIEngineId"]/*'/>
    DISPID_SPIEngineId = (DISPID_SPIReplacements + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIEnginePrivateData"]/*'/>
    DISPID_SPIEnginePrivateData = (DISPID_SPIEngineId + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPISaveToMemory"]/*'/>
    DISPID_SPISaveToMemory = (DISPID_SPIEnginePrivateData + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIGetText"]/*'/>
    DISPID_SPIGetText = (DISPID_SPISaveToMemory + 1),
    /// <include file='DISPID_SpeechPhraseInfo.xml' path='doc/member[@name="DISPID_SpeechPhraseInfo.DISPID_SPIGetDisplayAttributes"]/*'/>
    DISPID_SPIGetDisplayAttributes = (DISPID_SPIGetText + 1),
}