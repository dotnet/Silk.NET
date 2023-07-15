// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICPngSrgbProperties.xml' path='doc/member[@name="WICPngSrgbProperties"]/*'/>
public enum WICPngSrgbProperties
{
    /// <include file='WICPngSrgbProperties.xml' path='doc/member[@name="WICPngSrgbProperties.WICPngSrgbRenderingIntent"]/*'/>
    WICPngSrgbRenderingIntent = 0x1,
    /// <include file='WICPngSrgbProperties.xml' path='doc/member[@name="WICPngSrgbProperties.WICPngSrgbProperties_FORCE_DWORD"]/*'/>
    WICPngSrgbProperties_FORCE_DWORD = 0x7fffffff,
}