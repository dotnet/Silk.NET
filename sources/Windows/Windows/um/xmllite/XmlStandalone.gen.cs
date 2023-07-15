// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='XmlStandalone.xml' path='doc/member[@name="XmlStandalone"]/*'/>
public enum XmlStandalone
{
    /// <include file='XmlStandalone.xml' path='doc/member[@name="XmlStandalone.XmlStandalone_Omit"]/*'/>
    XmlStandalone_Omit = 0,
    /// <include file='XmlStandalone.xml' path='doc/member[@name="XmlStandalone.XmlStandalone_Yes"]/*'/>
    XmlStandalone_Yes = 1,
    /// <include file='XmlStandalone.xml' path='doc/member[@name="XmlStandalone.XmlStandalone_No"]/*'/>
    XmlStandalone_No = 2,
    /// <include file='XmlStandalone.xml' path='doc/member[@name="XmlStandalone._XmlStandalone_Last"]/*'/>
    _XmlStandalone_Last = 2,
}