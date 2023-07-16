// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange"]/*'/>
public enum MFNominalRange
{
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_Unknown"]/*'/>
    MFNominalRange_Unknown = 0,
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_Normal"]/*'/>
    MFNominalRange_Normal = 1,
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_Wide"]/*'/>
    MFNominalRange_Wide = 2,
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_0_255"]/*'/>
    MFNominalRange_0_255 = 1,
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_16_235"]/*'/>
    MFNominalRange_16_235 = 2,
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_48_208"]/*'/>
    MFNominalRange_48_208 = 3,
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_64_127"]/*'/>
    MFNominalRange_64_127 = 4,
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_Last"]/*'/>
    MFNominalRange_Last = (MFNominalRange_64_127 + 1),
    /// <include file='MFNominalRange.xml' path='doc/member[@name="MFNominalRange.MFNominalRange_ForceDWORD"]/*'/>
    MFNominalRange_ForceDWORD = 0x7fffffff,
}