// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPVFEATURE;

namespace Silk.NET.Windows;
/// <include file='SpeechVisemeFeature.xml' path='doc/member[@name="SpeechVisemeFeature"]/*'/>
public enum SpeechVisemeFeature
{
    /// <include file='SpeechVisemeFeature.xml' path='doc/member[@name="SpeechVisemeFeature.SVF_None"]/*'/>
    SVF_None = 0,
    /// <include file='SpeechVisemeFeature.xml' path='doc/member[@name="SpeechVisemeFeature.SVF_Stressed"]/*'/>
    SVF_Stressed = SPVFEATURE_STRESSED,
    /// <include file='SpeechVisemeFeature.xml' path='doc/member[@name="SpeechVisemeFeature.SVF_Emphasis"]/*'/>
    SVF_Emphasis = SPVFEATURE_EMPHASIS,
}