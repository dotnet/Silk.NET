// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_YCBCR_CHROMA_SUBSAMPLING.xml' path='doc/member[@name="D2D1_YCBCR_CHROMA_SUBSAMPLING"]/*'/>
public enum D2D1_YCBCR_CHROMA_SUBSAMPLING
{
    /// <include file='D2D1_YCBCR_CHROMA_SUBSAMPLING.xml' path='doc/member[@name="D2D1_YCBCR_CHROMA_SUBSAMPLING.D2D1_YCBCR_CHROMA_SUBSAMPLING_AUTO"]/*'/>
    D2D1_YCBCR_CHROMA_SUBSAMPLING_AUTO = 0,
    /// <include file='D2D1_YCBCR_CHROMA_SUBSAMPLING.xml' path='doc/member[@name="D2D1_YCBCR_CHROMA_SUBSAMPLING.D2D1_YCBCR_CHROMA_SUBSAMPLING_420"]/*'/>
    D2D1_YCBCR_CHROMA_SUBSAMPLING_420 = 1,
    /// <include file='D2D1_YCBCR_CHROMA_SUBSAMPLING.xml' path='doc/member[@name="D2D1_YCBCR_CHROMA_SUBSAMPLING.D2D1_YCBCR_CHROMA_SUBSAMPLING_422"]/*'/>
    D2D1_YCBCR_CHROMA_SUBSAMPLING_422 = 2,
    /// <include file='D2D1_YCBCR_CHROMA_SUBSAMPLING.xml' path='doc/member[@name="D2D1_YCBCR_CHROMA_SUBSAMPLING.D2D1_YCBCR_CHROMA_SUBSAMPLING_444"]/*'/>
    D2D1_YCBCR_CHROMA_SUBSAMPLING_444 = 3,
    /// <include file='D2D1_YCBCR_CHROMA_SUBSAMPLING.xml' path='doc/member[@name="D2D1_YCBCR_CHROMA_SUBSAMPLING.D2D1_YCBCR_CHROMA_SUBSAMPLING_440"]/*'/>
    D2D1_YCBCR_CHROMA_SUBSAMPLING_440 = 4,
    /// <include file='D2D1_YCBCR_CHROMA_SUBSAMPLING.xml' path='doc/member[@name="D2D1_YCBCR_CHROMA_SUBSAMPLING.D2D1_YCBCR_CHROMA_SUBSAMPLING_FORCE_DWORD"]/*'/>
    D2D1_YCBCR_CHROMA_SUBSAMPLING_FORCE_DWORD = unchecked((int)(0xffffffff)),
}