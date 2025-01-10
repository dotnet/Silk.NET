// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct BitmapPlaneDescription
{
    [NativeTypeName("INT32")]
    public int StartIndex;

    [NativeTypeName("INT32")]
    public int Width;

    [NativeTypeName("INT32")]
    public int Height;

    [NativeTypeName("INT32")]
    public int Stride;
}
