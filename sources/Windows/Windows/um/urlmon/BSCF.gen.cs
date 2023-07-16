// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='BSCF.xml' path='doc/member[@name="BSCF"]/*'/>
[Flags]
public enum BSCF
{
    /// <include file='BSCF.xml' path='doc/member[@name="BSCF.BSCF_FIRSTDATANOTIFICATION"]/*'/>
    BSCF_FIRSTDATANOTIFICATION = 0x1,
    /// <include file='BSCF.xml' path='doc/member[@name="BSCF.BSCF_INTERMEDIATEDATANOTIFICATION"]/*'/>
    BSCF_INTERMEDIATEDATANOTIFICATION = 0x2,
    /// <include file='BSCF.xml' path='doc/member[@name="BSCF.BSCF_LASTDATANOTIFICATION"]/*'/>
    BSCF_LASTDATANOTIFICATION = 0x4,
    /// <include file='BSCF.xml' path='doc/member[@name="BSCF.BSCF_DATAFULLYAVAILABLE"]/*'/>
    BSCF_DATAFULLYAVAILABLE = 0x8,
    /// <include file='BSCF.xml' path='doc/member[@name="BSCF.BSCF_AVAILABLEDATASIZEUNKNOWN"]/*'/>
    BSCF_AVAILABLEDATASIZEUNKNOWN = 0x10,
    /// <include file='BSCF.xml' path='doc/member[@name="BSCF.BSCF_SKIPDRAINDATAFORFILEURLS"]/*'/>
    BSCF_SKIPDRAINDATAFORFILEURLS = 0x20,
    /// <include file='BSCF.xml' path='doc/member[@name="BSCF.BSCF_64BITLENGTHDOWNLOAD"]/*'/>
    BSCF_64BITLENGTHDOWNLOAD = 0x40,
}