// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMDAYSTATE.xml' path='doc/member[@name="NMDAYSTATE"]/*'/>
public unsafe partial struct NMDAYSTATE
{
    /// <include file='NMDAYSTATE.xml' path='doc/member[@name="NMDAYSTATE.nmhdr"]/*'/>
    public NMHDR nmhdr;
    /// <include file='NMDAYSTATE.xml' path='doc/member[@name="NMDAYSTATE.stStart"]/*'/>
    public SYSTEMTIME stStart;
    /// <include file='NMDAYSTATE.xml' path='doc/member[@name="NMDAYSTATE.cDayState"]/*'/>
    public int cDayState;
    /// <include file='NMDAYSTATE.xml' path='doc/member[@name="NMDAYSTATE.prgDayState"]/*'/>
    [NativeTypeName("LPMONTHDAYSTATE")]
    public uint* prgDayState;
}