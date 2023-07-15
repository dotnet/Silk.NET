// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIC8BIMIptcProperties.xml' path='doc/member[@name="WIC8BIMIptcProperties"]/*'/>
public enum WIC8BIMIptcProperties
{
    /// <include file='WIC8BIMIptcProperties.xml' path='doc/member[@name="WIC8BIMIptcProperties.WIC8BIMIptcPString"]/*'/>
    WIC8BIMIptcPString = 0,
    /// <include file='WIC8BIMIptcProperties.xml' path='doc/member[@name="WIC8BIMIptcProperties.WIC8BIMIptcEmbeddedIPTC"]/*'/>
    WIC8BIMIptcEmbeddedIPTC = 0x1,
    /// <include file='WIC8BIMIptcProperties.xml' path='doc/member[@name="WIC8BIMIptcProperties.WIC8BIMIptcProperties_FORCE_DWORD"]/*'/>
    WIC8BIMIptcProperties_FORCE_DWORD = 0x7fffffff,
}