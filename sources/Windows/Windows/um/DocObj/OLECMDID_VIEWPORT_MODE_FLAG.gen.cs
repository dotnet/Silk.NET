// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='OLECMDID_VIEWPORT_MODE_FLAG.xml' path='doc/member[@name="OLECMDID_VIEWPORT_MODE_FLAG"]/*'/>
[Flags]
public enum OLECMDID_VIEWPORT_MODE_FLAG
{
    /// <include file='OLECMDID_VIEWPORT_MODE_FLAG.xml' path='doc/member[@name="OLECMDID_VIEWPORT_MODE_FLAG.OLECMDIDF_VIEWPORTMODE_FIXED_LAYOUT_WIDTH"]/*'/>
    OLECMDIDF_VIEWPORTMODE_FIXED_LAYOUT_WIDTH = 0x00000001,
    /// <include file='OLECMDID_VIEWPORT_MODE_FLAG.xml' path='doc/member[@name="OLECMDID_VIEWPORT_MODE_FLAG.OLECMDIDF_VIEWPORTMODE_EXCLUDE_VISUAL_BOTTOM"]/*'/>
    OLECMDIDF_VIEWPORTMODE_EXCLUDE_VISUAL_BOTTOM = 0x00000002,
    /// <include file='OLECMDID_VIEWPORT_MODE_FLAG.xml' path='doc/member[@name="OLECMDID_VIEWPORT_MODE_FLAG.OLECMDIDF_VIEWPORTMODE_FIXED_LAYOUT_WIDTH_VALID"]/*'/>
    OLECMDIDF_VIEWPORTMODE_FIXED_LAYOUT_WIDTH_VALID = 0x00010000,
    /// <include file='OLECMDID_VIEWPORT_MODE_FLAG.xml' path='doc/member[@name="OLECMDID_VIEWPORT_MODE_FLAG.OLECMDIDF_VIEWPORTMODE_EXCLUDE_VISUAL_BOTTOM_VALID"]/*'/>
    OLECMDIDF_VIEWPORTMODE_EXCLUDE_VISUAL_BOTTOM_VALID = 0x00020000,
}