// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPSHORTCUTTYPE
{
    SPSHT_NotOverriden = -1,
    SPSHT_Unknown = 0,
    SPSHT_EMAIL = 0x1000,
    SPSHT_OTHER = 0x2000,
    SPPS_RESERVED1 = 0x3000,
    SPPS_RESERVED2 = 0x4000,
    SPPS_RESERVED3 = 0x5000,
    SPPS_RESERVED4 = 0xf000,
}
