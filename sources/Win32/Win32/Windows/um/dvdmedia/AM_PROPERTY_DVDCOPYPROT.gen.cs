// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_PROPERTY_DVDCOPYPROT
{
    AM_PROPERTY_DVDCOPY_CHLG_KEY = 0x01,
    AM_PROPERTY_DVDCOPY_DVD_KEY1 = 0x02,
    AM_PROPERTY_DVDCOPY_DEC_KEY2 = 0x03,
    AM_PROPERTY_DVDCOPY_TITLE_KEY = 0x04,
    AM_PROPERTY_COPY_MACROVISION = 0x05,
    AM_PROPERTY_DVDCOPY_REGION = 0x06,
    AM_PROPERTY_DVDCOPY_SET_COPY_STATE = 0x07,
    AM_PROPERTY_COPY_ANALOG_COMPONENT = 0x08,
    AM_PROPERTY_COPY_DIGITAL_CP = 0x09,
    AM_PROPERTY_COPY_DVD_SRM = 0x0a,
    AM_PROPERTY_DVDCOPY_SUPPORTS_NEW_KEYCOUNT = 0x0b,
    AM_PROPERTY_DVDCOPY_DISC_KEY = 0x80,
}
