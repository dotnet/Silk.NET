// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechRecognizerStatus
{
    DISPID_SRSAudioStatus = 1,
    DISPID_SRSCurrentStreamPosition = (DISPID_SRSAudioStatus + 1),
    DISPID_SRSCurrentStreamNumber = (DISPID_SRSCurrentStreamPosition + 1),
    DISPID_SRSNumberOfActiveRules = (DISPID_SRSCurrentStreamNumber + 1),
    DISPID_SRSClsidEngine = (DISPID_SRSNumberOfActiveRules + 1),
    DISPID_SRSSupportedLanguages = (DISPID_SRSClsidEngine + 1),
}
