// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPGRAMMAROPTIONS
{
    SPGO_SAPI = 0x1,
    SPGO_SRGS = 0x2,
    SPGO_UPS = 0x4,
    SPGO_SRGS_MS_SCRIPT = 0x8,
    SPGO_SRGS_W3C_SCRIPT = 0x100,
    SPGO_SRGS_STG_SCRIPT = 0x200,
    SPGO_SRGS_SCRIPT =
        (((SPGO_SRGS | SPGO_SRGS_MS_SCRIPT) | SPGO_SRGS_W3C_SCRIPT) | SPGO_SRGS_STG_SCRIPT),
    SPGO_FILE = 0x10,
    SPGO_HTTP = 0x20,
    SPGO_RES = 0x40,
    SPGO_OBJECT = 0x80,
    SPGO_DEFAULT = 0x3fb,
    SPGO_ALL = 0x3ff,
}
