// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WINDOWPLACEMENT.xml' path='doc/member[@name="WINDOWPLACEMENT"]/*'/>
public partial struct WINDOWPLACEMENT
{
    /// <include file='WINDOWPLACEMENT.xml' path='doc/member[@name="WINDOWPLACEMENT.length"]/*'/>
    public uint length;
    /// <include file='WINDOWPLACEMENT.xml' path='doc/member[@name="WINDOWPLACEMENT.flags"]/*'/>
    public uint flags;
    /// <include file='WINDOWPLACEMENT.xml' path='doc/member[@name="WINDOWPLACEMENT.showCmd"]/*'/>
    public uint showCmd;
    /// <include file='WINDOWPLACEMENT.xml' path='doc/member[@name="WINDOWPLACEMENT.ptMinPosition"]/*'/>
    public POINT ptMinPosition;
    /// <include file='WINDOWPLACEMENT.xml' path='doc/member[@name="WINDOWPLACEMENT.ptMaxPosition"]/*'/>
    public POINT ptMaxPosition;
    /// <include file='WINDOWPLACEMENT.xml' path='doc/member[@name="WINDOWPLACEMENT.rcNormalPosition"]/*'/>
    public RECT rcNormalPosition;
}