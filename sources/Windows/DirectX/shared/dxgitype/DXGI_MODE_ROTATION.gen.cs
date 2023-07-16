// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION"]/*'/>
public enum DXGI_MODE_ROTATION
{
    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_UNSPECIFIED"]/*'/>
    DXGI_MODE_ROTATION_UNSPECIFIED = 0,
    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_IDENTITY"]/*'/>
    DXGI_MODE_ROTATION_IDENTITY = 1,
    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_ROTATE90"]/*'/>
    DXGI_MODE_ROTATION_ROTATE90 = 2,
    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_ROTATE180"]/*'/>
    DXGI_MODE_ROTATION_ROTATE180 = 3,
    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_ROTATE270"]/*'/>
    DXGI_MODE_ROTATION_ROTATE270 = 4,
}