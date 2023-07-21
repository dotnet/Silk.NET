// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS"]/*' />
public enum SPGRAMMAROPTIONS
{
    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_SAPI"]/*' />
    SPGO_SAPI = 0x1,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_SRGS"]/*' />
    SPGO_SRGS = 0x2,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_UPS"]/*' />
    SPGO_UPS = 0x4,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_SRGS_MS_SCRIPT"]/*' />
    SPGO_SRGS_MS_SCRIPT = 0x8,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_SRGS_W3C_SCRIPT"]/*' />
    SPGO_SRGS_W3C_SCRIPT = 0x100,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_SRGS_STG_SCRIPT"]/*' />
    SPGO_SRGS_STG_SCRIPT = 0x200,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_SRGS_SCRIPT"]/*' />
    SPGO_SRGS_SCRIPT = (((SPGO_SRGS | SPGO_SRGS_MS_SCRIPT) | SPGO_SRGS_W3C_SCRIPT) | SPGO_SRGS_STG_SCRIPT),

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_FILE"]/*' />
    SPGO_FILE = 0x10,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_HTTP"]/*' />
    SPGO_HTTP = 0x20,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_RES"]/*' />
    SPGO_RES = 0x40,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_OBJECT"]/*' />
    SPGO_OBJECT = 0x80,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_DEFAULT"]/*' />
    SPGO_DEFAULT = 0x3fb,

    /// <include file='SPGRAMMAROPTIONS.xml' path='doc/member[@name="SPGRAMMAROPTIONS.SPGO_ALL"]/*' />
    SPGO_ALL = 0x3ff,
}
