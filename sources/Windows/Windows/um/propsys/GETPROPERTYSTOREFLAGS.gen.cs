// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS"]/*'/>
[Flags]
public enum GETPROPERTYSTOREFLAGS
{
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_DEFAULT"]/*'/>
    GPS_DEFAULT = 0,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_HANDLERPROPERTIESONLY"]/*'/>
    GPS_HANDLERPROPERTIESONLY = 0x1,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_READWRITE"]/*'/>
    GPS_READWRITE = 0x2,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_TEMPORARY"]/*'/>
    GPS_TEMPORARY = 0x4,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_FASTPROPERTIESONLY"]/*'/>
    GPS_FASTPROPERTIESONLY = 0x8,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_OPENSLOWITEM"]/*'/>
    GPS_OPENSLOWITEM = 0x10,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_DELAYCREATION"]/*'/>
    GPS_DELAYCREATION = 0x20,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_BESTEFFORT"]/*'/>
    GPS_BESTEFFORT = 0x40,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_NO_OPLOCK"]/*'/>
    GPS_NO_OPLOCK = 0x80,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_PREFERQUERYPROPERTIES"]/*'/>
    GPS_PREFERQUERYPROPERTIES = 0x100,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_EXTRINSICPROPERTIES"]/*'/>
    GPS_EXTRINSICPROPERTIES = 0x200,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_EXTRINSICPROPERTIESONLY"]/*'/>
    GPS_EXTRINSICPROPERTIESONLY = 0x400,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_VOLATILEPROPERTIES"]/*'/>
    GPS_VOLATILEPROPERTIES = 0x800,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_VOLATILEPROPERTIESONLY"]/*'/>
    GPS_VOLATILEPROPERTIESONLY = 0x1000,
    /// <include file='GETPROPERTYSTOREFLAGS.xml' path='doc/member[@name="GETPROPERTYSTOREFLAGS.GPS_MASK_VALID"]/*'/>
    GPS_MASK_VALID = 0x1fff,
}