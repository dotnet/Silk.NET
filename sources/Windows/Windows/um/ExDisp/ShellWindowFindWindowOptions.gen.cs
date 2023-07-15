// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ShellWindowFindWindowOptions.xml' path='doc/member[@name="ShellWindowFindWindowOptions"]/*'/>
public enum ShellWindowFindWindowOptions
{
    /// <include file='ShellWindowFindWindowOptions.xml' path='doc/member[@name="ShellWindowFindWindowOptions.SWFO_NEEDDISPATCH"]/*'/>
    SWFO_NEEDDISPATCH = 0x1,
    /// <include file='ShellWindowFindWindowOptions.xml' path='doc/member[@name="ShellWindowFindWindowOptions.SWFO_INCLUDEPENDING"]/*'/>
    SWFO_INCLUDEPENDING = 0x2,
    /// <include file='ShellWindowFindWindowOptions.xml' path='doc/member[@name="ShellWindowFindWindowOptions.SWFO_COOKIEPASSED"]/*'/>
    SWFO_COOKIEPASSED = 0x4,
}