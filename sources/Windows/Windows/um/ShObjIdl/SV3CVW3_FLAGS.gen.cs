// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SV3CVW3_FLAGS.xml' path='doc/member[@name="SV3CVW3_FLAGS"]/*'/>
[Flags]
public enum SV3CVW3_FLAGS
{
    /// <include file='SV3CVW3_FLAGS.xml' path='doc/member[@name="SV3CVW3_FLAGS.SV3CVW3_DEFAULT"]/*'/>
    SV3CVW3_DEFAULT = 0,
    /// <include file='SV3CVW3_FLAGS.xml' path='doc/member[@name="SV3CVW3_FLAGS.SV3CVW3_NONINTERACTIVE"]/*'/>
    SV3CVW3_NONINTERACTIVE = 0x1,
    /// <include file='SV3CVW3_FLAGS.xml' path='doc/member[@name="SV3CVW3_FLAGS.SV3CVW3_FORCEVIEWMODE"]/*'/>
    SV3CVW3_FORCEVIEWMODE = 0x2,
    /// <include file='SV3CVW3_FLAGS.xml' path='doc/member[@name="SV3CVW3_FLAGS.SV3CVW3_FORCEFOLDERFLAGS"]/*'/>
    SV3CVW3_FORCEFOLDERFLAGS = 0x4,
}