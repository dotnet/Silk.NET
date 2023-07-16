// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HTMLMaximizeFlag.xml' path='doc/member[@name="HTMLMaximizeFlag"]/*'/>
public enum HTMLMaximizeFlag
{
    /// <include file='HTMLMaximizeFlag.xml' path='doc/member[@name="HTMLMaximizeFlag.HTMLMaximizeFlagNo"]/*'/>
    HTMLMaximizeFlagNo = 0,
    /// <include file='HTMLMaximizeFlag.xml' path='doc/member[@name="HTMLMaximizeFlag.HTMLMaximizeFlagYes"]/*'/>
    HTMLMaximizeFlagYes = 0x10000,
    /// <include file='HTMLMaximizeFlag.xml' path='doc/member[@name="HTMLMaximizeFlag.HTMLMaximizeFlag_Max"]/*'/>
    HTMLMaximizeFlag_Max = 2147483647,
}