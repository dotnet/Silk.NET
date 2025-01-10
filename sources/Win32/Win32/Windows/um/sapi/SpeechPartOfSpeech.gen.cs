// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPPARTOFSPEECH;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechPartOfSpeech
{
    SPSNotOverriden = SPPS_NotOverriden,
    SPSUnknown = SPPS_Unknown,
    SPSNoun = SPPS_Noun,
    SPSVerb = SPPS_Verb,
    SPSModifier = SPPS_Modifier,
    SPSFunction = SPPS_Function,
    SPSInterjection = SPPS_Interjection,
    SPSLMA = SPPS_LMA,
    SPSSuppressWord = SPPS_SuppressWord,
}
