// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_READ_OPTION.xml' path='doc/member[@name="WS_READ_OPTION"]/*'/>
public enum WS_READ_OPTION
{
    /// <include file='WS_READ_OPTION.xml' path='doc/member[@name="WS_READ_OPTION.WS_READ_REQUIRED_VALUE"]/*'/>
    WS_READ_REQUIRED_VALUE = 1,
    /// <include file='WS_READ_OPTION.xml' path='doc/member[@name="WS_READ_OPTION.WS_READ_REQUIRED_POINTER"]/*'/>
    WS_READ_REQUIRED_POINTER = 2,
    /// <include file='WS_READ_OPTION.xml' path='doc/member[@name="WS_READ_OPTION.WS_READ_OPTIONAL_POINTER"]/*'/>
    WS_READ_OPTIONAL_POINTER = 3,
    /// <include file='WS_READ_OPTION.xml' path='doc/member[@name="WS_READ_OPTION.WS_READ_NILLABLE_POINTER"]/*'/>
    WS_READ_NILLABLE_POINTER = 4,
    /// <include file='WS_READ_OPTION.xml' path='doc/member[@name="WS_READ_OPTION.WS_READ_NILLABLE_VALUE"]/*'/>
    WS_READ_NILLABLE_VALUE = 5,
}