// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT"]/*'/>
public enum AM_PROPERTY_DVDCOPYPROT
{
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_DVDCOPY_CHLG_KEY"]/*'/>
    AM_PROPERTY_DVDCOPY_CHLG_KEY = 0x01,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_DVDCOPY_DVD_KEY1"]/*'/>
    AM_PROPERTY_DVDCOPY_DVD_KEY1 = 0x02,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_DVDCOPY_DEC_KEY2"]/*'/>
    AM_PROPERTY_DVDCOPY_DEC_KEY2 = 0x03,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_DVDCOPY_TITLE_KEY"]/*'/>
    AM_PROPERTY_DVDCOPY_TITLE_KEY = 0x04,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_COPY_MACROVISION"]/*'/>
    AM_PROPERTY_COPY_MACROVISION = 0x05,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_DVDCOPY_REGION"]/*'/>
    AM_PROPERTY_DVDCOPY_REGION = 0x06,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_DVDCOPY_SET_COPY_STATE"]/*'/>
    AM_PROPERTY_DVDCOPY_SET_COPY_STATE = 0x07,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_COPY_ANALOG_COMPONENT"]/*'/>
    AM_PROPERTY_COPY_ANALOG_COMPONENT = 0x08,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_COPY_DIGITAL_CP"]/*'/>
    AM_PROPERTY_COPY_DIGITAL_CP = 0x09,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_COPY_DVD_SRM"]/*'/>
    AM_PROPERTY_COPY_DVD_SRM = 0x0a,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_DVDCOPY_SUPPORTS_NEW_KEYCOUNT"]/*'/>
    AM_PROPERTY_DVDCOPY_SUPPORTS_NEW_KEYCOUNT = 0x0b,
    /// <include file='AM_PROPERTY_DVDCOPYPROT.xml' path='doc/member[@name="AM_PROPERTY_DVDCOPYPROT.AM_PROPERTY_DVDCOPY_DISC_KEY"]/*'/>
    AM_PROPERTY_DVDCOPY_DISC_KEY = 0x80,
}