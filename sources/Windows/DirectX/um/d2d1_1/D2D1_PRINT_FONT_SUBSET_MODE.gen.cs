// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_PRINT_FONT_SUBSET_MODE.xml' path='doc/member[@name="D2D1_PRINT_FONT_SUBSET_MODE"]/*'/>
public enum D2D1_PRINT_FONT_SUBSET_MODE
{
    /// <include file='D2D1_PRINT_FONT_SUBSET_MODE.xml' path='doc/member[@name="D2D1_PRINT_FONT_SUBSET_MODE.D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT"]/*'/>
    D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT = 0,
    /// <include file='D2D1_PRINT_FONT_SUBSET_MODE.xml' path='doc/member[@name="D2D1_PRINT_FONT_SUBSET_MODE.D2D1_PRINT_FONT_SUBSET_MODE_EACHPAGE"]/*'/>
    D2D1_PRINT_FONT_SUBSET_MODE_EACHPAGE = 1,
    /// <include file='D2D1_PRINT_FONT_SUBSET_MODE.xml' path='doc/member[@name="D2D1_PRINT_FONT_SUBSET_MODE.D2D1_PRINT_FONT_SUBSET_MODE_NONE"]/*'/>
    D2D1_PRINT_FONT_SUBSET_MODE_NONE = 2,
    /// <include file='D2D1_PRINT_FONT_SUBSET_MODE.xml' path='doc/member[@name="D2D1_PRINT_FONT_SUBSET_MODE.D2D1_PRINT_FONT_SUBSET_MODE_FORCE_DWORD"]/*'/>
    D2D1_PRINT_FONT_SUBSET_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}