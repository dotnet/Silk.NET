// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVEncH264VProfile
{
    eAVEncH264VProfile_unknown = 0,
    eAVEncH264VProfile_Simple = 66,
    eAVEncH264VProfile_Base = 66,
    eAVEncH264VProfile_Main = 77,
    eAVEncH264VProfile_High = 100,
    eAVEncH264VProfile_422 = 122,
    eAVEncH264VProfile_High10 = 110,
    eAVEncH264VProfile_444 = 244,
    eAVEncH264VProfile_Extended = 88,
    eAVEncH264VProfile_ScalableBase = 83,
    eAVEncH264VProfile_ScalableHigh = 86,
    eAVEncH264VProfile_MultiviewHigh = 118,
    eAVEncH264VProfile_StereoHigh = 128,
    eAVEncH264VProfile_ConstrainedBase = 256,
    eAVEncH264VProfile_UCConstrainedHigh = 257,
    eAVEncH264VProfile_UCScalableConstrainedBase = 258,
    eAVEncH264VProfile_UCScalableConstrainedHigh = 259,
}
