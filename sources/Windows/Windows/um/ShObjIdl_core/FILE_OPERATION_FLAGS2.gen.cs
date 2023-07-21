// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='FILE_OPERATION_FLAGS2.xml' path='doc/member[@name="FILE_OPERATION_FLAGS2"]/*' />
[Flags]
public enum FILE_OPERATION_FLAGS2
{
    /// <include file='FILE_OPERATION_FLAGS2.xml' path='doc/member[@name="FILE_OPERATION_FLAGS2.FOF2_NONE"]/*' />
    FOF2_NONE = 0,

    /// <include file='FILE_OPERATION_FLAGS2.xml' path='doc/member[@name="FILE_OPERATION_FLAGS2.FOF2_MERGEFOLDERSONCOLLISION"]/*' />
    FOF2_MERGEFOLDERSONCOLLISION = 0x1,
}
