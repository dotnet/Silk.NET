// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech"]/*'/>
public enum VMRDeinterlaceTech
{
    /// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech.DeinterlaceTech_Unknown"]/*'/>
    DeinterlaceTech_Unknown = 0,
    /// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech.DeinterlaceTech_BOBLineReplicate"]/*'/>
    DeinterlaceTech_BOBLineReplicate = 0x1,
    /// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech.DeinterlaceTech_BOBVerticalStretch"]/*'/>
    DeinterlaceTech_BOBVerticalStretch = 0x2,
    /// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech.DeinterlaceTech_MedianFiltering"]/*'/>
    DeinterlaceTech_MedianFiltering = 0x4,
    /// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech.DeinterlaceTech_EdgeFiltering"]/*'/>
    DeinterlaceTech_EdgeFiltering = 0x10,
    /// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech.DeinterlaceTech_FieldAdaptive"]/*'/>
    DeinterlaceTech_FieldAdaptive = 0x20,
    /// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech.DeinterlaceTech_PixelAdaptive"]/*'/>
    DeinterlaceTech_PixelAdaptive = 0x40,
    /// <include file='VMRDeinterlaceTech.xml' path='doc/member[@name="VMRDeinterlaceTech.DeinterlaceTech_MotionVectorSteered"]/*'/>
    DeinterlaceTech_MotionVectorSteered = 0x80,
}