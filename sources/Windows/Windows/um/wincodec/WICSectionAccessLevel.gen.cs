// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICSectionAccessLevel.xml' path='doc/member[@name="WICSectionAccessLevel"]/*'/>
public enum WICSectionAccessLevel
{
    /// <include file='WICSectionAccessLevel.xml' path='doc/member[@name="WICSectionAccessLevel.WICSectionAccessLevelRead"]/*'/>
    WICSectionAccessLevelRead = 0x1,
    /// <include file='WICSectionAccessLevel.xml' path='doc/member[@name="WICSectionAccessLevel.WICSectionAccessLevelReadWrite"]/*'/>
    WICSectionAccessLevelReadWrite = 0x3,
    /// <include file='WICSectionAccessLevel.xml' path='doc/member[@name="WICSectionAccessLevel.WICSectionAccessLevel_FORCE_DWORD"]/*'/>
    WICSectionAccessLevel_FORCE_DWORD = 0x7fffffff,
}