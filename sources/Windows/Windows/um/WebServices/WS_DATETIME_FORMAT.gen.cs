// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_DATETIME_FORMAT.xml' path='doc/member[@name="WS_DATETIME_FORMAT"]/*'/>
public enum WS_DATETIME_FORMAT
{
    /// <include file='WS_DATETIME_FORMAT.xml' path='doc/member[@name="WS_DATETIME_FORMAT.WS_DATETIME_FORMAT_UTC"]/*'/>
    WS_DATETIME_FORMAT_UTC = 0,
    /// <include file='WS_DATETIME_FORMAT.xml' path='doc/member[@name="WS_DATETIME_FORMAT.WS_DATETIME_FORMAT_LOCAL"]/*'/>
    WS_DATETIME_FORMAT_LOCAL = 1,
    /// <include file='WS_DATETIME_FORMAT.xml' path='doc/member[@name="WS_DATETIME_FORMAT.WS_DATETIME_FORMAT_NONE"]/*'/>
    WS_DATETIME_FORMAT_NONE = 2,
}