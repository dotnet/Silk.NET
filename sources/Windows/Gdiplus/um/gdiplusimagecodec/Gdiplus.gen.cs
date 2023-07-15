// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimagecodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
public static unsafe partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GetImageDecodersSize"]/*'/>
    [return: NativeTypeName("Gdiplus::Status")]
    public static GpStatus GetImageDecodersSize(uint* numDecoders, uint* size)
    {
        return GdipGetImageDecodersSize(numDecoders, size);
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GetImageDecoders"]/*'/>
    [return: NativeTypeName("Gdiplus::Status")]
    public static GpStatus GetImageDecoders(uint numDecoders, uint size, [NativeTypeName("Gdiplus::ImageCodecInfo *")] ImageCodecInfo* decoders)
    {
        return GdipGetImageDecoders(numDecoders, size, decoders);
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GetImageEncodersSize"]/*'/>
    [return: NativeTypeName("Gdiplus::Status")]
    public static GpStatus GetImageEncodersSize(uint* numEncoders, uint* size)
    {
        return GdipGetImageEncodersSize(numEncoders, size);
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GetImageEncoders"]/*'/>
    [return: NativeTypeName("Gdiplus::Status")]
    public static GpStatus GetImageEncoders(uint numEncoders, uint size, [NativeTypeName("Gdiplus::ImageCodecInfo *")] ImageCodecInfo* encoders)
    {
        return GdipGetImageEncoders(numEncoders, size, encoders);
    }
}