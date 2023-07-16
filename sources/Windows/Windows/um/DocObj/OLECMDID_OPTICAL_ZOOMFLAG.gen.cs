// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='OLECMDID_OPTICAL_ZOOMFLAG.xml' path='doc/member[@name="OLECMDID_OPTICAL_ZOOMFLAG"]/*'/>
[Flags]
public enum OLECMDID_OPTICAL_ZOOMFLAG
{
    /// <include file='OLECMDID_OPTICAL_ZOOMFLAG.xml' path='doc/member[@name="OLECMDID_OPTICAL_ZOOMFLAG.OLECMDIDF_OPTICAL_ZOOM_NOPERSIST"]/*'/>
    OLECMDIDF_OPTICAL_ZOOM_NOPERSIST = 0x00000001,
    /// <include file='OLECMDID_OPTICAL_ZOOMFLAG.xml' path='doc/member[@name="OLECMDID_OPTICAL_ZOOMFLAG.OLECMDIDF_OPTICAL_ZOOM_NOLAYOUT"]/*'/>
    OLECMDIDF_OPTICAL_ZOOM_NOLAYOUT = 0x00000010,
    /// <include file='OLECMDID_OPTICAL_ZOOMFLAG.xml' path='doc/member[@name="OLECMDID_OPTICAL_ZOOMFLAG.OLECMDIDF_OPTICAL_ZOOM_NOTRANSIENT"]/*'/>
    OLECMDIDF_OPTICAL_ZOOM_NOTRANSIENT = 0x00000020,
    /// <include file='OLECMDID_OPTICAL_ZOOMFLAG.xml' path='doc/member[@name="OLECMDID_OPTICAL_ZOOMFLAG.OLECMDIDF_OPTICAL_ZOOM_RELOADFORNEWTAB"]/*'/>
    OLECMDIDF_OPTICAL_ZOOM_RELOADFORNEWTAB = 0x00000040,
}