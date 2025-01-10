// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPVALUETYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechDiscardType
{
    SDTProperty = SPDF_PROPERTY,
    SDTReplacement = SPDF_REPLACEMENT,
    SDTRule = SPDF_RULE,
    SDTDisplayText = SPDF_DISPLAYTEXT,
    SDTLexicalForm = SPDF_LEXICALFORM,
    SDTPronunciation = SPDF_PRONUNCIATION,
    SDTAudio = SPDF_AUDIO,
    SDTAlternates = SPDF_ALTERNATES,
    SDTAll = SPDF_ALL,
}
