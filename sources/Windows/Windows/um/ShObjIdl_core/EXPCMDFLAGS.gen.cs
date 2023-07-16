// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS"]/*'/>
[Flags]
public enum EXPCMDFLAGS
{
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_DEFAULT"]/*'/>
    ECF_DEFAULT = 0,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_HASSUBCOMMANDS"]/*'/>
    ECF_HASSUBCOMMANDS = 0x1,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_HASSPLITBUTTON"]/*'/>
    ECF_HASSPLITBUTTON = 0x2,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_HIDELABEL"]/*'/>
    ECF_HIDELABEL = 0x4,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_ISSEPARATOR"]/*'/>
    ECF_ISSEPARATOR = 0x8,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_HASLUASHIELD"]/*'/>
    ECF_HASLUASHIELD = 0x10,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_SEPARATORBEFORE"]/*'/>
    ECF_SEPARATORBEFORE = 0x20,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_SEPARATORAFTER"]/*'/>
    ECF_SEPARATORAFTER = 0x40,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_ISDROPDOWN"]/*'/>
    ECF_ISDROPDOWN = 0x80,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_TOGGLEABLE"]/*'/>
    ECF_TOGGLEABLE = 0x100,
    /// <include file='EXPCMDFLAGS.xml' path='doc/member[@name="EXPCMDFLAGS.ECF_AUTOMENUICONS"]/*'/>
    ECF_AUTOMENUICONS = 0x200,
}