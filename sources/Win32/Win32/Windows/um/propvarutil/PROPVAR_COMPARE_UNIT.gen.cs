// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PROPVAR_COMPARE_UNIT
{
    PVCU_DEFAULT = 0,
    PVCU_SECOND = 1,
    PVCU_MINUTE = 2,
    PVCU_HOUR = 3,
    PVCU_DAY = 4,
    PVCU_MONTH = 5,
    PVCU_YEAR = 6,
}
