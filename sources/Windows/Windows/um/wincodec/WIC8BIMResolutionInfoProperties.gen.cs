// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties"]/*'/>
public enum WIC8BIMResolutionInfoProperties
{
    /// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties.WIC8BIMResolutionInfoPString"]/*'/>
    WIC8BIMResolutionInfoPString = 0x1,
    /// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties.WIC8BIMResolutionInfoHResolution"]/*'/>
    WIC8BIMResolutionInfoHResolution = 0x2,
    /// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties.WIC8BIMResolutionInfoHResolutionUnit"]/*'/>
    WIC8BIMResolutionInfoHResolutionUnit = 0x3,
    /// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties.WIC8BIMResolutionInfoWidthUnit"]/*'/>
    WIC8BIMResolutionInfoWidthUnit = 0x4,
    /// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties.WIC8BIMResolutionInfoVResolution"]/*'/>
    WIC8BIMResolutionInfoVResolution = 0x5,
    /// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties.WIC8BIMResolutionInfoVResolutionUnit"]/*'/>
    WIC8BIMResolutionInfoVResolutionUnit = 0x6,
    /// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties.WIC8BIMResolutionInfoHeightUnit"]/*'/>
    WIC8BIMResolutionInfoHeightUnit = 0x7,
    /// <include file='WIC8BIMResolutionInfoProperties.xml' path='doc/member[@name="WIC8BIMResolutionInfoProperties.WIC8BIMResolutionInfoProperties_FORCE_DWORD"]/*'/>
    WIC8BIMResolutionInfoProperties_FORCE_DWORD = 0x7fffffff,
}