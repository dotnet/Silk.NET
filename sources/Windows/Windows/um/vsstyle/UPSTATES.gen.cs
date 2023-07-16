// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='UPSTATES.xml' path='doc/member[@name="UPSTATES"]/*'/>
public enum UPSTATES
{
    /// <include file='UPSTATES.xml' path='doc/member[@name="UPSTATES.UPS_NORMAL"]/*'/>
    UPS_NORMAL = 1,
    /// <include file='UPSTATES.xml' path='doc/member[@name="UPSTATES.UPS_HOT"]/*'/>
    UPS_HOT = 2,
    /// <include file='UPSTATES.xml' path='doc/member[@name="UPSTATES.UPS_PRESSED"]/*'/>
    UPS_PRESSED = 3,
    /// <include file='UPSTATES.xml' path='doc/member[@name="UPSTATES.UPS_DISABLED"]/*'/>
    UPS_DISABLED = 4,
}