// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC"]/*' />
public enum OLEMISC
{
    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_RECOMPOSEONRESIZE"]/*' />
    OLEMISC_RECOMPOSEONRESIZE = 0x1,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_ONLYICONIC"]/*' />
    OLEMISC_ONLYICONIC = 0x2,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_INSERTNOTREPLACE"]/*' />
    OLEMISC_INSERTNOTREPLACE = 0x4,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_STATIC"]/*' />
    OLEMISC_STATIC = 0x8,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_CANTLINKINSIDE"]/*' />
    OLEMISC_CANTLINKINSIDE = 0x10,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_CANLINKBYOLE1"]/*' />
    OLEMISC_CANLINKBYOLE1 = 0x20,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_ISLINKOBJECT"]/*' />
    OLEMISC_ISLINKOBJECT = 0x40,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_INSIDEOUT"]/*' />
    OLEMISC_INSIDEOUT = 0x80,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_ACTIVATEWHENVISIBLE"]/*' />
    OLEMISC_ACTIVATEWHENVISIBLE = 0x100,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_RENDERINGISDEVICEINDEPENDENT"]/*' />
    OLEMISC_RENDERINGISDEVICEINDEPENDENT = 0x200,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_INVISIBLEATRUNTIME"]/*' />
    OLEMISC_INVISIBLEATRUNTIME = 0x400,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_ALWAYSRUN"]/*' />
    OLEMISC_ALWAYSRUN = 0x800,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_ACTSLIKEBUTTON"]/*' />
    OLEMISC_ACTSLIKEBUTTON = 0x1000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_ACTSLIKELABEL"]/*' />
    OLEMISC_ACTSLIKELABEL = 0x2000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_NOUIACTIVATE"]/*' />
    OLEMISC_NOUIACTIVATE = 0x4000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_ALIGNABLE"]/*' />
    OLEMISC_ALIGNABLE = 0x8000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_SIMPLEFRAME"]/*' />
    OLEMISC_SIMPLEFRAME = 0x10000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_SETCLIENTSITEFIRST"]/*' />
    OLEMISC_SETCLIENTSITEFIRST = 0x20000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_IMEMODE"]/*' />
    OLEMISC_IMEMODE = 0x40000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_IGNOREACTIVATEWHENVISIBLE"]/*' />
    OLEMISC_IGNOREACTIVATEWHENVISIBLE = 0x80000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_WANTSTOMENUMERGE"]/*' />
    OLEMISC_WANTSTOMENUMERGE = 0x100000,

    /// <include file='OLEMISC.xml' path='doc/member[@name="OLEMISC.OLEMISC_SUPPORTSMULTILEVELUNDO"]/*' />
    OLEMISC_SUPPORTSMULTILEVELUNDO = 0x200000,
}
