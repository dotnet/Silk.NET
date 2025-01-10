// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechLexicon
{
    DISPID_SLGenerationId = 1,
    DISPID_SLGetWords = (DISPID_SLGenerationId + 1),
    DISPID_SLAddPronunciation = (DISPID_SLGetWords + 1),
    DISPID_SLAddPronunciationByPhoneIds = (DISPID_SLAddPronunciation + 1),
    DISPID_SLRemovePronunciation = (DISPID_SLAddPronunciationByPhoneIds + 1),
    DISPID_SLRemovePronunciationByPhoneIds = (DISPID_SLRemovePronunciation + 1),
    DISPID_SLGetPronunciations = (DISPID_SLRemovePronunciationByPhoneIds + 1),
    DISPID_SLGetGenerationChange = (DISPID_SLGetPronunciations + 1),
}
