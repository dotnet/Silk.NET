// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.D3D_FEATURE_LEVEL;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_FEATURE_LEVEL
{
    D2D1_FEATURE_LEVEL_DEFAULT = 0,
    D2D1_FEATURE_LEVEL_9 = D3D_FEATURE_LEVEL_9_1,
    D2D1_FEATURE_LEVEL_10 = D3D_FEATURE_LEVEL_10_0,
    D2D1_FEATURE_LEVEL_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
