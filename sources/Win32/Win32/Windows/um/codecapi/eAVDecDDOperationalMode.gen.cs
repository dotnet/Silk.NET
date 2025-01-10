// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVDecDDOperationalMode
{
    eAVDecDDOperationalMode_NONE = 0,
    eAVDecDDOperationalMode_LINE = 1,
    eAVDecDDOperationalMode_RF = 2,
    eAVDecDDOperationalMode_CUSTOM0 = 3,
    eAVDecDDOperationalMode_CUSTOM1 = 4,
    eAVDecDDOperationalMode_PORTABLE8 = 5,
    eAVDecDDOperationalMode_PORTABLE11 = 6,
    eAVDecDDOperationalMode_PORTABLE14 = 7,
}
