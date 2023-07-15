// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;
/// <include file='GpSizeF.xml' path='doc/member[@name="GpSizeF"]/*'/>
public unsafe partial struct GpSizeF
{
    /// <include file='GpSizeF.xml' path='doc/member[@name="GpSizeF.Width"]/*'/>
    [NativeTypeName("Gdiplus::REAL")]
    public float Width;
    /// <include file='GpSizeF.xml' path='doc/member[@name="GpSizeF.Height"]/*'/>
    [NativeTypeName("Gdiplus::REAL")]
    public float Height;
    public GpSizeF()
    {
        Width = Height = 0.0f;
    }

    public GpSizeF([NativeTypeName("const SizeF &")] GpSizeF* size)
    {
        Width = size->Width;
        Height = size->Height;
    }

    public GpSizeF([NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height)
    {
        Width = width;
        Height = height;
    }

    public BOOL Equals([NativeTypeName("const SizeF &")] GpSizeF* sz)
    {
        return ((Width == sz->Width) && (Height == sz->Height)) ? 1 : 0;
    }

    public BOOL Empty()
    {
        return (Width == 0.0f && Height == 0.0f) ? 1 : 0;
    }
}