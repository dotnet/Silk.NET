// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='BitmapData.xml' path='doc/member[@name="BitmapData"]/*'/>
public unsafe partial struct BitmapData
{
    /// <include file='BitmapData.xml' path='doc/member[@name="BitmapData.Width"]/*'/>
    public uint Width;
    /// <include file='BitmapData.xml' path='doc/member[@name="BitmapData.Height"]/*'/>
    public uint Height;
    /// <include file='BitmapData.xml' path='doc/member[@name="BitmapData.Stride"]/*'/>
    public int Stride;
    /// <include file='BitmapData.xml' path='doc/member[@name="BitmapData.PixelFormat"]/*'/>
    [NativeTypeName("Gdiplus::PixelFormat")]
    public int PixelFormat;
    /// <include file='BitmapData.xml' path='doc/member[@name="BitmapData.Scan0"]/*'/>
    public void* Scan0;
    /// <include file='BitmapData.xml' path='doc/member[@name="BitmapData.Reserved"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint Reserved;
}