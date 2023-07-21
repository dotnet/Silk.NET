// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DDOSCAPS.xml' path='doc/member[@name="DDOSCAPS"]/*' />
public partial struct DDOSCAPS
{
    /// <include file='DDOSCAPS.xml' path='doc/member[@name="DDOSCAPS.dwCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCaps;
}
