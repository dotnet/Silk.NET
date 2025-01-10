// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_DISTANTDIFFUSE_PROP
{
    D2D1_DISTANTDIFFUSE_PROP_AZIMUTH = 0,
    D2D1_DISTANTDIFFUSE_PROP_ELEVATION = 1,
    D2D1_DISTANTDIFFUSE_PROP_DIFFUSE_CONSTANT = 2,
    D2D1_DISTANTDIFFUSE_PROP_SURFACE_SCALE = 3,
    D2D1_DISTANTDIFFUSE_PROP_COLOR = 4,
    D2D1_DISTANTDIFFUSE_PROP_KERNEL_UNIT_LENGTH = 5,
    D2D1_DISTANTDIFFUSE_PROP_SCALE_MODE = 6,
    D2D1_DISTANTDIFFUSE_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
