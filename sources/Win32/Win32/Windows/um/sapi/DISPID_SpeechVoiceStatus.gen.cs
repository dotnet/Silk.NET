// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechVoiceStatus
{
    DISPID_SVSCurrentStreamNumber = 1,
    DISPID_SVSLastStreamNumberQueued = (DISPID_SVSCurrentStreamNumber + 1),
    DISPID_SVSLastResult = (DISPID_SVSLastStreamNumberQueued + 1),
    DISPID_SVSRunningState = (DISPID_SVSLastResult + 1),
    DISPID_SVSInputWordPosition = (DISPID_SVSRunningState + 1),
    DISPID_SVSInputWordLength = (DISPID_SVSInputWordPosition + 1),
    DISPID_SVSInputSentencePosition = (DISPID_SVSInputWordLength + 1),
    DISPID_SVSInputSentenceLength = (DISPID_SVSInputSentencePosition + 1),
    DISPID_SVSLastBookmark = (DISPID_SVSInputSentenceLength + 1),
    DISPID_SVSLastBookmarkId = (DISPID_SVSLastBookmark + 1),
    DISPID_SVSPhonemeId = (DISPID_SVSLastBookmarkId + 1),
    DISPID_SVSVisemeId = (DISPID_SVSPhonemeId + 1),
}
