// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='LIBRARYSAVEFLAGS.xml' path='doc/member[@name="LIBRARYSAVEFLAGS"]/*'/>
[Flags]
public enum LIBRARYSAVEFLAGS
{
    /// <include file='LIBRARYSAVEFLAGS.xml' path='doc/member[@name="LIBRARYSAVEFLAGS.LSF_FAILIFTHERE"]/*'/>
    LSF_FAILIFTHERE = 0,
    /// <include file='LIBRARYSAVEFLAGS.xml' path='doc/member[@name="LIBRARYSAVEFLAGS.LSF_OVERRIDEEXISTING"]/*'/>
    LSF_OVERRIDEEXISTING = 0x1,
    /// <include file='LIBRARYSAVEFLAGS.xml' path='doc/member[@name="LIBRARYSAVEFLAGS.LSF_MAKEUNIQUENAME"]/*'/>
    LSF_MAKEUNIQUENAME = 0x2,
}