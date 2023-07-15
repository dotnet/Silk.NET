// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VIDEO_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_CONTENT_PROTECTION_CAPS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_CONTENT_PROTECTION_CAPS
{
    /// <include file='D3D11_VIDEO_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_CONTENT_PROTECTION_CAPS.Caps"]/*'/>
    public uint Caps;
    /// <include file='D3D11_VIDEO_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_CONTENT_PROTECTION_CAPS.KeyExchangeTypeCount"]/*'/>
    public uint KeyExchangeTypeCount;
    /// <include file='D3D11_VIDEO_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_CONTENT_PROTECTION_CAPS.BlockAlignmentSize"]/*'/>
    public uint BlockAlignmentSize;
    /// <include file='D3D11_VIDEO_CONTENT_PROTECTION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_CONTENT_PROTECTION_CAPS.ProtectedMemorySize"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ProtectedMemorySize;
}