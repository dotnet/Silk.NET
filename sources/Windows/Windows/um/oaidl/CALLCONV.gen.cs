// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV"]/*' />
public enum CALLCONV
{
    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_FASTCALL"]/*' />
    CC_FASTCALL = 0,

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_CDECL"]/*' />
    CC_CDECL = 1,

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_MSCPASCAL"]/*' />
    CC_MSCPASCAL = (CC_CDECL + 1),

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_PASCAL"]/*' />
    CC_PASCAL = CC_MSCPASCAL,

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_MACPASCAL"]/*' />
    CC_MACPASCAL = (CC_PASCAL + 1),

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_STDCALL"]/*' />
    CC_STDCALL = (CC_MACPASCAL + 1),

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_FPFASTCALL"]/*' />
    CC_FPFASTCALL = (CC_STDCALL + 1),

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_SYSCALL"]/*' />
    CC_SYSCALL = (CC_FPFASTCALL + 1),

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_MPWCDECL"]/*' />
    CC_MPWCDECL = (CC_SYSCALL + 1),

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_MPWPASCAL"]/*' />
    CC_MPWPASCAL = (CC_MPWCDECL + 1),

    /// <include file='CALLCONV.xml' path='doc/member[@name="CALLCONV.CC_MAX"]/*' />
    CC_MAX = (CC_MPWPASCAL + 1),
}
