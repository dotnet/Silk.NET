// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ShellWindowTypeConstants.xml' path='doc/member[@name="ShellWindowTypeConstants"]/*'/>
public enum ShellWindowTypeConstants
{
    /// <include file='ShellWindowTypeConstants.xml' path='doc/member[@name="ShellWindowTypeConstants.SWC_EXPLORER"]/*'/>
    SWC_EXPLORER = 0,
    /// <include file='ShellWindowTypeConstants.xml' path='doc/member[@name="ShellWindowTypeConstants.SWC_BROWSER"]/*'/>
    SWC_BROWSER = 0x1,
    /// <include file='ShellWindowTypeConstants.xml' path='doc/member[@name="ShellWindowTypeConstants.SWC_3RDPARTY"]/*'/>
    SWC_3RDPARTY = 0x2,
    /// <include file='ShellWindowTypeConstants.xml' path='doc/member[@name="ShellWindowTypeConstants.SWC_CALLBACK"]/*'/>
    SWC_CALLBACK = 0x4,
    /// <include file='ShellWindowTypeConstants.xml' path='doc/member[@name="ShellWindowTypeConstants.SWC_DESKTOP"]/*'/>
    SWC_DESKTOP = 0x8,
}