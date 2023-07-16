// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DWMNCRENDERINGPOLICY.xml' path='doc/member[@name="DWMNCRENDERINGPOLICY"]/*'/>
public enum DWMNCRENDERINGPOLICY
{
    /// <include file='DWMNCRENDERINGPOLICY.xml' path='doc/member[@name="DWMNCRENDERINGPOLICY.DWMNCRP_USEWINDOWSTYLE"]/*'/>
    DWMNCRP_USEWINDOWSTYLE,
    /// <include file='DWMNCRENDERINGPOLICY.xml' path='doc/member[@name="DWMNCRENDERINGPOLICY.DWMNCRP_DISABLED"]/*'/>
    DWMNCRP_DISABLED,
    /// <include file='DWMNCRENDERINGPOLICY.xml' path='doc/member[@name="DWMNCRENDERINGPOLICY.DWMNCRP_ENABLED"]/*'/>
    DWMNCRP_ENABLED,
    /// <include file='DWMNCRENDERINGPOLICY.xml' path='doc/member[@name="DWMNCRENDERINGPOLICY.DWMNCRP_LAST"]/*'/>
    DWMNCRP_LAST,
}