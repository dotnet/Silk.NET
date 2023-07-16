// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties"]/*'/>
public enum WICGifLogicalScreenDescriptorProperties
{
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenSignature"]/*'/>
    WICGifLogicalScreenSignature = 0x1,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorWidth"]/*'/>
    WICGifLogicalScreenDescriptorWidth = 0x2,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorHeight"]/*'/>
    WICGifLogicalScreenDescriptorHeight = 0x3,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorGlobalColorTableFlag"]/*'/>
    WICGifLogicalScreenDescriptorGlobalColorTableFlag = 0x4,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorColorResolution"]/*'/>
    WICGifLogicalScreenDescriptorColorResolution = 0x5,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorSortFlag"]/*'/>
    WICGifLogicalScreenDescriptorSortFlag = 0x6,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorGlobalColorTableSize"]/*'/>
    WICGifLogicalScreenDescriptorGlobalColorTableSize = 0x7,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorBackgroundColorIndex"]/*'/>
    WICGifLogicalScreenDescriptorBackgroundColorIndex = 0x8,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorPixelAspectRatio"]/*'/>
    WICGifLogicalScreenDescriptorPixelAspectRatio = 0x9,
    /// <include file='WICGifLogicalScreenDescriptorProperties.xml' path='doc/member[@name="WICGifLogicalScreenDescriptorProperties.WICGifLogicalScreenDescriptorProperties_FORCE_DWORD"]/*'/>
    WICGifLogicalScreenDescriptorProperties_FORCE_DWORD = 0x7fffffff,
}