// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS"]/*'/>
public enum QACONTAINERFLAGS
{
    /// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS.QACONTAINER_SHOWHATCHING"]/*'/>
    QACONTAINER_SHOWHATCHING = 0x1,
    /// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS.QACONTAINER_SHOWGRABHANDLES"]/*'/>
    QACONTAINER_SHOWGRABHANDLES = 0x2,
    /// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS.QACONTAINER_USERMODE"]/*'/>
    QACONTAINER_USERMODE = 0x4,
    /// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS.QACONTAINER_DISPLAYASDEFAULT"]/*'/>
    QACONTAINER_DISPLAYASDEFAULT = 0x8,
    /// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS.QACONTAINER_UIDEAD"]/*'/>
    QACONTAINER_UIDEAD = 0x10,
    /// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS.QACONTAINER_AUTOCLIP"]/*'/>
    QACONTAINER_AUTOCLIP = 0x20,
    /// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS.QACONTAINER_MESSAGEREFLECT"]/*'/>
    QACONTAINER_MESSAGEREFLECT = 0x40,
    /// <include file='QACONTAINERFLAGS.xml' path='doc/member[@name="QACONTAINERFLAGS.QACONTAINER_SUPPORTSMNEMONICS"]/*'/>
    QACONTAINER_SUPPORTSMNEMONICS = 0x80,
}