// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleWordBreak.xml' path='doc/member[@name="styleWordBreak"]/*'/>
public enum styleWordBreak
{
    /// <include file='styleWordBreak.xml' path='doc/member[@name="styleWordBreak.styleWordBreakNotSet"]/*'/>
    styleWordBreakNotSet = 0,
    /// <include file='styleWordBreak.xml' path='doc/member[@name="styleWordBreak.styleWordBreakNormal"]/*'/>
    styleWordBreakNormal = 1,
    /// <include file='styleWordBreak.xml' path='doc/member[@name="styleWordBreak.styleWordBreakBreakAll"]/*'/>
    styleWordBreakBreakAll = 2,
    /// <include file='styleWordBreak.xml' path='doc/member[@name="styleWordBreak.styleWordBreakKeepAll"]/*'/>
    styleWordBreakKeepAll = 3,
    /// <include file='styleWordBreak.xml' path='doc/member[@name="styleWordBreak.styleWordBreak_Max"]/*'/>
    styleWordBreak_Max = 2147483647,
}