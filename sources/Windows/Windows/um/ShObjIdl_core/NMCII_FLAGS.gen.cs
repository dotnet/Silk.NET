// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='NMCII_FLAGS.xml' path='doc/member[@name="NMCII_FLAGS"]/*'/>
[Flags]
public enum NMCII_FLAGS
{
    /// <include file='NMCII_FLAGS.xml' path='doc/member[@name="NMCII_FLAGS.NMCII_NONE"]/*'/>
    NMCII_NONE = 0,
    /// <include file='NMCII_FLAGS.xml' path='doc/member[@name="NMCII_FLAGS.NMCII_ITEMS"]/*'/>
    NMCII_ITEMS = 0x1,
    /// <include file='NMCII_FLAGS.xml' path='doc/member[@name="NMCII_FLAGS.NMCII_FOLDERS"]/*'/>
    NMCII_FOLDERS = 0x2,
}