// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BORDER_VSCROLLSTATES.xml' path='doc/member[@name="BORDER_VSCROLLSTATES"]/*'/>
public enum BORDER_VSCROLLSTATES
{
    /// <include file='BORDER_VSCROLLSTATES.xml' path='doc/member[@name="BORDER_VSCROLLSTATES.LBPSV_NORMAL"]/*'/>
    LBPSV_NORMAL = 1,
    /// <include file='BORDER_VSCROLLSTATES.xml' path='doc/member[@name="BORDER_VSCROLLSTATES.LBPSV_FOCUSED"]/*'/>
    LBPSV_FOCUSED = 2,
    /// <include file='BORDER_VSCROLLSTATES.xml' path='doc/member[@name="BORDER_VSCROLLSTATES.LBPSV_HOT"]/*'/>
    LBPSV_HOT = 3,
    /// <include file='BORDER_VSCROLLSTATES.xml' path='doc/member[@name="BORDER_VSCROLLSTATES.LBPSV_DISABLED"]/*'/>
    LBPSV_DISABLED = 4,
}