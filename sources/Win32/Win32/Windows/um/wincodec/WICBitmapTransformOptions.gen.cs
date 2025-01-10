// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WICBitmapTransformOptions
{
    WICBitmapTransformRotate0 = 0,
    WICBitmapTransformRotate90 = 0x1,
    WICBitmapTransformRotate180 = 0x2,
    WICBitmapTransformRotate270 = 0x3,
    WICBitmapTransformFlipHorizontal = 0x8,
    WICBitmapTransformFlipVertical = 0x10,
    WICBITMAPTRANSFORMOPTIONS_FORCE_DWORD = 0x7fffffff,
}
