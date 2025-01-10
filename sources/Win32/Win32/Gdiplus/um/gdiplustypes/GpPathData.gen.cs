// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct GpPathData
{
    public int Count;

    [NativeTypeName("Gdiplus::PointF *")]
    public GpPointF* Points;
    public byte* Types;

    public GpPathData()
    {
        Count = 0;
        Points = null;
        Types = null;
    }
}
