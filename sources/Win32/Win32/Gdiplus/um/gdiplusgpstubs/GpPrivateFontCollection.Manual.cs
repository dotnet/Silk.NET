// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Silk.NET.Gdiplus;

[NativeTypeName("struct GpPrivateFontCollection : GpFontCollection")]
[NativeInheritance("GpFontCollection")]
public struct GpPrivateFontCollection : GpPrivateFontCollection.Interface
{
    public interface Interface : GpFontCollection.Interface
    {
    }
}
