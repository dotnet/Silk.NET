// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='VPCOLORFLAGS.xml' path='doc/member[@name="VPCOLORFLAGS"]/*'/>
[Flags]
public enum VPCOLORFLAGS
{
    /// <include file='VPCOLORFLAGS.xml' path='doc/member[@name="VPCOLORFLAGS.VPCF_TEXT"]/*'/>
    VPCF_TEXT = 1,
    /// <include file='VPCOLORFLAGS.xml' path='doc/member[@name="VPCOLORFLAGS.VPCF_BACKGROUND"]/*'/>
    VPCF_BACKGROUND = 2,
    /// <include file='VPCOLORFLAGS.xml' path='doc/member[@name="VPCOLORFLAGS.VPCF_SORTCOLUMN"]/*'/>
    VPCF_SORTCOLUMN = 3,
    /// <include file='VPCOLORFLAGS.xml' path='doc/member[@name="VPCOLORFLAGS.VPCF_SUBTEXT"]/*'/>
    VPCF_SUBTEXT = 4,
    /// <include file='VPCOLORFLAGS.xml' path='doc/member[@name="VPCOLORFLAGS.VPCF_TEXTBACKGROUND"]/*'/>
    VPCF_TEXTBACKGROUND = 5,
}