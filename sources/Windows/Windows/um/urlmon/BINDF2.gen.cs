// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='BINDF2.xml' path='doc/member[@name="BINDF2"]/*'/>
[Flags]
public enum BINDF2
{
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_DISABLEBASICOVERHTTP"]/*'/>
    BINDF2_DISABLEBASICOVERHTTP = 0x1,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_DISABLEAUTOCOOKIEHANDLING"]/*'/>
    BINDF2_DISABLEAUTOCOOKIEHANDLING = 0x2,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_READ_DATA_GREATER_THAN_4GB"]/*'/>
    BINDF2_READ_DATA_GREATER_THAN_4GB = 0x4,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_DISABLE_HTTP_REDIRECT_XSECURITYID"]/*'/>
    BINDF2_DISABLE_HTTP_REDIRECT_XSECURITYID = 0x8,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_SETDOWNLOADMODE"]/*'/>
    BINDF2_SETDOWNLOADMODE = 0x20,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_DISABLE_HTTP_REDIRECT_CACHING"]/*'/>
    BINDF2_DISABLE_HTTP_REDIRECT_CACHING = 0x40,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_KEEP_CALLBACK_MODULE_LOADED"]/*'/>
    BINDF2_KEEP_CALLBACK_MODULE_LOADED = 0x80,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_ALLOW_PROXY_CRED_PROMPT"]/*'/>
    BINDF2_ALLOW_PROXY_CRED_PROMPT = 0x100,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_17"]/*'/>
    BINDF2_RESERVED_17 = 0x200,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_16"]/*'/>
    BINDF2_RESERVED_16 = 0x400,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_15"]/*'/>
    BINDF2_RESERVED_15 = 0x800,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_14"]/*'/>
    BINDF2_RESERVED_14 = 0x1000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_13"]/*'/>
    BINDF2_RESERVED_13 = 0x2000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_12"]/*'/>
    BINDF2_RESERVED_12 = 0x4000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_11"]/*'/>
    BINDF2_RESERVED_11 = 0x8000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_10"]/*'/>
    BINDF2_RESERVED_10 = 0x10000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_F"]/*'/>
    BINDF2_RESERVED_F = 0x20000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_E"]/*'/>
    BINDF2_RESERVED_E = 0x40000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_D"]/*'/>
    BINDF2_RESERVED_D = 0x80000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_C"]/*'/>
    BINDF2_RESERVED_C = 0x100000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_B"]/*'/>
    BINDF2_RESERVED_B = 0x200000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_A"]/*'/>
    BINDF2_RESERVED_A = 0x400000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_9"]/*'/>
    BINDF2_RESERVED_9 = 0x800000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_8"]/*'/>
    BINDF2_RESERVED_8 = 0x1000000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_7"]/*'/>
    BINDF2_RESERVED_7 = 0x2000000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_6"]/*'/>
    BINDF2_RESERVED_6 = 0x4000000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_5"]/*'/>
    BINDF2_RESERVED_5 = 0x8000000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_4"]/*'/>
    BINDF2_RESERVED_4 = 0x10000000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_3"]/*'/>
    BINDF2_RESERVED_3 = 0x20000000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_2"]/*'/>
    BINDF2_RESERVED_2 = 0x40000000,
    /// <include file='BINDF2.xml' path='doc/member[@name="BINDF2.BINDF2_RESERVED_1"]/*'/>
    BINDF2_RESERVED_1 = unchecked((int)(0x80000000)),
}