// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='DitherType.xml' path='doc/member[@name="DitherType"]/*' />
public enum DitherType
{
    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeNone"]/*' />
    DitherTypeNone = 0,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeSolid"]/*' />
    DitherTypeSolid = 1,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeOrdered4x4"]/*' />
    DitherTypeOrdered4x4 = 2,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeOrdered8x8"]/*' />
    DitherTypeOrdered8x8 = 3,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeOrdered16x16"]/*' />
    DitherTypeOrdered16x16 = 4,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeSpiral4x4"]/*' />
    DitherTypeSpiral4x4 = 5,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeSpiral8x8"]/*' />
    DitherTypeSpiral8x8 = 6,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeDualSpiral4x4"]/*' />
    DitherTypeDualSpiral4x4 = 7,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeDualSpiral8x8"]/*' />
    DitherTypeDualSpiral8x8 = 8,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeErrorDiffusion"]/*' />
    DitherTypeErrorDiffusion = 9,

    /// <include file='DitherType.xml' path='doc/member[@name="DitherType.DitherTypeMax"]/*' />
    DitherTypeMax = 10,
}
