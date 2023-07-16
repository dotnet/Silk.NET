// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MINMAXINFO.xml' path='doc/member[@name="MINMAXINFO"]/*'/>
public partial struct MINMAXINFO
{
    /// <include file='MINMAXINFO.xml' path='doc/member[@name="MINMAXINFO.ptReserved"]/*'/>
    public POINT ptReserved;
    /// <include file='MINMAXINFO.xml' path='doc/member[@name="MINMAXINFO.ptMaxSize"]/*'/>
    public POINT ptMaxSize;
    /// <include file='MINMAXINFO.xml' path='doc/member[@name="MINMAXINFO.ptMaxPosition"]/*'/>
    public POINT ptMaxPosition;
    /// <include file='MINMAXINFO.xml' path='doc/member[@name="MINMAXINFO.ptMinTrackSize"]/*'/>
    public POINT ptMinTrackSize;
    /// <include file='MINMAXINFO.xml' path='doc/member[@name="MINMAXINFO.ptMaxTrackSize"]/*'/>
    public POINT ptMaxTrackSize;
}