// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty"]/*' />
public enum XmlReaderProperty
{
    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty.XmlReaderProperty_MultiLanguage"]/*' />
    XmlReaderProperty_MultiLanguage = 0,

    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty.XmlReaderProperty_ConformanceLevel"]/*' />
    XmlReaderProperty_ConformanceLevel = (XmlReaderProperty_MultiLanguage + 1),

    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty.XmlReaderProperty_RandomAccess"]/*' />
    XmlReaderProperty_RandomAccess = (XmlReaderProperty_ConformanceLevel + 1),

    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty.XmlReaderProperty_XmlResolver"]/*' />
    XmlReaderProperty_XmlResolver = (XmlReaderProperty_RandomAccess + 1),

    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty.XmlReaderProperty_DtdProcessing"]/*' />
    XmlReaderProperty_DtdProcessing = (XmlReaderProperty_XmlResolver + 1),

    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty.XmlReaderProperty_ReadState"]/*' />
    XmlReaderProperty_ReadState = (XmlReaderProperty_DtdProcessing + 1),

    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty.XmlReaderProperty_MaxElementDepth"]/*' />
    XmlReaderProperty_MaxElementDepth = (XmlReaderProperty_ReadState + 1),

    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty.XmlReaderProperty_MaxEntityExpansion"]/*' />
    XmlReaderProperty_MaxEntityExpansion = (XmlReaderProperty_MaxElementDepth + 1),

    /// <include file='XmlReaderProperty.xml' path='doc/member[@name="XmlReaderProperty._XmlReaderProperty_Last"]/*' />
    _XmlReaderProperty_Last = XmlReaderProperty_MaxEntityExpansion,
}
