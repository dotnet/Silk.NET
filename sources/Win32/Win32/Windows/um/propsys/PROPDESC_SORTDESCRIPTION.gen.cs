// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PROPDESC_SORTDESCRIPTION
{
    PDSD_GENERAL = 0,
    PDSD_A_Z = 1,
    PDSD_LOWEST_HIGHEST = 2,
    PDSD_SMALLEST_BIGGEST = 3,
    PDSD_OLDEST_NEWEST = 4,
}
