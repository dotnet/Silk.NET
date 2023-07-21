// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='LIBRARYMANAGEDIALOGOPTIONS.xml' path='doc/member[@name="LIBRARYMANAGEDIALOGOPTIONS"]/*' />
[Flags]
public enum LIBRARYMANAGEDIALOGOPTIONS
{
    /// <include file='LIBRARYMANAGEDIALOGOPTIONS.xml' path='doc/member[@name="LIBRARYMANAGEDIALOGOPTIONS.LMD_DEFAULT"]/*' />
    LMD_DEFAULT = 0,

    /// <include file='LIBRARYMANAGEDIALOGOPTIONS.xml' path='doc/member[@name="LIBRARYMANAGEDIALOGOPTIONS.LMD_ALLOWUNINDEXABLENETWORKLOCATIONS"]/*' />
    LMD_ALLOWUNINDEXABLENETWORKLOCATIONS = 0x1,
}
