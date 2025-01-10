// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_PROPERTY_TS_RATE_CHANGE
{
    AM_RATE_SimpleRateChange = 1,
    AM_RATE_ExactRateChange = 2,
    AM_RATE_MaxFullDataRate = 3,
    AM_RATE_Step = 4,
    AM_RATE_UseRateVersion = 5,
    AM_RATE_QueryFullFrameRate = 6,
    AM_RATE_QueryLastRateSegPTS = 7,
    AM_RATE_CorrectTS = 8,
    AM_RATE_ReverseMaxFullDataRate = 9,
    AM_RATE_ResetOnTimeDisc = 10,
    AM_RATE_QueryMapping = 11,
}
