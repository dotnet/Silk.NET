// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='NMCSAEI_FLAGS.xml' path='doc/member[@name="NMCSAEI_FLAGS"]/*'/>
[Flags]
public enum NMCSAEI_FLAGS
{
    /// <include file='NMCSAEI_FLAGS.xml' path='doc/member[@name="NMCSAEI_FLAGS.NMCSAEI_SELECT"]/*'/>
    NMCSAEI_SELECT = 0,
    /// <include file='NMCSAEI_FLAGS.xml' path='doc/member[@name="NMCSAEI_FLAGS.NMCSAEI_EDIT"]/*'/>
    NMCSAEI_EDIT = 0x1,
}