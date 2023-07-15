// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICDecodeOptions.xml' path='doc/member[@name="WICDecodeOptions"]/*'/>
public enum WICDecodeOptions
{
    /// <include file='WICDecodeOptions.xml' path='doc/member[@name="WICDecodeOptions.WICDecodeMetadataCacheOnDemand"]/*'/>
    WICDecodeMetadataCacheOnDemand = 0,
    /// <include file='WICDecodeOptions.xml' path='doc/member[@name="WICDecodeOptions.WICDecodeMetadataCacheOnLoad"]/*'/>
    WICDecodeMetadataCacheOnLoad = 0x1,
    /// <include file='WICDecodeOptions.xml' path='doc/member[@name="WICDecodeOptions.WICMETADATACACHEOPTION_FORCE_DWORD"]/*'/>
    WICMETADATACACHEOPTION_FORCE_DWORD = 0x7fffffff,
}