// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPRECOEVENTFLAGS
{
    SPREF_AutoPause = (1 << 0),
    SPREF_Emulated = (1 << 1),
    SPREF_SMLTimeout = (1 << 2),
    SPREF_ExtendableParse = (1 << 3),
    SPREF_ReSent = (1 << 4),
    SPREF_Hypothesis = (1 << 5),
    SPREF_FalseRecognition = (1 << 6),
}
