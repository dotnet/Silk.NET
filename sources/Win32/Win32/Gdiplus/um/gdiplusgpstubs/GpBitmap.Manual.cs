// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Silk.NET.Gdiplus;

[NativeTypeName("struct GpBitmap : GpImage")]
[NativeInheritance("GpImage")]
public struct GpBitmap : GpBitmap.Interface
{
    public interface Interface : GpImage.Interface
    {
    }
}
