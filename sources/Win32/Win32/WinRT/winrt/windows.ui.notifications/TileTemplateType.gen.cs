// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum TileTemplateType
{
    [Obsolete(
        "TileSquareImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Image."
    )]
    TileTemplateType_TileSquareImage = 0,

    [Obsolete(
        "TileSquareBlock may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Block."
    )]
    TileTemplateType_TileSquareBlock = 1,

    [Obsolete(
        "TileSquareText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text01."
    )]
    TileTemplateType_TileSquareText01 = 2,

    [Obsolete(
        "TileSquareText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text02."
    )]
    TileTemplateType_TileSquareText02 = 3,

    [Obsolete(
        "TileSquareText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text03."
    )]
    TileTemplateType_TileSquareText03 = 4,

    [Obsolete(
        "TileSquareText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text04."
    )]
    TileTemplateType_TileSquareText04 = 5,

    [Obsolete(
        "TileSquarePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText01."
    )]
    TileTemplateType_TileSquarePeekImageAndText01 = 6,

    [Obsolete(
        "TileSquarePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText02."
    )]
    TileTemplateType_TileSquarePeekImageAndText02 = 7,

    [Obsolete(
        "TileSquarePeekImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText03."
    )]
    TileTemplateType_TileSquarePeekImageAndText03 = 8,

    [Obsolete(
        "TileSquarePeekImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText04."
    )]
    TileTemplateType_TileSquarePeekImageAndText04 = 9,

    [Obsolete(
        "TileWideImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Image."
    )]
    TileTemplateType_TileWideImage = 10,

    [Obsolete(
        "TileWideImageCollection may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageCollection."
    )]
    TileTemplateType_TileWideImageCollection = 11,

    [Obsolete(
        "TileWideImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText01."
    )]
    TileTemplateType_TileWideImageAndText01 = 12,

    [Obsolete(
        "TileWideImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText02."
    )]
    TileTemplateType_TileWideImageAndText02 = 13,

    [Obsolete(
        "TileWideBlockAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText01."
    )]
    TileTemplateType_TileWideBlockAndText01 = 14,

    [Obsolete(
        "TileWideBlockAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText02."
    )]
    TileTemplateType_TileWideBlockAndText02 = 15,

    [Obsolete(
        "TileWidePeekImageCollection01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection01."
    )]
    TileTemplateType_TileWidePeekImageCollection01 = 16,

    [Obsolete(
        "TileWidePeekImageCollection02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection02."
    )]
    TileTemplateType_TileWidePeekImageCollection02 = 17,

    [Obsolete(
        "TileWidePeekImageCollection03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection03."
    )]
    TileTemplateType_TileWidePeekImageCollection03 = 18,

    [Obsolete(
        "TileWidePeekImageCollection04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection04."
    )]
    TileTemplateType_TileWidePeekImageCollection04 = 19,

    [Obsolete(
        "TileWidePeekImageCollection05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection05."
    )]
    TileTemplateType_TileWidePeekImageCollection05 = 20,

    [Obsolete(
        "TileWidePeekImageCollection06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection06."
    )]
    TileTemplateType_TileWidePeekImageCollection06 = 21,

    [Obsolete(
        "TileWidePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText01."
    )]
    TileTemplateType_TileWidePeekImageAndText01 = 22,

    [Obsolete(
        "TileWidePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText02."
    )]
    TileTemplateType_TileWidePeekImageAndText02 = 23,

    [Obsolete(
        "TileWidePeekImage01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage01."
    )]
    TileTemplateType_TileWidePeekImage01 = 24,

    [Obsolete(
        "TileWidePeekImage02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage02."
    )]
    TileTemplateType_TileWidePeekImage02 = 25,

    [Obsolete(
        "TileWidePeekImage03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage03."
    )]
    TileTemplateType_TileWidePeekImage03 = 26,

    [Obsolete(
        "TileWidePeekImage04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage04."
    )]
    TileTemplateType_TileWidePeekImage04 = 27,

    [Obsolete(
        "TileWidePeekImage05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage05."
    )]
    TileTemplateType_TileWidePeekImage05 = 28,

    [Obsolete(
        "TileWidePeekImage06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage06."
    )]
    TileTemplateType_TileWidePeekImage06 = 29,

    [Obsolete(
        "TileWideSmallImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText01."
    )]
    TileTemplateType_TileWideSmallImageAndText01 = 30,

    [Obsolete(
        "TileWideSmallImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText02."
    )]
    TileTemplateType_TileWideSmallImageAndText02 = 31,

    [Obsolete(
        "TileWideSmallImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText03."
    )]
    TileTemplateType_TileWideSmallImageAndText03 = 32,

    [Obsolete(
        "TileWideSmallImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText04."
    )]
    TileTemplateType_TileWideSmallImageAndText04 = 33,

    [Obsolete(
        "TileWideSmallImageAndText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText05."
    )]
    TileTemplateType_TileWideSmallImageAndText05 = 34,

    [Obsolete(
        "TileWideText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text01."
    )]
    TileTemplateType_TileWideText01 = 35,

    [Obsolete(
        "TileWideText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text02."
    )]
    TileTemplateType_TileWideText02 = 36,

    [Obsolete(
        "TileWideText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text03."
    )]
    TileTemplateType_TileWideText03 = 37,

    [Obsolete(
        "TileWideText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text04."
    )]
    TileTemplateType_TileWideText04 = 38,

    [Obsolete(
        "TileWideText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text05."
    )]
    TileTemplateType_TileWideText05 = 39,

    [Obsolete(
        "TileWideText06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text06."
    )]
    TileTemplateType_TileWideText06 = 40,

    [Obsolete(
        "TileWideText07 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text07."
    )]
    TileTemplateType_TileWideText07 = 41,

    [Obsolete(
        "TileWideText08 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text08."
    )]
    TileTemplateType_TileWideText08 = 42,

    [Obsolete(
        "TileWideText09 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text09."
    )]
    TileTemplateType_TileWideText09 = 43,

    [Obsolete(
        "TileWideText10 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text10."
    )]
    TileTemplateType_TileWideText10 = 44,

    [Obsolete(
        "TileWideText11 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text11."
    )]
    TileTemplateType_TileWideText11 = 45,
    TileTemplateType_TileSquare150x150Image = 0,
    TileTemplateType_TileSquare150x150Block = 1,
    TileTemplateType_TileSquare150x150Text01 = 2,
    TileTemplateType_TileSquare150x150Text02 = 3,
    TileTemplateType_TileSquare150x150Text03 = 4,
    TileTemplateType_TileSquare150x150Text04 = 5,
    TileTemplateType_TileSquare150x150PeekImageAndText01 = 6,
    TileTemplateType_TileSquare150x150PeekImageAndText02 = 7,
    TileTemplateType_TileSquare150x150PeekImageAndText03 = 8,
    TileTemplateType_TileSquare150x150PeekImageAndText04 = 9,
    TileTemplateType_TileWide310x150Image = 10,
    TileTemplateType_TileWide310x150ImageCollection = 11,
    TileTemplateType_TileWide310x150ImageAndText01 = 12,
    TileTemplateType_TileWide310x150ImageAndText02 = 13,
    TileTemplateType_TileWide310x150BlockAndText01 = 14,
    TileTemplateType_TileWide310x150BlockAndText02 = 15,
    TileTemplateType_TileWide310x150PeekImageCollection01 = 16,
    TileTemplateType_TileWide310x150PeekImageCollection02 = 17,
    TileTemplateType_TileWide310x150PeekImageCollection03 = 18,
    TileTemplateType_TileWide310x150PeekImageCollection04 = 19,
    TileTemplateType_TileWide310x150PeekImageCollection05 = 20,
    TileTemplateType_TileWide310x150PeekImageCollection06 = 21,
    TileTemplateType_TileWide310x150PeekImageAndText01 = 22,
    TileTemplateType_TileWide310x150PeekImageAndText02 = 23,
    TileTemplateType_TileWide310x150PeekImage01 = 24,
    TileTemplateType_TileWide310x150PeekImage02 = 25,
    TileTemplateType_TileWide310x150PeekImage03 = 26,
    TileTemplateType_TileWide310x150PeekImage04 = 27,
    TileTemplateType_TileWide310x150PeekImage05 = 28,
    TileTemplateType_TileWide310x150PeekImage06 = 29,
    TileTemplateType_TileWide310x150SmallImageAndText01 = 30,
    TileTemplateType_TileWide310x150SmallImageAndText02 = 31,
    TileTemplateType_TileWide310x150SmallImageAndText03 = 32,
    TileTemplateType_TileWide310x150SmallImageAndText04 = 33,
    TileTemplateType_TileWide310x150SmallImageAndText05 = 34,
    TileTemplateType_TileWide310x150Text01 = 35,
    TileTemplateType_TileWide310x150Text02 = 36,
    TileTemplateType_TileWide310x150Text03 = 37,
    TileTemplateType_TileWide310x150Text04 = 38,
    TileTemplateType_TileWide310x150Text05 = 39,
    TileTemplateType_TileWide310x150Text06 = 40,
    TileTemplateType_TileWide310x150Text07 = 41,
    TileTemplateType_TileWide310x150Text08 = 42,
    TileTemplateType_TileWide310x150Text09 = 43,
    TileTemplateType_TileWide310x150Text10 = 44,
    TileTemplateType_TileWide310x150Text11 = 45,
    TileTemplateType_TileSquare310x310BlockAndText01 = 46,
    TileTemplateType_TileSquare310x310BlockAndText02 = 47,
    TileTemplateType_TileSquare310x310Image = 48,
    TileTemplateType_TileSquare310x310ImageAndText01 = 49,
    TileTemplateType_TileSquare310x310ImageAndText02 = 50,
    TileTemplateType_TileSquare310x310ImageAndTextOverlay01 = 51,
    TileTemplateType_TileSquare310x310ImageAndTextOverlay02 = 52,
    TileTemplateType_TileSquare310x310ImageAndTextOverlay03 = 53,
    TileTemplateType_TileSquare310x310ImageCollectionAndText01 = 54,
    TileTemplateType_TileSquare310x310ImageCollectionAndText02 = 55,
    TileTemplateType_TileSquare310x310ImageCollection = 56,
    TileTemplateType_TileSquare310x310SmallImagesAndTextList01 = 57,
    TileTemplateType_TileSquare310x310SmallImagesAndTextList02 = 58,
    TileTemplateType_TileSquare310x310SmallImagesAndTextList03 = 59,
    TileTemplateType_TileSquare310x310SmallImagesAndTextList04 = 60,
    TileTemplateType_TileSquare310x310Text01 = 61,
    TileTemplateType_TileSquare310x310Text02 = 62,
    TileTemplateType_TileSquare310x310Text03 = 63,
    TileTemplateType_TileSquare310x310Text04 = 64,
    TileTemplateType_TileSquare310x310Text05 = 65,
    TileTemplateType_TileSquare310x310Text06 = 66,
    TileTemplateType_TileSquare310x310Text07 = 67,
    TileTemplateType_TileSquare310x310Text08 = 68,
    TileTemplateType_TileSquare310x310TextList01 = 69,
    TileTemplateType_TileSquare310x310TextList02 = 70,
    TileTemplateType_TileSquare310x310TextList03 = 71,
    TileTemplateType_TileSquare310x310SmallImageAndText01 = 72,
    TileTemplateType_TileSquare310x310SmallImagesAndTextList05 = 73,
    TileTemplateType_TileSquare310x310Text09 = 74,
    TileTemplateType_TileSquare71x71IconWithBadge = 75,
    TileTemplateType_TileSquare150x150IconWithBadge = 76,
    TileTemplateType_TileWide310x150IconWithBadgeAndText = 77,
    TileTemplateType_TileSquare71x71Image = 78,
    TileTemplateType_TileTall150x310Image = 79,
}
