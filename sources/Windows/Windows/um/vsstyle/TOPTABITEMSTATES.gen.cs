// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TOPTABITEMSTATES.xml' path='doc/member[@name="TOPTABITEMSTATES"]/*'/>
public enum TOPTABITEMSTATES
{
    /// <include file='TOPTABITEMSTATES.xml' path='doc/member[@name="TOPTABITEMSTATES.TTIS_NORMAL"]/*'/>
    TTIS_NORMAL = 1,
    /// <include file='TOPTABITEMSTATES.xml' path='doc/member[@name="TOPTABITEMSTATES.TTIS_HOT"]/*'/>
    TTIS_HOT = 2,
    /// <include file='TOPTABITEMSTATES.xml' path='doc/member[@name="TOPTABITEMSTATES.TTIS_SELECTED"]/*'/>
    TTIS_SELECTED = 3,
    /// <include file='TOPTABITEMSTATES.xml' path='doc/member[@name="TOPTABITEMSTATES.TTIS_DISABLED"]/*'/>
    TTIS_DISABLED = 4,
    /// <include file='TOPTABITEMSTATES.xml' path='doc/member[@name="TOPTABITEMSTATES.TTIS_FOCUSED"]/*'/>
    TTIS_FOCUSED = 5,
}