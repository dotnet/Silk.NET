// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_ENVELOPE_VERSION.xml' path='doc/member[@name="WS_ENVELOPE_VERSION"]/*'/>
public enum WS_ENVELOPE_VERSION
{
    /// <include file='WS_ENVELOPE_VERSION.xml' path='doc/member[@name="WS_ENVELOPE_VERSION.WS_ENVELOPE_VERSION_SOAP_1_1"]/*'/>
    WS_ENVELOPE_VERSION_SOAP_1_1 = 1,
    /// <include file='WS_ENVELOPE_VERSION.xml' path='doc/member[@name="WS_ENVELOPE_VERSION.WS_ENVELOPE_VERSION_SOAP_1_2"]/*'/>
    WS_ENVELOPE_VERSION_SOAP_1_2 = 2,
    /// <include file='WS_ENVELOPE_VERSION.xml' path='doc/member[@name="WS_ENVELOPE_VERSION.WS_ENVELOPE_VERSION_NONE"]/*'/>
    WS_ENVELOPE_VERSION_NONE = 3,
}