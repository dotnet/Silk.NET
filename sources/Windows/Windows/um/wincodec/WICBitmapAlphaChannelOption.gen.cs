// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICBitmapAlphaChannelOption.xml' path='doc/member[@name="WICBitmapAlphaChannelOption"]/*'/>
public enum WICBitmapAlphaChannelOption
{
    /// <include file='WICBitmapAlphaChannelOption.xml' path='doc/member[@name="WICBitmapAlphaChannelOption.WICBitmapUseAlpha"]/*'/>
    WICBitmapUseAlpha = 0,
    /// <include file='WICBitmapAlphaChannelOption.xml' path='doc/member[@name="WICBitmapAlphaChannelOption.WICBitmapUsePremultipliedAlpha"]/*'/>
    WICBitmapUsePremultipliedAlpha = 0x1,
    /// <include file='WICBitmapAlphaChannelOption.xml' path='doc/member[@name="WICBitmapAlphaChannelOption.WICBitmapIgnoreAlpha"]/*'/>
    WICBitmapIgnoreAlpha = 0x2,
    /// <include file='WICBitmapAlphaChannelOption.xml' path='doc/member[@name="WICBitmapAlphaChannelOption.WICBITMAPALPHACHANNELOPTIONS_FORCE_DWORD"]/*'/>
    WICBITMAPALPHACHANNELOPTIONS_FORCE_DWORD = 0x7fffffff,
}