// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS"]/*' />
public enum APPINFODATAFLAGS
{
    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_DISPLAYNAME"]/*' />
    AIM_DISPLAYNAME = 0x1,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_VERSION"]/*' />
    AIM_VERSION = 0x2,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_PUBLISHER"]/*' />
    AIM_PUBLISHER = 0x4,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_PRODUCTID"]/*' />
    AIM_PRODUCTID = 0x8,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_REGISTEREDOWNER"]/*' />
    AIM_REGISTEREDOWNER = 0x10,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_REGISTEREDCOMPANY"]/*' />
    AIM_REGISTEREDCOMPANY = 0x20,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_LANGUAGE"]/*' />
    AIM_LANGUAGE = 0x40,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_SUPPORTURL"]/*' />
    AIM_SUPPORTURL = 0x80,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_SUPPORTTELEPHONE"]/*' />
    AIM_SUPPORTTELEPHONE = 0x100,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_HELPLINK"]/*' />
    AIM_HELPLINK = 0x200,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_INSTALLLOCATION"]/*' />
    AIM_INSTALLLOCATION = 0x400,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_INSTALLSOURCE"]/*' />
    AIM_INSTALLSOURCE = 0x800,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_INSTALLDATE"]/*' />
    AIM_INSTALLDATE = 0x1000,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_CONTACT"]/*' />
    AIM_CONTACT = 0x4000,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_COMMENTS"]/*' />
    AIM_COMMENTS = 0x8000,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_IMAGE"]/*' />
    AIM_IMAGE = 0x20000,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_READMEURL"]/*' />
    AIM_READMEURL = 0x40000,

    /// <include file='APPINFODATAFLAGS.xml' path='doc/member[@name="APPINFODATAFLAGS.AIM_UPDATEINFOURL"]/*' />
    AIM_UPDATEINFOURL = 0x80000,
}
