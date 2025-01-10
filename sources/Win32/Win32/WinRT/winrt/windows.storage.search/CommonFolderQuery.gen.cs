// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CommonFolderQuery
{
    CommonFolderQuery_DefaultQuery = 0,
    CommonFolderQuery_GroupByYear = 100,
    CommonFolderQuery_GroupByMonth = 101,
    CommonFolderQuery_GroupByArtist = 102,
    CommonFolderQuery_GroupByAlbum = 103,
    CommonFolderQuery_GroupByAlbumArtist = 104,
    CommonFolderQuery_GroupByComposer = 105,
    CommonFolderQuery_GroupByGenre = 106,
    CommonFolderQuery_GroupByPublishedYear = 107,
    CommonFolderQuery_GroupByRating = 108,
    CommonFolderQuery_GroupByTag = 109,
    CommonFolderQuery_GroupByAuthor = 110,
    CommonFolderQuery_GroupByType = 111,
}
