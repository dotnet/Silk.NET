// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_TYPE_MAPPING.xml' path='doc/member[@name="WS_TYPE_MAPPING"]/*'/>
public enum WS_TYPE_MAPPING
{
    /// <include file='WS_TYPE_MAPPING.xml' path='doc/member[@name="WS_TYPE_MAPPING.WS_ELEMENT_TYPE_MAPPING"]/*'/>
    WS_ELEMENT_TYPE_MAPPING = 1,
    /// <include file='WS_TYPE_MAPPING.xml' path='doc/member[@name="WS_TYPE_MAPPING.WS_ATTRIBUTE_TYPE_MAPPING"]/*'/>
    WS_ATTRIBUTE_TYPE_MAPPING = 2,
    /// <include file='WS_TYPE_MAPPING.xml' path='doc/member[@name="WS_TYPE_MAPPING.WS_ELEMENT_CONTENT_TYPE_MAPPING"]/*'/>
    WS_ELEMENT_CONTENT_TYPE_MAPPING = 3,
    /// <include file='WS_TYPE_MAPPING.xml' path='doc/member[@name="WS_TYPE_MAPPING.WS_ANY_ELEMENT_TYPE_MAPPING"]/*'/>
    WS_ANY_ELEMENT_TYPE_MAPPING = 4,
}