// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='THUMBBUTTONFLAGS.xml' path='doc/member[@name="THUMBBUTTONFLAGS"]/*'/>
[Flags]
public enum THUMBBUTTONFLAGS
{
    /// <include file='THUMBBUTTONFLAGS.xml' path='doc/member[@name="THUMBBUTTONFLAGS.THBF_ENABLED"]/*'/>
    THBF_ENABLED = 0,
    /// <include file='THUMBBUTTONFLAGS.xml' path='doc/member[@name="THUMBBUTTONFLAGS.THBF_DISABLED"]/*'/>
    THBF_DISABLED = 0x1,
    /// <include file='THUMBBUTTONFLAGS.xml' path='doc/member[@name="THUMBBUTTONFLAGS.THBF_DISMISSONCLICK"]/*'/>
    THBF_DISMISSONCLICK = 0x2,
    /// <include file='THUMBBUTTONFLAGS.xml' path='doc/member[@name="THUMBBUTTONFLAGS.THBF_NOBACKGROUND"]/*'/>
    THBF_NOBACKGROUND = 0x4,
    /// <include file='THUMBBUTTONFLAGS.xml' path='doc/member[@name="THUMBBUTTONFLAGS.THBF_HIDDEN"]/*'/>
    THBF_HIDDEN = 0x8,
    /// <include file='THUMBBUTTONFLAGS.xml' path='doc/member[@name="THUMBBUTTONFLAGS.THBF_NONINTERACTIVE"]/*'/>
    THBF_NONINTERACTIVE = 0x10,
}