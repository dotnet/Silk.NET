// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PROPDESC_CONDITION_TYPE
{
    PDCOT_NONE = 0,
    PDCOT_STRING = 1,
    PDCOT_SIZE = 2,
    PDCOT_DATETIME = 3,
    PDCOT_BOOLEAN = 4,
    PDCOT_NUMBER = 5,
}
