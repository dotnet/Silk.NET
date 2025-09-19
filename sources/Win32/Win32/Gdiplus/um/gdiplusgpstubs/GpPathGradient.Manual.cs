// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

[NativeTypeName("struct GpPathGradient : GpBrush")]
[NativeInheritance("GpBrush")]
public partial struct GpPathGradient : GpPathGradient.Interface
{
    public interface Interface : GpBrush.Interface { }
}
