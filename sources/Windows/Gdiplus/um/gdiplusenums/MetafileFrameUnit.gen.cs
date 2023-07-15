// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Gdiplus.GpUnit;

namespace TerraFX.Interop.Gdiplus;
/// <include file='MetafileFrameUnit.xml' path='doc/member[@name="MetafileFrameUnit"]/*'/>
public enum MetafileFrameUnit
{
    /// <include file='MetafileFrameUnit.xml' path='doc/member[@name="MetafileFrameUnit.MetafileFrameUnitPixel"]/*'/>
    MetafileFrameUnitPixel = UnitPixel,
    /// <include file='MetafileFrameUnit.xml' path='doc/member[@name="MetafileFrameUnit.MetafileFrameUnitPoint"]/*'/>
    MetafileFrameUnitPoint = UnitPoint,
    /// <include file='MetafileFrameUnit.xml' path='doc/member[@name="MetafileFrameUnit.MetafileFrameUnitInch"]/*'/>
    MetafileFrameUnitInch = UnitInch,
    /// <include file='MetafileFrameUnit.xml' path='doc/member[@name="MetafileFrameUnit.MetafileFrameUnitDocument"]/*'/>
    MetafileFrameUnitDocument = UnitDocument,
    /// <include file='MetafileFrameUnit.xml' path='doc/member[@name="MetafileFrameUnit.MetafileFrameUnitMillimeter"]/*'/>
    MetafileFrameUnitMillimeter = UnitMillimeter,
    /// <include file='MetafileFrameUnit.xml' path='doc/member[@name="MetafileFrameUnit.MetafileFrameUnitGdi"]/*'/>
    MetafileFrameUnitGdi,
}