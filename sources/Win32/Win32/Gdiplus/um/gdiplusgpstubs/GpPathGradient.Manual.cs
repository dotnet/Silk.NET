// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Silk.NET.Gdiplus;

[NativeTypeName("struct GpPathGradient : GpBrush")]
[NativeInheritance("GpBrush")]
public struct GpPathGradient : GpPathGradient.Interface
{
    public interface Interface : GpBrush.Interface
    {
    }
}
