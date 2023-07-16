// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class HDN
{
    [NativeTypeName("#define HDN_FIRST (0U-300U)")]
    public const uint HDN_FIRST = unchecked(0U - 300U);
    [NativeTypeName("#define HDN_LAST (0U-399U)")]
    public const uint HDN_LAST = unchecked(0U - 399U);
    [NativeTypeName("#define HDN_ITEMCHANGINGA (HDN_FIRST-0)")]
    public const uint HDN_ITEMCHANGINGA = unchecked((0U - 300U) - 0);
    [NativeTypeName("#define HDN_ITEMCHANGINGW (HDN_FIRST-20)")]
    public const uint HDN_ITEMCHANGINGW = unchecked((0U - 300U) - 20);
    [NativeTypeName("#define HDN_ITEMCHANGEDA (HDN_FIRST-1)")]
    public const uint HDN_ITEMCHANGEDA = unchecked((0U - 300U) - 1);
    [NativeTypeName("#define HDN_ITEMCHANGEDW (HDN_FIRST-21)")]
    public const uint HDN_ITEMCHANGEDW = unchecked((0U - 300U) - 21);
    [NativeTypeName("#define HDN_ITEMCLICKA (HDN_FIRST-2)")]
    public const uint HDN_ITEMCLICKA = unchecked((0U - 300U) - 2);
    [NativeTypeName("#define HDN_ITEMCLICKW (HDN_FIRST-22)")]
    public const uint HDN_ITEMCLICKW = unchecked((0U - 300U) - 22);
    [NativeTypeName("#define HDN_ITEMDBLCLICKA (HDN_FIRST-3)")]
    public const uint HDN_ITEMDBLCLICKA = unchecked((0U - 300U) - 3);
    [NativeTypeName("#define HDN_ITEMDBLCLICKW (HDN_FIRST-23)")]
    public const uint HDN_ITEMDBLCLICKW = unchecked((0U - 300U) - 23);
    [NativeTypeName("#define HDN_DIVIDERDBLCLICKA (HDN_FIRST-5)")]
    public const uint HDN_DIVIDERDBLCLICKA = unchecked((0U - 300U) - 5);
    [NativeTypeName("#define HDN_DIVIDERDBLCLICKW (HDN_FIRST-25)")]
    public const uint HDN_DIVIDERDBLCLICKW = unchecked((0U - 300U) - 25);
    [NativeTypeName("#define HDN_BEGINTRACKA (HDN_FIRST-6)")]
    public const uint HDN_BEGINTRACKA = unchecked((0U - 300U) - 6);
    [NativeTypeName("#define HDN_BEGINTRACKW (HDN_FIRST-26)")]
    public const uint HDN_BEGINTRACKW = unchecked((0U - 300U) - 26);
    [NativeTypeName("#define HDN_ENDTRACKA (HDN_FIRST-7)")]
    public const uint HDN_ENDTRACKA = unchecked((0U - 300U) - 7);
    [NativeTypeName("#define HDN_ENDTRACKW (HDN_FIRST-27)")]
    public const uint HDN_ENDTRACKW = unchecked((0U - 300U) - 27);
    [NativeTypeName("#define HDN_TRACKA (HDN_FIRST-8)")]
    public const uint HDN_TRACKA = unchecked((0U - 300U) - 8);
    [NativeTypeName("#define HDN_TRACKW (HDN_FIRST-28)")]
    public const uint HDN_TRACKW = unchecked((0U - 300U) - 28);
    [NativeTypeName("#define HDN_GETDISPINFOA (HDN_FIRST-9)")]
    public const uint HDN_GETDISPINFOA = unchecked((0U - 300U) - 9);
    [NativeTypeName("#define HDN_GETDISPINFOW (HDN_FIRST-29)")]
    public const uint HDN_GETDISPINFOW = unchecked((0U - 300U) - 29);
    [NativeTypeName("#define HDN_BEGINDRAG (HDN_FIRST-10)")]
    public const uint HDN_BEGINDRAG = unchecked((0U - 300U) - 10);
    [NativeTypeName("#define HDN_ENDDRAG (HDN_FIRST-11)")]
    public const uint HDN_ENDDRAG = unchecked((0U - 300U) - 11);
    [NativeTypeName("#define HDN_FILTERCHANGE (HDN_FIRST-12)")]
    public const uint HDN_FILTERCHANGE = unchecked((0U - 300U) - 12);
    [NativeTypeName("#define HDN_FILTERBTNCLICK (HDN_FIRST-13)")]
    public const uint HDN_FILTERBTNCLICK = unchecked((0U - 300U) - 13);
    [NativeTypeName("#define HDN_BEGINFILTEREDIT (HDN_FIRST-14)")]
    public const uint HDN_BEGINFILTEREDIT = unchecked((0U - 300U) - 14);
    [NativeTypeName("#define HDN_ENDFILTEREDIT (HDN_FIRST-15)")]
    public const uint HDN_ENDFILTEREDIT = unchecked((0U - 300U) - 15);
    [NativeTypeName("#define HDN_ITEMSTATEICONCLICK (HDN_FIRST-16)")]
    public const uint HDN_ITEMSTATEICONCLICK = unchecked((0U - 300U) - 16);
    [NativeTypeName("#define HDN_ITEMKEYDOWN (HDN_FIRST-17)")]
    public const uint HDN_ITEMKEYDOWN = unchecked((0U - 300U) - 17);
    [NativeTypeName("#define HDN_DROPDOWN (HDN_FIRST-18)")]
    public const uint HDN_DROPDOWN = unchecked((0U - 300U) - 18);
    [NativeTypeName("#define HDN_OVERFLOWCLICK (HDN_FIRST-19)")]
    public const uint HDN_OVERFLOWCLICK = unchecked((0U - 300U) - 19);
    [NativeTypeName("#define HDN_ITEMCHANGING HDN_ITEMCHANGINGW")]
    public const uint HDN_ITEMCHANGING = unchecked((0U - 300U) - 20);
    [NativeTypeName("#define HDN_ITEMCHANGED HDN_ITEMCHANGEDW")]
    public const uint HDN_ITEMCHANGED = unchecked((0U - 300U) - 21);
    [NativeTypeName("#define HDN_ITEMCLICK HDN_ITEMCLICKW")]
    public const uint HDN_ITEMCLICK = unchecked((0U - 300U) - 22);
    [NativeTypeName("#define HDN_ITEMDBLCLICK HDN_ITEMDBLCLICKW")]
    public const uint HDN_ITEMDBLCLICK = unchecked((0U - 300U) - 23);
    [NativeTypeName("#define HDN_DIVIDERDBLCLICK HDN_DIVIDERDBLCLICKW")]
    public const uint HDN_DIVIDERDBLCLICK = unchecked((0U - 300U) - 25);
    [NativeTypeName("#define HDN_BEGINTRACK HDN_BEGINTRACKW")]
    public const uint HDN_BEGINTRACK = unchecked((0U - 300U) - 26);
    [NativeTypeName("#define HDN_ENDTRACK HDN_ENDTRACKW")]
    public const uint HDN_ENDTRACK = unchecked((0U - 300U) - 27);
    [NativeTypeName("#define HDN_TRACK HDN_TRACKW")]
    public const uint HDN_TRACK = unchecked((0U - 300U) - 28);
    [NativeTypeName("#define HDN_GETDISPINFO HDN_GETDISPINFOW")]
    public const uint HDN_GETDISPINFO = unchecked((0U - 300U) - 29);
}