// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICGifGraphicControlExtensionProperties.xml' path='doc/member[@name="WICGifGraphicControlExtensionProperties"]/*'/>
public enum WICGifGraphicControlExtensionProperties
{
    /// <include file='WICGifGraphicControlExtensionProperties.xml' path='doc/member[@name="WICGifGraphicControlExtensionProperties.WICGifGraphicControlExtensionDisposal"]/*'/>
    WICGifGraphicControlExtensionDisposal = 0x1,
    /// <include file='WICGifGraphicControlExtensionProperties.xml' path='doc/member[@name="WICGifGraphicControlExtensionProperties.WICGifGraphicControlExtensionUserInputFlag"]/*'/>
    WICGifGraphicControlExtensionUserInputFlag = 0x2,
    /// <include file='WICGifGraphicControlExtensionProperties.xml' path='doc/member[@name="WICGifGraphicControlExtensionProperties.WICGifGraphicControlExtensionTransparencyFlag"]/*'/>
    WICGifGraphicControlExtensionTransparencyFlag = 0x3,
    /// <include file='WICGifGraphicControlExtensionProperties.xml' path='doc/member[@name="WICGifGraphicControlExtensionProperties.WICGifGraphicControlExtensionDelay"]/*'/>
    WICGifGraphicControlExtensionDelay = 0x4,
    /// <include file='WICGifGraphicControlExtensionProperties.xml' path='doc/member[@name="WICGifGraphicControlExtensionProperties.WICGifGraphicControlExtensionTransparentColorIndex"]/*'/>
    WICGifGraphicControlExtensionTransparentColorIndex = 0x5,
    /// <include file='WICGifGraphicControlExtensionProperties.xml' path='doc/member[@name="WICGifGraphicControlExtensionProperties.WICGifGraphicControlExtensionProperties_FORCE_DWORD"]/*'/>
    WICGifGraphicControlExtensionProperties_FORCE_DWORD = 0x7fffffff,
}