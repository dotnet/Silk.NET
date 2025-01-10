// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPRECOEVENTFLAGS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SpeechRecognitionType
{
    SRTStandard = 0,
    SRTAutopause = SPREF_AutoPause,
    SRTEmulated = SPREF_Emulated,
    SRTSMLTimeout = SPREF_SMLTimeout,
    SRTExtendableParse = SPREF_ExtendableParse,
    SRTReSent = SPREF_ReSent,
}
