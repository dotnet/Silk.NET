// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='XmlConformanceLevel.xml' path='doc/member[@name="XmlConformanceLevel"]/*'/>
public enum XmlConformanceLevel
{
    /// <include file='XmlConformanceLevel.xml' path='doc/member[@name="XmlConformanceLevel.XmlConformanceLevel_Auto"]/*'/>
    XmlConformanceLevel_Auto = 0,
    /// <include file='XmlConformanceLevel.xml' path='doc/member[@name="XmlConformanceLevel.XmlConformanceLevel_Fragment"]/*'/>
    XmlConformanceLevel_Fragment = 1,
    /// <include file='XmlConformanceLevel.xml' path='doc/member[@name="XmlConformanceLevel.XmlConformanceLevel_Document"]/*'/>
    XmlConformanceLevel_Document = 2,
    /// <include file='XmlConformanceLevel.xml' path='doc/member[@name="XmlConformanceLevel._XmlConformanceLevel_Last"]/*'/>
    _XmlConformanceLevel_Last = 2,
}