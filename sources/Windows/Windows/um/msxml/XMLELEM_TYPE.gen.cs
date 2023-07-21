// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='XMLELEM_TYPE.xml' path='doc/member[@name="XMLELEM_TYPE"]/*' />
public enum XMLELEM_TYPE
{
    /// <include file='XMLELEM_TYPE.xml' path='doc/member[@name="XMLELEM_TYPE.XMLELEMTYPE_ELEMENT"]/*' />
    XMLELEMTYPE_ELEMENT = 0,

    /// <include file='XMLELEM_TYPE.xml' path='doc/member[@name="XMLELEM_TYPE.XMLELEMTYPE_TEXT"]/*' />
    XMLELEMTYPE_TEXT = (XMLELEMTYPE_ELEMENT + 1),

    /// <include file='XMLELEM_TYPE.xml' path='doc/member[@name="XMLELEM_TYPE.XMLELEMTYPE_COMMENT"]/*' />
    XMLELEMTYPE_COMMENT = (XMLELEMTYPE_TEXT + 1),

    /// <include file='XMLELEM_TYPE.xml' path='doc/member[@name="XMLELEM_TYPE.XMLELEMTYPE_DOCUMENT"]/*' />
    XMLELEMTYPE_DOCUMENT = (XMLELEMTYPE_COMMENT + 1),

    /// <include file='XMLELEM_TYPE.xml' path='doc/member[@name="XMLELEM_TYPE.XMLELEMTYPE_DTD"]/*' />
    XMLELEMTYPE_DTD = (XMLELEMTYPE_DOCUMENT + 1),

    /// <include file='XMLELEM_TYPE.xml' path='doc/member[@name="XMLELEM_TYPE.XMLELEMTYPE_PI"]/*' />
    XMLELEMTYPE_PI = (XMLELEMTYPE_DTD + 1),

    /// <include file='XMLELEM_TYPE.xml' path='doc/member[@name="XMLELEM_TYPE.XMLELEMTYPE_OTHER"]/*' />
    XMLELEMTYPE_OTHER = (XMLELEMTYPE_PI + 1),
}
