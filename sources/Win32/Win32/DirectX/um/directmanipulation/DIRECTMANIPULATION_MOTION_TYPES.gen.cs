// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
[SupportedOSPlatform("windows6.2")]
public enum DIRECTMANIPULATION_MOTION_TYPES
{
    DIRECTMANIPULATION_MOTION_NONE = 0,
    DIRECTMANIPULATION_MOTION_TRANSLATEX = 0x1,
    DIRECTMANIPULATION_MOTION_TRANSLATEY = 0x2,
    DIRECTMANIPULATION_MOTION_ZOOM = 0x4,
    DIRECTMANIPULATION_MOTION_CENTERX = 0x10,
    DIRECTMANIPULATION_MOTION_CENTERY = 0x20,
    DIRECTMANIPULATION_MOTION_ALL =
        (
            (
                (
                    (DIRECTMANIPULATION_MOTION_TRANSLATEX | DIRECTMANIPULATION_MOTION_TRANSLATEY)
                    | DIRECTMANIPULATION_MOTION_ZOOM
                ) | DIRECTMANIPULATION_MOTION_CENTERX
            ) | DIRECTMANIPULATION_MOTION_CENTERY
        ),
}
