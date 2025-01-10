// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPEAKFLAGS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechVoiceSpeakFlags
{
    SVSFDefault = SPF_DEFAULT,
    SVSFlagsAsync = SPF_ASYNC,
    SVSFPurgeBeforeSpeak = SPF_PURGEBEFORESPEAK,
    SVSFIsFilename = SPF_IS_FILENAME,
    SVSFIsXML = SPF_IS_XML,
    SVSFIsNotXML = SPF_IS_NOT_XML,
    SVSFPersistXML = SPF_PERSIST_XML,
    SVSFNLPSpeakPunc = SPF_NLP_SPEAK_PUNC,
    SVSFParseSapi = SPF_PARSE_SAPI,
    SVSFParseSsml = SPF_PARSE_SSML,
    SVSFParseAutodetect = SPF_PARSE_AUTODETECT,
    SVSFNLPMask = SPF_NLP_MASK,
    SVSFParseMask = SPF_PARSE_MASK,
    SVSFVoiceMask = SPF_VOICE_MASK,
    SVSFUnusedFlags = SPF_UNUSED_FLAGS,
}
