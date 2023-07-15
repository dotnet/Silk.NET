// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='DESKTOP_SLIDESHOW_STATE.xml' path='doc/member[@name="DESKTOP_SLIDESHOW_STATE"]/*'/>
[Flags]
public enum DESKTOP_SLIDESHOW_STATE
{
    /// <include file='DESKTOP_SLIDESHOW_STATE.xml' path='doc/member[@name="DESKTOP_SLIDESHOW_STATE.DSS_ENABLED"]/*'/>
    DSS_ENABLED = 0x1,
    /// <include file='DESKTOP_SLIDESHOW_STATE.xml' path='doc/member[@name="DESKTOP_SLIDESHOW_STATE.DSS_SLIDESHOW"]/*'/>
    DSS_SLIDESHOW = 0x2,
    /// <include file='DESKTOP_SLIDESHOW_STATE.xml' path='doc/member[@name="DESKTOP_SLIDESHOW_STATE.DSS_DISABLED_BY_REMOTE_SESSION"]/*'/>
    DSS_DISABLED_BY_REMOTE_SESSION = 0x4,
}