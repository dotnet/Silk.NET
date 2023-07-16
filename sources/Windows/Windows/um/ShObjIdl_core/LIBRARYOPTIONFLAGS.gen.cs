// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='LIBRARYOPTIONFLAGS.xml' path='doc/member[@name="LIBRARYOPTIONFLAGS"]/*'/>
[Flags]
public enum LIBRARYOPTIONFLAGS
{
    /// <include file='LIBRARYOPTIONFLAGS.xml' path='doc/member[@name="LIBRARYOPTIONFLAGS.LOF_DEFAULT"]/*'/>
    LOF_DEFAULT = 0,
    /// <include file='LIBRARYOPTIONFLAGS.xml' path='doc/member[@name="LIBRARYOPTIONFLAGS.LOF_PINNEDTONAVPANE"]/*'/>
    LOF_PINNEDTONAVPANE = 0x1,
    /// <include file='LIBRARYOPTIONFLAGS.xml' path='doc/member[@name="LIBRARYOPTIONFLAGS.LOF_MASK_ALL"]/*'/>
    LOF_MASK_ALL = 0x1,
}