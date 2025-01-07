
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Silk.NET.Gdiplus;

[NativeTypeName("struct GpTexture : GpBrush")]
[NativeInheritance("GpBrush")]
public struct GpTexture : GpTexture.Interface
{
    public interface Interface : GpBrush.Interface
    {
    }
}
