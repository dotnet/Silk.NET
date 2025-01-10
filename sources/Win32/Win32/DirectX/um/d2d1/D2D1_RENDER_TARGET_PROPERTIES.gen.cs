// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_RENDER_TARGET_PROPERTIES
{
    public D2D1_RENDER_TARGET_TYPE type;
    public D2D1_PIXEL_FORMAT pixelFormat;
    public float dpiX;
    public float dpiY;
    public D2D1_RENDER_TARGET_USAGE usage;
    public D2D1_FEATURE_LEVEL minLevel;
}
