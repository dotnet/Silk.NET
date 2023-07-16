// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Gdiplus.QualityMode;

namespace Silk.NET.Gdiplus;
/// <include file='PixelOffsetMode.xml' path='doc/member[@name="PixelOffsetMode"]/*'/>
public enum PixelOffsetMode
{
    /// <include file='PixelOffsetMode.xml' path='doc/member[@name="PixelOffsetMode.PixelOffsetModeInvalid"]/*'/>
    PixelOffsetModeInvalid = QualityModeInvalid,
    /// <include file='PixelOffsetMode.xml' path='doc/member[@name="PixelOffsetMode.PixelOffsetModeDefault"]/*'/>
    PixelOffsetModeDefault = QualityModeDefault,
    /// <include file='PixelOffsetMode.xml' path='doc/member[@name="PixelOffsetMode.PixelOffsetModeHighSpeed"]/*'/>
    PixelOffsetModeHighSpeed = QualityModeLow,
    /// <include file='PixelOffsetMode.xml' path='doc/member[@name="PixelOffsetMode.PixelOffsetModeHighQuality"]/*'/>
    PixelOffsetModeHighQuality = QualityModeHigh,
    /// <include file='PixelOffsetMode.xml' path='doc/member[@name="PixelOffsetMode.PixelOffsetModeNone"]/*'/>
    PixelOffsetModeNone,
    /// <include file='PixelOffsetMode.xml' path='doc/member[@name="PixelOffsetMode.PixelOffsetModeHalf"]/*'/>
    PixelOffsetModeHalf,
}