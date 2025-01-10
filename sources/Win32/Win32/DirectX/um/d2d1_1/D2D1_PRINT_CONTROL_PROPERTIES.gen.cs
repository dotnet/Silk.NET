// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_PRINT_CONTROL_PROPERTIES
{
    public D2D1_PRINT_FONT_SUBSET_MODE fontSubset;
    public float rasterDPI;
    public D2D1_COLOR_SPACE colorSpace;
}
