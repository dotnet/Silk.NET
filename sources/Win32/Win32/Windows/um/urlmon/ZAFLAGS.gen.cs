// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum ZAFLAGS
{
    ZAFLAGS_CUSTOM_EDIT = 0x1,
    ZAFLAGS_ADD_SITES = 0x2,
    ZAFLAGS_REQUIRE_VERIFICATION = 0x4,
    ZAFLAGS_INCLUDE_PROXY_OVERRIDE = 0x8,
    ZAFLAGS_INCLUDE_INTRANET_SITES = 0x10,
    ZAFLAGS_NO_UI = 0x20,
    ZAFLAGS_SUPPORTS_VERIFICATION = 0x40,
    ZAFLAGS_UNC_AS_INTRANET = 0x80,
    ZAFLAGS_DETECT_INTRANET = 0x100,
    ZAFLAGS_USE_LOCKED_ZONES = 0x10000,
    ZAFLAGS_VERIFY_TEMPLATE_SETTINGS = 0x20000,
    ZAFLAGS_NO_CACHE = 0x40000,
}
