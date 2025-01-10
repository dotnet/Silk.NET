// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows6.2")]
public enum CROSS_SLIDE_FLAGS
{
    CROSS_SLIDE_FLAGS_NONE = 0x00000000,
    CROSS_SLIDE_FLAGS_SELECT = 0x00000001,
    CROSS_SLIDE_FLAGS_SPEED_BUMP = 0x00000002,
    CROSS_SLIDE_FLAGS_REARRANGE = 0x00000004,
    CROSS_SLIDE_FLAGS_MAX = unchecked((int)(0xffffffff)),
}
