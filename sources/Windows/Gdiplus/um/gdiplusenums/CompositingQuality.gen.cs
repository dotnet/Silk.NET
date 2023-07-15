// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Gdiplus.QualityMode;

namespace TerraFX.Interop.Gdiplus;
/// <include file='CompositingQuality.xml' path='doc/member[@name="CompositingQuality"]/*'/>
public enum CompositingQuality
{
    /// <include file='CompositingQuality.xml' path='doc/member[@name="CompositingQuality.CompositingQualityInvalid"]/*'/>
    CompositingQualityInvalid = QualityModeInvalid,
    /// <include file='CompositingQuality.xml' path='doc/member[@name="CompositingQuality.CompositingQualityDefault"]/*'/>
    CompositingQualityDefault = QualityModeDefault,
    /// <include file='CompositingQuality.xml' path='doc/member[@name="CompositingQuality.CompositingQualityHighSpeed"]/*'/>
    CompositingQualityHighSpeed = QualityModeLow,
    /// <include file='CompositingQuality.xml' path='doc/member[@name="CompositingQuality.CompositingQualityHighQuality"]/*'/>
    CompositingQualityHighQuality = QualityModeHigh,
    /// <include file='CompositingQuality.xml' path='doc/member[@name="CompositingQuality.CompositingQualityGammaCorrected"]/*'/>
    CompositingQualityGammaCorrected,
    /// <include file='CompositingQuality.xml' path='doc/member[@name="CompositingQuality.CompositingQualityAssumeLinear"]/*'/>
    CompositingQualityAssumeLinear,
}