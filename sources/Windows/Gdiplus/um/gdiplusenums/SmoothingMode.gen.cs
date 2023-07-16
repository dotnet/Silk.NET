// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Gdiplus.QualityMode;

namespace Silk.NET.Gdiplus;
/// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode"]/*'/>
public enum SmoothingMode
{
    /// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode.SmoothingModeInvalid"]/*'/>
    SmoothingModeInvalid = QualityModeInvalid,
    /// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode.SmoothingModeDefault"]/*'/>
    SmoothingModeDefault = QualityModeDefault,
    /// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode.SmoothingModeHighSpeed"]/*'/>
    SmoothingModeHighSpeed = QualityModeLow,
    /// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode.SmoothingModeHighQuality"]/*'/>
    SmoothingModeHighQuality = QualityModeHigh,
    /// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode.SmoothingModeNone"]/*'/>
    SmoothingModeNone,
    /// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode.SmoothingModeAntiAlias"]/*'/>
    SmoothingModeAntiAlias,
    /// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode.SmoothingModeAntiAlias8x4"]/*'/>
    SmoothingModeAntiAlias8x4 = SmoothingModeAntiAlias,
    /// <include file='SmoothingMode.xml' path='doc/member[@name="SmoothingMode.SmoothingModeAntiAlias8x8"]/*'/>
    SmoothingModeAntiAlias8x8,
}