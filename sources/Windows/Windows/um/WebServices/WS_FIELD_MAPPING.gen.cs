// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING"]/*' />
public enum WS_FIELD_MAPPING
{
    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_TYPE_ATTRIBUTE_FIELD_MAPPING"]/*' />
    WS_TYPE_ATTRIBUTE_FIELD_MAPPING = 0,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_ATTRIBUTE_FIELD_MAPPING"]/*' />
    WS_ATTRIBUTE_FIELD_MAPPING = 1,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_ELEMENT_FIELD_MAPPING"]/*' />
    WS_ELEMENT_FIELD_MAPPING = 2,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_REPEATING_ELEMENT_FIELD_MAPPING"]/*' />
    WS_REPEATING_ELEMENT_FIELD_MAPPING = 3,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_TEXT_FIELD_MAPPING"]/*' />
    WS_TEXT_FIELD_MAPPING = 4,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_NO_FIELD_MAPPING"]/*' />
    WS_NO_FIELD_MAPPING = 5,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_XML_ATTRIBUTE_FIELD_MAPPING"]/*' />
    WS_XML_ATTRIBUTE_FIELD_MAPPING = 6,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_ELEMENT_CHOICE_FIELD_MAPPING"]/*' />
    WS_ELEMENT_CHOICE_FIELD_MAPPING = 7,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_REPEATING_ELEMENT_CHOICE_FIELD_MAPPING"]/*' />
    WS_REPEATING_ELEMENT_CHOICE_FIELD_MAPPING = 8,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_ANY_ELEMENT_FIELD_MAPPING"]/*' />
    WS_ANY_ELEMENT_FIELD_MAPPING = 9,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_REPEATING_ANY_ELEMENT_FIELD_MAPPING"]/*' />
    WS_REPEATING_ANY_ELEMENT_FIELD_MAPPING = 10,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_ANY_CONTENT_FIELD_MAPPING"]/*' />
    WS_ANY_CONTENT_FIELD_MAPPING = 11,

    /// <include file='WS_FIELD_MAPPING.xml' path='doc/member[@name="WS_FIELD_MAPPING.WS_ANY_ATTRIBUTES_FIELD_MAPPING"]/*' />
    WS_ANY_ATTRIBUTES_FIELD_MAPPING = 12,
}
