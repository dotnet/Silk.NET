// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_BUFFER_PRECISION.xml' path='doc/member[@name="D2D1_BUFFER_PRECISION"]/*'/>
public enum D2D1_BUFFER_PRECISION
{
    /// <include file='D2D1_BUFFER_PRECISION.xml' path='doc/member[@name="D2D1_BUFFER_PRECISION.D2D1_BUFFER_PRECISION_UNKNOWN"]/*'/>
    D2D1_BUFFER_PRECISION_UNKNOWN = 0,
    /// <include file='D2D1_BUFFER_PRECISION.xml' path='doc/member[@name="D2D1_BUFFER_PRECISION.D2D1_BUFFER_PRECISION_8BPC_UNORM"]/*'/>
    D2D1_BUFFER_PRECISION_8BPC_UNORM = 1,
    /// <include file='D2D1_BUFFER_PRECISION.xml' path='doc/member[@name="D2D1_BUFFER_PRECISION.D2D1_BUFFER_PRECISION_8BPC_UNORM_SRGB"]/*'/>
    D2D1_BUFFER_PRECISION_8BPC_UNORM_SRGB = 2,
    /// <include file='D2D1_BUFFER_PRECISION.xml' path='doc/member[@name="D2D1_BUFFER_PRECISION.D2D1_BUFFER_PRECISION_16BPC_UNORM"]/*'/>
    D2D1_BUFFER_PRECISION_16BPC_UNORM = 3,
    /// <include file='D2D1_BUFFER_PRECISION.xml' path='doc/member[@name="D2D1_BUFFER_PRECISION.D2D1_BUFFER_PRECISION_16BPC_FLOAT"]/*'/>
    D2D1_BUFFER_PRECISION_16BPC_FLOAT = 4,
    /// <include file='D2D1_BUFFER_PRECISION.xml' path='doc/member[@name="D2D1_BUFFER_PRECISION.D2D1_BUFFER_PRECISION_32BPC_FLOAT"]/*'/>
    D2D1_BUFFER_PRECISION_32BPC_FLOAT = 5,
    /// <include file='D2D1_BUFFER_PRECISION.xml' path='doc/member[@name="D2D1_BUFFER_PRECISION.D2D1_BUFFER_PRECISION_FORCE_DWORD"]/*'/>
    D2D1_BUFFER_PRECISION_FORCE_DWORD = unchecked((int)(0xffffffff)),
}