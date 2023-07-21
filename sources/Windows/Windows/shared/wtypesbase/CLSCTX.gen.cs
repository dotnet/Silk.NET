// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX"]/*' />
public enum CLSCTX
{
    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_INPROC_SERVER"]/*' />
    CLSCTX_INPROC_SERVER = 0x1,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_INPROC_HANDLER"]/*' />
    CLSCTX_INPROC_HANDLER = 0x2,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_LOCAL_SERVER"]/*' />
    CLSCTX_LOCAL_SERVER = 0x4,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_INPROC_SERVER16"]/*' />
    CLSCTX_INPROC_SERVER16 = 0x8,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_REMOTE_SERVER"]/*' />
    CLSCTX_REMOTE_SERVER = 0x10,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_INPROC_HANDLER16"]/*' />
    CLSCTX_INPROC_HANDLER16 = 0x20,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED1"]/*' />
    CLSCTX_RESERVED1 = 0x40,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED2"]/*' />
    CLSCTX_RESERVED2 = 0x80,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED3"]/*' />
    CLSCTX_RESERVED3 = 0x100,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED4"]/*' />
    CLSCTX_RESERVED4 = 0x200,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_NO_CODE_DOWNLOAD"]/*' />
    CLSCTX_NO_CODE_DOWNLOAD = 0x400,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED5"]/*' />
    CLSCTX_RESERVED5 = 0x800,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_NO_CUSTOM_MARSHAL"]/*' />
    CLSCTX_NO_CUSTOM_MARSHAL = 0x1000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ENABLE_CODE_DOWNLOAD"]/*' />
    CLSCTX_ENABLE_CODE_DOWNLOAD = 0x2000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_NO_FAILURE_LOG"]/*' />
    CLSCTX_NO_FAILURE_LOG = 0x4000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_DISABLE_AAA"]/*' />
    CLSCTX_DISABLE_AAA = 0x8000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ENABLE_AAA"]/*' />
    CLSCTX_ENABLE_AAA = 0x10000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_FROM_DEFAULT_CONTEXT"]/*' />
    CLSCTX_FROM_DEFAULT_CONTEXT = 0x20000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_X86_SERVER"]/*' />
    CLSCTX_ACTIVATE_X86_SERVER = 0x40000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_32_BIT_SERVER"]/*' />
    CLSCTX_ACTIVATE_32_BIT_SERVER = CLSCTX_ACTIVATE_X86_SERVER,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_64_BIT_SERVER"]/*' />
    CLSCTX_ACTIVATE_64_BIT_SERVER = 0x80000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ENABLE_CLOAKING"]/*' />
    CLSCTX_ENABLE_CLOAKING = 0x100000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_APPCONTAINER"]/*' />
    CLSCTX_APPCONTAINER = 0x400000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_AAA_AS_IU"]/*' />
    CLSCTX_ACTIVATE_AAA_AS_IU = 0x800000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_RESERVED6"]/*' />
    CLSCTX_RESERVED6 = 0x1000000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ACTIVATE_ARM32_SERVER"]/*' />
    CLSCTX_ACTIVATE_ARM32_SERVER = 0x2000000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION"]/*' />
    CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION = 0x4000000,

    /// <include file='CLSCTX.xml' path='doc/member[@name="CLSCTX.CLSCTX_PS_DLL"]/*' />
    CLSCTX_PS_DLL = unchecked((int)(0x80000000)),
}
