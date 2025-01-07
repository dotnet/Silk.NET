// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace Silk.NET.Gdiplus;

[NativeTypeName("struct GpInstalledFontCollection : GpFontCollection")]
[NativeInheritance("GpFontCollection")]
public struct GpInstalledFontCollection : GpInstalledFontCollection.Interface
{
    public interface Interface : GpFontCollection.Interface
    {
    }
}
