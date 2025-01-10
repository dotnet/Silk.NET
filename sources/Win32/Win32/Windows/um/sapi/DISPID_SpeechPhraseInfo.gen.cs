// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechPhraseInfo
{
    DISPID_SPILanguageId = 1,
    DISPID_SPIGrammarId = (DISPID_SPILanguageId + 1),
    DISPID_SPIStartTime = (DISPID_SPIGrammarId + 1),
    DISPID_SPIAudioStreamPosition = (DISPID_SPIStartTime + 1),
    DISPID_SPIAudioSizeBytes = (DISPID_SPIAudioStreamPosition + 1),
    DISPID_SPIRetainedSizeBytes = (DISPID_SPIAudioSizeBytes + 1),
    DISPID_SPIAudioSizeTime = (DISPID_SPIRetainedSizeBytes + 1),
    DISPID_SPIRule = (DISPID_SPIAudioSizeTime + 1),
    DISPID_SPIProperties = (DISPID_SPIRule + 1),
    DISPID_SPIElements = (DISPID_SPIProperties + 1),
    DISPID_SPIReplacements = (DISPID_SPIElements + 1),
    DISPID_SPIEngineId = (DISPID_SPIReplacements + 1),
    DISPID_SPIEnginePrivateData = (DISPID_SPIEngineId + 1),
    DISPID_SPISaveToMemory = (DISPID_SPIEnginePrivateData + 1),
    DISPID_SPIGetText = (DISPID_SPISaveToMemory + 1),
    DISPID_SPIGetDisplayAttributes = (DISPID_SPIGetText + 1),
}
