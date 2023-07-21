// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPBEGINF.xml' path='doc/member[@name="SPBEGINF"]/*' />
public enum SPBEGINF
{
    /// <include file='SPBEGINF.xml' path='doc/member[@name="SPBEGINF.SPBEGINF_NORMAL"]/*' />
    SPBEGINF_NORMAL = 0,

    /// <include file='SPBEGINF.xml' path='doc/member[@name="SPBEGINF.SPBEGINF_AUTOTIME"]/*' />
    SPBEGINF_AUTOTIME = 0x2,

    /// <include file='SPBEGINF.xml' path='doc/member[@name="SPBEGINF.SPBEGINF_NOPROGRESSBAR"]/*' />
    SPBEGINF_NOPROGRESSBAR = 0x10,

    /// <include file='SPBEGINF.xml' path='doc/member[@name="SPBEGINF.SPBEGINF_MARQUEEPROGRESS"]/*' />
    SPBEGINF_MARQUEEPROGRESS = 0x20,

    /// <include file='SPBEGINF.xml' path='doc/member[@name="SPBEGINF.SPBEGINF_NOCANCELBUTTON"]/*' />
    SPBEGINF_NOCANCELBUTTON = 0x40,
}
