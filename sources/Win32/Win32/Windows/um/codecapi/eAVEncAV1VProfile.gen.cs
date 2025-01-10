// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVEncAV1VProfile
{
    eAVEncAV1VProfile_unknown = 0,
    eAVEncAV1VProfile_Main_420_8,
    eAVEncAV1VProfile_Main_420_10,
    eAVEncAV1VProfile_Main_400_8,
    eAVEncAV1VProfile_Main_400_10,
    eAVEncAV1VProfile_High_444_8,
    eAVEncAV1VProfile_High_444_10,
    eAVEncAV1VProfile_Professional_420_12,
    eAVEncAV1VProfile_Professional_400_12,
    eAVEncAV1VProfile_Professional_444_12,
    eAVEncAV1VProfile_Professional_422_8,
    eAVEncAV1VProfile_Professional_422_10,
    eAVEncAV1VProfile_Professional_422_12,
}
