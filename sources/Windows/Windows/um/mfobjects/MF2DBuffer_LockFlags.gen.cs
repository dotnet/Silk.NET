// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF2DBuffer_LockFlags.xml' path='doc/member[@name="MF2DBuffer_LockFlags"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MF2DBuffer_LockFlags
{
    /// <include file='MF2DBuffer_LockFlags.xml' path='doc/member[@name="MF2DBuffer_LockFlags.MF2DBuffer_LockFlags_LockTypeMask"]/*' />
    MF2DBuffer_LockFlags_LockTypeMask = ((0x1 | 0x2) | 0x3),

    /// <include file='MF2DBuffer_LockFlags.xml' path='doc/member[@name="MF2DBuffer_LockFlags.MF2DBuffer_LockFlags_Read"]/*' />
    MF2DBuffer_LockFlags_Read = 0x1,

    /// <include file='MF2DBuffer_LockFlags.xml' path='doc/member[@name="MF2DBuffer_LockFlags.MF2DBuffer_LockFlags_Write"]/*' />
    MF2DBuffer_LockFlags_Write = 0x2,

    /// <include file='MF2DBuffer_LockFlags.xml' path='doc/member[@name="MF2DBuffer_LockFlags.MF2DBuffer_LockFlags_ReadWrite"]/*' />
    MF2DBuffer_LockFlags_ReadWrite = 0x3,

    /// <include file='MF2DBuffer_LockFlags.xml' path='doc/member[@name="MF2DBuffer_LockFlags.MF2DBuffer_LockFlags_ForceDWORD"]/*' />
    MF2DBuffer_LockFlags_ForceDWORD = 0x7fffffff,
}
