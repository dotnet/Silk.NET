// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
[SupportedOSPlatform("windows6.3")]
public enum DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION
{
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_VERTICAL = 0x1,
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_HORIZONTAL = 0x2,
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_SELECT_ONLY = 0x10,
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_SELECT_DRAG = 0x20,
    DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION_HOLD_DRAG = 0x40,
}
