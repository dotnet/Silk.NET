// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_READING_DIRECTION.xml' path='doc/member[@name="DWRITE_READING_DIRECTION"]/*'/>
public enum DWRITE_READING_DIRECTION
{
    /// <include file='DWRITE_READING_DIRECTION.xml' path='doc/member[@name="DWRITE_READING_DIRECTION.DWRITE_READING_DIRECTION_LEFT_TO_RIGHT"]/*'/>
    DWRITE_READING_DIRECTION_LEFT_TO_RIGHT = 0,
    /// <include file='DWRITE_READING_DIRECTION.xml' path='doc/member[@name="DWRITE_READING_DIRECTION.DWRITE_READING_DIRECTION_RIGHT_TO_LEFT"]/*'/>
    DWRITE_READING_DIRECTION_RIGHT_TO_LEFT = 1,
    /// <include file='DWRITE_READING_DIRECTION.xml' path='doc/member[@name="DWRITE_READING_DIRECTION.DWRITE_READING_DIRECTION_TOP_TO_BOTTOM"]/*'/>
    DWRITE_READING_DIRECTION_TOP_TO_BOTTOM = 2,
    /// <include file='DWRITE_READING_DIRECTION.xml' path='doc/member[@name="DWRITE_READING_DIRECTION.DWRITE_READING_DIRECTION_BOTTOM_TO_TOP"]/*'/>
    DWRITE_READING_DIRECTION_BOTTOM_TO_TOP = 3,
}