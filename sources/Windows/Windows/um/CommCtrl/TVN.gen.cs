// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TVN
{
    [NativeTypeName("#define TVN_FIRST (0U-400U)")]
    public const uint TVN_FIRST = unchecked(0U - 400U);
    [NativeTypeName("#define TVN_LAST (0U-499U)")]
    public const uint TVN_LAST = unchecked(0U - 499U);
    [NativeTypeName("#define TVN_SELCHANGINGA (TVN_FIRST-1)")]
    public const uint TVN_SELCHANGINGA = unchecked((0U - 400U) - 1);
    [NativeTypeName("#define TVN_SELCHANGINGW (TVN_FIRST-50)")]
    public const uint TVN_SELCHANGINGW = unchecked((0U - 400U) - 50);
    [NativeTypeName("#define TVN_SELCHANGEDA (TVN_FIRST-2)")]
    public const uint TVN_SELCHANGEDA = unchecked((0U - 400U) - 2);
    [NativeTypeName("#define TVN_SELCHANGEDW (TVN_FIRST-51)")]
    public const uint TVN_SELCHANGEDW = unchecked((0U - 400U) - 51);
    [NativeTypeName("#define TVN_GETDISPINFOA (TVN_FIRST-3)")]
    public const uint TVN_GETDISPINFOA = unchecked((0U - 400U) - 3);
    [NativeTypeName("#define TVN_GETDISPINFOW (TVN_FIRST-52)")]
    public const uint TVN_GETDISPINFOW = unchecked((0U - 400U) - 52);
    [NativeTypeName("#define TVN_SETDISPINFOA (TVN_FIRST-4)")]
    public const uint TVN_SETDISPINFOA = unchecked((0U - 400U) - 4);
    [NativeTypeName("#define TVN_SETDISPINFOW (TVN_FIRST-53)")]
    public const uint TVN_SETDISPINFOW = unchecked((0U - 400U) - 53);
    [NativeTypeName("#define TVN_ITEMEXPANDINGA (TVN_FIRST-5)")]
    public const uint TVN_ITEMEXPANDINGA = unchecked((0U - 400U) - 5);
    [NativeTypeName("#define TVN_ITEMEXPANDINGW (TVN_FIRST-54)")]
    public const uint TVN_ITEMEXPANDINGW = unchecked((0U - 400U) - 54);
    [NativeTypeName("#define TVN_ITEMEXPANDEDA (TVN_FIRST-6)")]
    public const uint TVN_ITEMEXPANDEDA = unchecked((0U - 400U) - 6);
    [NativeTypeName("#define TVN_ITEMEXPANDEDW (TVN_FIRST-55)")]
    public const uint TVN_ITEMEXPANDEDW = unchecked((0U - 400U) - 55);
    [NativeTypeName("#define TVN_BEGINDRAGA (TVN_FIRST-7)")]
    public const uint TVN_BEGINDRAGA = unchecked((0U - 400U) - 7);
    [NativeTypeName("#define TVN_BEGINDRAGW (TVN_FIRST-56)")]
    public const uint TVN_BEGINDRAGW = unchecked((0U - 400U) - 56);
    [NativeTypeName("#define TVN_BEGINRDRAGA (TVN_FIRST-8)")]
    public const uint TVN_BEGINRDRAGA = unchecked((0U - 400U) - 8);
    [NativeTypeName("#define TVN_BEGINRDRAGW (TVN_FIRST-57)")]
    public const uint TVN_BEGINRDRAGW = unchecked((0U - 400U) - 57);
    [NativeTypeName("#define TVN_DELETEITEMA (TVN_FIRST-9)")]
    public const uint TVN_DELETEITEMA = unchecked((0U - 400U) - 9);
    [NativeTypeName("#define TVN_DELETEITEMW (TVN_FIRST-58)")]
    public const uint TVN_DELETEITEMW = unchecked((0U - 400U) - 58);
    [NativeTypeName("#define TVN_BEGINLABELEDITA (TVN_FIRST-10)")]
    public const uint TVN_BEGINLABELEDITA = unchecked((0U - 400U) - 10);
    [NativeTypeName("#define TVN_BEGINLABELEDITW (TVN_FIRST-59)")]
    public const uint TVN_BEGINLABELEDITW = unchecked((0U - 400U) - 59);
    [NativeTypeName("#define TVN_ENDLABELEDITA (TVN_FIRST-11)")]
    public const uint TVN_ENDLABELEDITA = unchecked((0U - 400U) - 11);
    [NativeTypeName("#define TVN_ENDLABELEDITW (TVN_FIRST-60)")]
    public const uint TVN_ENDLABELEDITW = unchecked((0U - 400U) - 60);
    [NativeTypeName("#define TVN_KEYDOWN (TVN_FIRST-12)")]
    public const uint TVN_KEYDOWN = unchecked((0U - 400U) - 12);
    [NativeTypeName("#define TVN_GETINFOTIPA (TVN_FIRST-13)")]
    public const uint TVN_GETINFOTIPA = unchecked((0U - 400U) - 13);
    [NativeTypeName("#define TVN_GETINFOTIPW (TVN_FIRST-14)")]
    public const uint TVN_GETINFOTIPW = unchecked((0U - 400U) - 14);
    [NativeTypeName("#define TVN_SINGLEEXPAND (TVN_FIRST-15)")]
    public const uint TVN_SINGLEEXPAND = unchecked((0U - 400U) - 15);
    [NativeTypeName("#define TVN_ITEMCHANGINGA (TVN_FIRST-16)")]
    public const uint TVN_ITEMCHANGINGA = unchecked((0U - 400U) - 16);
    [NativeTypeName("#define TVN_ITEMCHANGINGW (TVN_FIRST-17)")]
    public const uint TVN_ITEMCHANGINGW = unchecked((0U - 400U) - 17);
    [NativeTypeName("#define TVN_ITEMCHANGEDA (TVN_FIRST-18)")]
    public const uint TVN_ITEMCHANGEDA = unchecked((0U - 400U) - 18);
    [NativeTypeName("#define TVN_ITEMCHANGEDW (TVN_FIRST-19)")]
    public const uint TVN_ITEMCHANGEDW = unchecked((0U - 400U) - 19);
    [NativeTypeName("#define TVN_ASYNCDRAW (TVN_FIRST-20)")]
    public const uint TVN_ASYNCDRAW = unchecked((0U - 400U) - 20);
    [NativeTypeName("#define TVN_SELCHANGING TVN_SELCHANGINGW")]
    public const uint TVN_SELCHANGING = unchecked((0U - 400U) - 50);
    [NativeTypeName("#define TVN_SELCHANGED TVN_SELCHANGEDW")]
    public const uint TVN_SELCHANGED = unchecked((0U - 400U) - 51);
    [NativeTypeName("#define TVN_GETDISPINFO TVN_GETDISPINFOW")]
    public const uint TVN_GETDISPINFO = unchecked((0U - 400U) - 52);
    [NativeTypeName("#define TVN_SETDISPINFO TVN_SETDISPINFOW")]
    public const uint TVN_SETDISPINFO = unchecked((0U - 400U) - 53);
    [NativeTypeName("#define TVN_ITEMEXPANDING TVN_ITEMEXPANDINGW")]
    public const uint TVN_ITEMEXPANDING = unchecked((0U - 400U) - 54);
    [NativeTypeName("#define TVN_ITEMEXPANDED TVN_ITEMEXPANDEDW")]
    public const uint TVN_ITEMEXPANDED = unchecked((0U - 400U) - 55);
    [NativeTypeName("#define TVN_BEGINDRAG TVN_BEGINDRAGW")]
    public const uint TVN_BEGINDRAG = unchecked((0U - 400U) - 56);
    [NativeTypeName("#define TVN_BEGINRDRAG TVN_BEGINRDRAGW")]
    public const uint TVN_BEGINRDRAG = unchecked((0U - 400U) - 57);
    [NativeTypeName("#define TVN_DELETEITEM TVN_DELETEITEMW")]
    public const uint TVN_DELETEITEM = unchecked((0U - 400U) - 58);
    [NativeTypeName("#define TVN_BEGINLABELEDIT TVN_BEGINLABELEDITW")]
    public const uint TVN_BEGINLABELEDIT = unchecked((0U - 400U) - 59);
    [NativeTypeName("#define TVN_ENDLABELEDIT TVN_ENDLABELEDITW")]
    public const uint TVN_ENDLABELEDIT = unchecked((0U - 400U) - 60);
    [NativeTypeName("#define TVN_GETINFOTIP TVN_GETINFOTIPW")]
    public const uint TVN_GETINFOTIP = unchecked((0U - 400U) - 14);
    [NativeTypeName("#define TVN_ITEMCHANGING TVN_ITEMCHANGINGW")]
    public const uint TVN_ITEMCHANGING = unchecked((0U - 400U) - 17);
    [NativeTypeName("#define TVN_ITEMCHANGED TVN_ITEMCHANGEDW")]
    public const uint TVN_ITEMCHANGED = unchecked((0U - 400U) - 19);
}