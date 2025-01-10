// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechLexiconPronunciation
{
    DISPID_SLPType = 1,
    DISPID_SLPLangId = (DISPID_SLPType + 1),
    DISPID_SLPPartOfSpeech = (DISPID_SLPLangId + 1),
    DISPID_SLPPhoneIds = (DISPID_SLPPartOfSpeech + 1),
    DISPID_SLPSymbolic = (DISPID_SLPPhoneIds + 1),
}
