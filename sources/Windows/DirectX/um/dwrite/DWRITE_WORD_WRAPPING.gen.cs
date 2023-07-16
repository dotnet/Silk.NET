// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_WORD_WRAPPING.xml' path='doc/member[@name="DWRITE_WORD_WRAPPING"]/*'/>
public enum DWRITE_WORD_WRAPPING
{
    /// <include file='DWRITE_WORD_WRAPPING.xml' path='doc/member[@name="DWRITE_WORD_WRAPPING.DWRITE_WORD_WRAPPING_WRAP"]/*'/>
    DWRITE_WORD_WRAPPING_WRAP = 0,
    /// <include file='DWRITE_WORD_WRAPPING.xml' path='doc/member[@name="DWRITE_WORD_WRAPPING.DWRITE_WORD_WRAPPING_NO_WRAP"]/*'/>
    DWRITE_WORD_WRAPPING_NO_WRAP = 1,
    /// <include file='DWRITE_WORD_WRAPPING.xml' path='doc/member[@name="DWRITE_WORD_WRAPPING.DWRITE_WORD_WRAPPING_EMERGENCY_BREAK"]/*'/>
    DWRITE_WORD_WRAPPING_EMERGENCY_BREAK = 2,
    /// <include file='DWRITE_WORD_WRAPPING.xml' path='doc/member[@name="DWRITE_WORD_WRAPPING.DWRITE_WORD_WRAPPING_WHOLE_WORD"]/*'/>
    DWRITE_WORD_WRAPPING_WHOLE_WORD = 3,
    /// <include file='DWRITE_WORD_WRAPPING.xml' path='doc/member[@name="DWRITE_WORD_WRAPPING.DWRITE_WORD_WRAPPING_CHARACTER"]/*'/>
    DWRITE_WORD_WRAPPING_CHARACTER = 4,
}