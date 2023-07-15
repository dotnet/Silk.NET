// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_PROPERTY_FRAMESTEP.xml' path='doc/member[@name="AM_PROPERTY_FRAMESTEP"]/*'/>
public enum AM_PROPERTY_FRAMESTEP
{
    /// <include file='AM_PROPERTY_FRAMESTEP.xml' path='doc/member[@name="AM_PROPERTY_FRAMESTEP.AM_PROPERTY_FRAMESTEP_STEP"]/*'/>
    AM_PROPERTY_FRAMESTEP_STEP = 0x01,
    /// <include file='AM_PROPERTY_FRAMESTEP.xml' path='doc/member[@name="AM_PROPERTY_FRAMESTEP.AM_PROPERTY_FRAMESTEP_CANCEL"]/*'/>
    AM_PROPERTY_FRAMESTEP_CANCEL = 0x02,
    /// <include file='AM_PROPERTY_FRAMESTEP.xml' path='doc/member[@name="AM_PROPERTY_FRAMESTEP.AM_PROPERTY_FRAMESTEP_CANSTEP"]/*'/>
    AM_PROPERTY_FRAMESTEP_CANSTEP = 0x03,
    /// <include file='AM_PROPERTY_FRAMESTEP.xml' path='doc/member[@name="AM_PROPERTY_FRAMESTEP.AM_PROPERTY_FRAMESTEP_CANSTEPMULTIPLE"]/*'/>
    AM_PROPERTY_FRAMESTEP_CANSTEPMULTIPLE = 0x04,
}