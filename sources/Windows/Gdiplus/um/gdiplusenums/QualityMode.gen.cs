// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='QualityMode.xml' path='doc/member[@name="QualityMode"]/*'/>
public enum QualityMode
{
    /// <include file='QualityMode.xml' path='doc/member[@name="QualityMode.QualityModeInvalid"]/*'/>
    QualityModeInvalid = -1,
    /// <include file='QualityMode.xml' path='doc/member[@name="QualityMode.QualityModeDefault"]/*'/>
    QualityModeDefault = 0,
    /// <include file='QualityMode.xml' path='doc/member[@name="QualityMode.QualityModeLow"]/*'/>
    QualityModeLow = 1,
    /// <include file='QualityMode.xml' path='doc/member[@name="QualityMode.QualityModeHigh"]/*'/>
    QualityModeHigh = 2,
}