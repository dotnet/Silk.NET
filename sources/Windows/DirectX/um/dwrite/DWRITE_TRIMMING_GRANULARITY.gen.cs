// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_TRIMMING_GRANULARITY.xml' path='doc/member[@name="DWRITE_TRIMMING_GRANULARITY"]/*'/>
public enum DWRITE_TRIMMING_GRANULARITY
{
    /// <include file='DWRITE_TRIMMING_GRANULARITY.xml' path='doc/member[@name="DWRITE_TRIMMING_GRANULARITY.DWRITE_TRIMMING_GRANULARITY_NONE"]/*'/>
    DWRITE_TRIMMING_GRANULARITY_NONE,
    /// <include file='DWRITE_TRIMMING_GRANULARITY.xml' path='doc/member[@name="DWRITE_TRIMMING_GRANULARITY.DWRITE_TRIMMING_GRANULARITY_CHARACTER"]/*'/>
    DWRITE_TRIMMING_GRANULARITY_CHARACTER,
    /// <include file='DWRITE_TRIMMING_GRANULARITY.xml' path='doc/member[@name="DWRITE_TRIMMING_GRANULARITY.DWRITE_TRIMMING_GRANULARITY_WORD"]/*'/>
    DWRITE_TRIMMING_GRANULARITY_WORD,
}