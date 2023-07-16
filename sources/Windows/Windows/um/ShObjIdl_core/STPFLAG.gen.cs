// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='STPFLAG.xml' path='doc/member[@name="STPFLAG"]/*'/>
[Flags]
public enum STPFLAG
{
    /// <include file='STPFLAG.xml' path='doc/member[@name="STPFLAG.STPF_NONE"]/*'/>
    STPF_NONE = 0,
    /// <include file='STPFLAG.xml' path='doc/member[@name="STPFLAG.STPF_USEAPPTHUMBNAILALWAYS"]/*'/>
    STPF_USEAPPTHUMBNAILALWAYS = 0x1,
    /// <include file='STPFLAG.xml' path='doc/member[@name="STPFLAG.STPF_USEAPPTHUMBNAILWHENACTIVE"]/*'/>
    STPF_USEAPPTHUMBNAILWHENACTIVE = 0x2,
    /// <include file='STPFLAG.xml' path='doc/member[@name="STPFLAG.STPF_USEAPPPEEKALWAYS"]/*'/>
    STPF_USEAPPPEEKALWAYS = 0x4,
    /// <include file='STPFLAG.xml' path='doc/member[@name="STPFLAG.STPF_USEAPPPEEKWHENACTIVE"]/*'/>
    STPF_USEAPPPEEKWHENACTIVE = 0x8,
}