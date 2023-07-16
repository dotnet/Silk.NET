// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SLGP_FLAGS.xml' path='doc/member[@name="SLGP_FLAGS"]/*'/>
[Flags]
public enum SLGP_FLAGS
{
    /// <include file='SLGP_FLAGS.xml' path='doc/member[@name="SLGP_FLAGS.SLGP_SHORTPATH"]/*'/>
    SLGP_SHORTPATH = 0x1,
    /// <include file='SLGP_FLAGS.xml' path='doc/member[@name="SLGP_FLAGS.SLGP_UNCPRIORITY"]/*'/>
    SLGP_UNCPRIORITY = 0x2,
    /// <include file='SLGP_FLAGS.xml' path='doc/member[@name="SLGP_FLAGS.SLGP_RAWPATH"]/*'/>
    SLGP_RAWPATH = 0x4,
    /// <include file='SLGP_FLAGS.xml' path='doc/member[@name="SLGP_FLAGS.SLGP_RELATIVEPRIORITY"]/*'/>
    SLGP_RELATIVEPRIORITY = 0x8,
}