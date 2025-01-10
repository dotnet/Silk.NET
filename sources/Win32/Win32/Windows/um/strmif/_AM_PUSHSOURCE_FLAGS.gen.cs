// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _AM_PUSHSOURCE_FLAGS
{
    AM_PUSHSOURCECAPS_INTERNAL_RM = 0x1,
    AM_PUSHSOURCECAPS_NOT_LIVE = 0x2,
    AM_PUSHSOURCECAPS_PRIVATE_CLOCK = 0x4,
    AM_PUSHSOURCEREQS_USE_STREAM_CLOCK = 0x10000,
    AM_PUSHSOURCEREQS_USE_CLOCK_CHAIN = 0x20000,
}
