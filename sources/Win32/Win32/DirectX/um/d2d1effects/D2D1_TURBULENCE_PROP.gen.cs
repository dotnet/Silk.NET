// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_TURBULENCE_PROP
{
    D2D1_TURBULENCE_PROP_OFFSET = 0,
    D2D1_TURBULENCE_PROP_SIZE = 1,
    D2D1_TURBULENCE_PROP_BASE_FREQUENCY = 2,
    D2D1_TURBULENCE_PROP_NUM_OCTAVES = 3,
    D2D1_TURBULENCE_PROP_SEED = 4,
    D2D1_TURBULENCE_PROP_NOISE = 5,
    D2D1_TURBULENCE_PROP_STITCHABLE = 6,
    D2D1_TURBULENCE_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
