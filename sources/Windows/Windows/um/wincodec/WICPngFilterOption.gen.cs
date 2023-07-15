// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption"]/*'/>
public enum WICPngFilterOption
{
    /// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption.WICPngFilterUnspecified"]/*'/>
    WICPngFilterUnspecified = 0,
    /// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption.WICPngFilterNone"]/*'/>
    WICPngFilterNone = 0x1,
    /// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption.WICPngFilterSub"]/*'/>
    WICPngFilterSub = 0x2,
    /// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption.WICPngFilterUp"]/*'/>
    WICPngFilterUp = 0x3,
    /// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption.WICPngFilterAverage"]/*'/>
    WICPngFilterAverage = 0x4,
    /// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption.WICPngFilterPaeth"]/*'/>
    WICPngFilterPaeth = 0x5,
    /// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption.WICPngFilterAdaptive"]/*'/>
    WICPngFilterAdaptive = 0x6,
    /// <include file='WICPngFilterOption.xml' path='doc/member[@name="WICPngFilterOption.WICPNGFILTEROPTION_FORCE_DWORD"]/*'/>
    WICPNGFILTEROPTION_FORCE_DWORD = 0x7fffffff,
}