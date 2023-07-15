// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HTMLSysMenuFlag.xml' path='doc/member[@name="HTMLSysMenuFlag"]/*'/>
public enum HTMLSysMenuFlag
{
    /// <include file='HTMLSysMenuFlag.xml' path='doc/member[@name="HTMLSysMenuFlag.HTMLSysMenuFlagNo"]/*'/>
    HTMLSysMenuFlagNo = 0,
    /// <include file='HTMLSysMenuFlag.xml' path='doc/member[@name="HTMLSysMenuFlag.HTMLSysMenuFlagYes"]/*'/>
    HTMLSysMenuFlagYes = 0x80000,
    /// <include file='HTMLSysMenuFlag.xml' path='doc/member[@name="HTMLSysMenuFlag.HTMLSysMenuFlag_Max"]/*'/>
    HTMLSysMenuFlag_Max = 2147483647,
}