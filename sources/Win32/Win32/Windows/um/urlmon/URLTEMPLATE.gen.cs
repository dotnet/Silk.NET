// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum URLTEMPLATE
{
    URLTEMPLATE_CUSTOM = 0,
    URLTEMPLATE_PREDEFINED_MIN = 0x10000,
    URLTEMPLATE_LOW = 0x10000,
    URLTEMPLATE_MEDLOW = 0x10500,
    URLTEMPLATE_MEDIUM = 0x11000,
    URLTEMPLATE_MEDHIGH = 0x11500,
    URLTEMPLATE_HIGH = 0x12000,
    URLTEMPLATE_PREDEFINED_MAX = 0x20000,
}
