// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VERTSCROLLSTATES.xml' path='doc/member[@name="VERTSCROLLSTATES"]/*'/>
public enum VERTSCROLLSTATES
{
    /// <include file='VERTSCROLLSTATES.xml' path='doc/member[@name="VERTSCROLLSTATES.VSS_NORMAL"]/*'/>
    VSS_NORMAL = 1,
    /// <include file='VERTSCROLLSTATES.xml' path='doc/member[@name="VERTSCROLLSTATES.VSS_HOT"]/*'/>
    VSS_HOT = 2,
    /// <include file='VERTSCROLLSTATES.xml' path='doc/member[@name="VERTSCROLLSTATES.VSS_PUSHED"]/*'/>
    VSS_PUSHED = 3,
    /// <include file='VERTSCROLLSTATES.xml' path='doc/member[@name="VERTSCROLLSTATES.VSS_DISABLED"]/*'/>
    VSS_DISABLED = 4,
}