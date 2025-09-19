// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

[NativeTypeName("struct GpAdjustableArrowCap : GpCustomLineCap")]
[NativeInheritance("GpCustomLineCap")]
public partial struct GpAdjustableArrowCap : GpAdjustableArrowCap.Interface
{
    public interface Interface : GpCustomLineCap.Interface { }
}
