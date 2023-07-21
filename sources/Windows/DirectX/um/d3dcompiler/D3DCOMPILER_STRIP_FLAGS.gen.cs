// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS"]/*' />
[Flags]
public enum D3DCOMPILER_STRIP_FLAGS
{
    /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_REFLECTION_DATA"]/*' />
    D3DCOMPILER_STRIP_REFLECTION_DATA = 0x00000001,

    /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_DEBUG_INFO"]/*' />
    D3DCOMPILER_STRIP_DEBUG_INFO = 0x00000002,

    /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_TEST_BLOBS"]/*' />
    D3DCOMPILER_STRIP_TEST_BLOBS = 0x00000004,

    /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_PRIVATE_DATA"]/*' />
    D3DCOMPILER_STRIP_PRIVATE_DATA = 0x00000008,

    /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_ROOT_SIGNATURE"]/*' />
    D3DCOMPILER_STRIP_ROOT_SIGNATURE = 0x00000010,

    /// <include file='D3DCOMPILER_STRIP_FLAGS.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS.D3DCOMPILER_STRIP_FORCE_DWORD"]/*' />
    D3DCOMPILER_STRIP_FORCE_DWORD = 0x7fffffff,
}
