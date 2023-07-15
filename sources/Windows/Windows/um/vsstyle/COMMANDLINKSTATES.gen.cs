// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='COMMANDLINKSTATES.xml' path='doc/member[@name="COMMANDLINKSTATES"]/*'/>
public enum COMMANDLINKSTATES
{
    /// <include file='COMMANDLINKSTATES.xml' path='doc/member[@name="COMMANDLINKSTATES.CMDLS_NORMAL"]/*'/>
    CMDLS_NORMAL = 1,
    /// <include file='COMMANDLINKSTATES.xml' path='doc/member[@name="COMMANDLINKSTATES.CMDLS_HOT"]/*'/>
    CMDLS_HOT = 2,
    /// <include file='COMMANDLINKSTATES.xml' path='doc/member[@name="COMMANDLINKSTATES.CMDLS_PRESSED"]/*'/>
    CMDLS_PRESSED = 3,
    /// <include file='COMMANDLINKSTATES.xml' path='doc/member[@name="COMMANDLINKSTATES.CMDLS_DISABLED"]/*'/>
    CMDLS_DISABLED = 4,
    /// <include file='COMMANDLINKSTATES.xml' path='doc/member[@name="COMMANDLINKSTATES.CMDLS_DEFAULTED"]/*'/>
    CMDLS_DEFAULTED = 5,
    /// <include file='COMMANDLINKSTATES.xml' path='doc/member[@name="COMMANDLINKSTATES.CMDLS_DEFAULTED_ANIMATING"]/*'/>
    CMDLS_DEFAULTED_ANIMATING = 6,
}