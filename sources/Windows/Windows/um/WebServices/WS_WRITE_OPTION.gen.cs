// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_WRITE_OPTION.xml' path='doc/member[@name="WS_WRITE_OPTION"]/*'/>
public enum WS_WRITE_OPTION
{
    /// <include file='WS_WRITE_OPTION.xml' path='doc/member[@name="WS_WRITE_OPTION.WS_WRITE_REQUIRED_VALUE"]/*'/>
    WS_WRITE_REQUIRED_VALUE = 1,
    /// <include file='WS_WRITE_OPTION.xml' path='doc/member[@name="WS_WRITE_OPTION.WS_WRITE_REQUIRED_POINTER"]/*'/>
    WS_WRITE_REQUIRED_POINTER = 2,
    /// <include file='WS_WRITE_OPTION.xml' path='doc/member[@name="WS_WRITE_OPTION.WS_WRITE_NILLABLE_VALUE"]/*'/>
    WS_WRITE_NILLABLE_VALUE = 3,
    /// <include file='WS_WRITE_OPTION.xml' path='doc/member[@name="WS_WRITE_OPTION.WS_WRITE_NILLABLE_POINTER"]/*'/>
    WS_WRITE_NILLABLE_POINTER = 4,
}