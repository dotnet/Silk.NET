// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.FOLDERTYPEID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FOLDERTYPEID"/> class.</summary>
public static partial class FOLDERTYPEIDTests
{
    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Invalid"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_InvalidTest()
    {
        Assert.That(FOLDERTYPEID_Invalid, Is.EqualTo(new Guid(0x57807898, 0x8c4f, 0x4462, 0xbb, 0x63, 0x71, 0x04, 0x23, 0x80, 0xb1, 0x09)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Generic"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_GenericTest()
    {
        Assert.That(FOLDERTYPEID_Generic, Is.EqualTo(new Guid(0x5c4f28b5, 0xf869, 0x4e84, 0x8e, 0x60, 0xf1, 0x1d, 0xb9, 0x7c, 0x5c, 0xc7)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_GenericSearchResults"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_GenericSearchResultsTest()
    {
        Assert.That(FOLDERTYPEID_GenericSearchResults, Is.EqualTo(new Guid(0x7fde1a1e, 0x8b31, 0x49a5, 0x93, 0xb8, 0x6b, 0xe1, 0x4c, 0xfa, 0x49, 0x43)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_GenericLibrary"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_GenericLibraryTest()
    {
        Assert.That(FOLDERTYPEID_GenericLibrary, Is.EqualTo(new Guid(0x5f4eab9a, 0x6833, 0x4f61, 0x89, 0x9d, 0x31, 0xcf, 0x46, 0x97, 0x9d, 0x49)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Documents"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_DocumentsTest()
    {
        Assert.That(FOLDERTYPEID_Documents, Is.EqualTo(new Guid(0x7d49d726, 0x3c21, 0x4f05, 0x99, 0xaa, 0xfd, 0xc2, 0xc9, 0x47, 0x46, 0x56)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Pictures"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_PicturesTest()
    {
        Assert.That(FOLDERTYPEID_Pictures, Is.EqualTo(new Guid(0xb3690e58, 0xe961, 0x423b, 0xb6, 0x87, 0x38, 0x6e, 0xbf, 0xd8, 0x32, 0x39)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Music"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_MusicTest()
    {
        Assert.That(FOLDERTYPEID_Music, Is.EqualTo(new Guid(0x94d6ddcc, 0x4a68, 0x4175, 0xa3, 0x74, 0xbd, 0x58, 0x4a, 0x51, 0x0b, 0x78)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Videos"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_VideosTest()
    {
        Assert.That(FOLDERTYPEID_Videos, Is.EqualTo(new Guid(0x5fa96407, 0x7e77, 0x483c, 0xac, 0x93, 0x69, 0x1d, 0x05, 0x85, 0x0d, 0xe8)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Downloads"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_DownloadsTest()
    {
        Assert.That(FOLDERTYPEID_Downloads, Is.EqualTo(new Guid(0x885a186e, 0xa440, 0x4ada, 0x81, 0x2b, 0xdb, 0x87, 0x1b, 0x94, 0x22, 0x59)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_UserFiles"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_UserFilesTest()
    {
        Assert.That(FOLDERTYPEID_UserFiles, Is.EqualTo(new Guid(0xcd0fc69b, 0x71e2, 0x46e5, 0x96, 0x90, 0x5b, 0xcd, 0x9f, 0x57, 0xaa, 0xb3)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_UsersLibraries"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_UsersLibrariesTest()
    {
        Assert.That(FOLDERTYPEID_UsersLibraries, Is.EqualTo(new Guid(0xc4d98f09, 0x6124, 0x4fe0, 0x99, 0x42, 0x82, 0x64, 0x16, 0x8, 0x2d, 0xa9)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_OtherUsers"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_OtherUsersTest()
    {
        Assert.That(FOLDERTYPEID_OtherUsers, Is.EqualTo(new Guid(0xb337fd00, 0x9dd5, 0x4635, 0xa6, 0xd4, 0xda, 0x33, 0xfd, 0x10, 0x2b, 0x7a)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_PublishedItems"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_PublishedItemsTest()
    {
        Assert.That(FOLDERTYPEID_PublishedItems, Is.EqualTo(new Guid(0x7f2f5b96, 0xff74, 0x41da, 0xaf, 0xd8, 0x1c, 0x78, 0xa5, 0xf3, 0xae, 0xa2)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Communications"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_CommunicationsTest()
    {
        Assert.That(FOLDERTYPEID_Communications, Is.EqualTo(new Guid(0x91475fe5, 0x586b, 0x4eba, 0x8d, 0x75, 0xd1, 0x74, 0x34, 0xb8, 0xcd, 0xf6)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Contacts"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_ContactsTest()
    {
        Assert.That(FOLDERTYPEID_Contacts, Is.EqualTo(new Guid(0xde2b70ec, 0x9bf7, 0x4a93, 0xbd, 0x3d, 0x24, 0x3f, 0x78, 0x81, 0xd4, 0x92)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_StartMenu"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_StartMenuTest()
    {
        Assert.That(FOLDERTYPEID_StartMenu, Is.EqualTo(new Guid(0xef87b4cb, 0xf2ce, 0x4785, 0x86, 0x58, 0x4c, 0xa6, 0xc6, 0x3e, 0x38, 0xc6)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_RecordedTV"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_RecordedTVTest()
    {
        Assert.That(FOLDERTYPEID_RecordedTV, Is.EqualTo(new Guid(0x5557a28f, 0x5da6, 0x4f83, 0x88, 0x09, 0xc2, 0xc9, 0x8a, 0x11, 0xa6, 0xfa)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_SavedGames"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_SavedGamesTest()
    {
        Assert.That(FOLDERTYPEID_SavedGames, Is.EqualTo(new Guid(0xd0363307, 0x28cb, 0x4106, 0x9f, 0x23, 0x29, 0x56, 0xe3, 0xe5, 0xe0, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_OpenSearch"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_OpenSearchTest()
    {
        Assert.That(FOLDERTYPEID_OpenSearch, Is.EqualTo(new Guid(0x8faf9629, 0x1980, 0x46ff, 0x80, 0x23, 0x9d, 0xce, 0xab, 0x9c, 0x3e, 0xe3)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_SearchConnector"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_SearchConnectorTest()
    {
        Assert.That(FOLDERTYPEID_SearchConnector, Is.EqualTo(new Guid(0x982725ee, 0x6f47, 0x479e, 0xb4, 0x47, 0x81, 0x2b, 0xfa, 0x7d, 0x2e, 0x8f)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_AccountPictures"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_AccountPicturesTest()
    {
        Assert.That(FOLDERTYPEID_AccountPictures, Is.EqualTo(new Guid(0xdb2a5d8f, 0x06e6, 0x4007, 0xab, 0xa6, 0xaf, 0x87, 0x7d, 0x52, 0x6e, 0xa6)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Games"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_GamesTest()
    {
        Assert.That(FOLDERTYPEID_Games, Is.EqualTo(new Guid(0xb689b0d0, 0x76d3, 0x4cbb, 0x87, 0xf7, 0x58, 0x5d, 0x0e, 0x0c, 0xe0, 0x70)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_ControlPanelCategory"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_ControlPanelCategoryTest()
    {
        Assert.That(FOLDERTYPEID_ControlPanelCategory, Is.EqualTo(new Guid(0xde4f0660, 0xfa10, 0x4b8f, 0xa4, 0x94, 0x06, 0x8b, 0x20, 0xb2, 0x23, 0x07)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_ControlPanelClassic"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_ControlPanelClassicTest()
    {
        Assert.That(FOLDERTYPEID_ControlPanelClassic, Is.EqualTo(new Guid(0x0c3794f3, 0xb545, 0x43aa, 0xa3, 0x29, 0xc3, 0x74, 0x30, 0xc5, 0x8d, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Printers"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_PrintersTest()
    {
        Assert.That(FOLDERTYPEID_Printers, Is.EqualTo(new Guid(0x2c7bbec6, 0xc844, 0x4a0a, 0x91, 0xfa, 0xce, 0xf6, 0xf5, 0x9c, 0xfd, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_RecycleBin"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_RecycleBinTest()
    {
        Assert.That(FOLDERTYPEID_RecycleBin, Is.EqualTo(new Guid(0xd6d9e004, 0xcd87, 0x442b, 0x9d, 0x57, 0x5e, 0x0a, 0xeb, 0x4f, 0x6f, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_SoftwareExplorer"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_SoftwareExplorerTest()
    {
        Assert.That(FOLDERTYPEID_SoftwareExplorer, Is.EqualTo(new Guid(0xd674391b, 0x52d9, 0x4e07, 0x83, 0x4e, 0x67, 0xc9, 0x86, 0x10, 0xf3, 0x9d)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_CompressedFolder"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_CompressedFolderTest()
    {
        Assert.That(FOLDERTYPEID_CompressedFolder, Is.EqualTo(new Guid(0x80213e82, 0xbcfd, 0x4c4f, 0x88, 0x17, 0xbb, 0x27, 0x60, 0x12, 0x67, 0xa9)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_NetworkExplorer"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_NetworkExplorerTest()
    {
        Assert.That(FOLDERTYPEID_NetworkExplorer, Is.EqualTo(new Guid(0x25cc242b, 0x9a7c, 0x4f51, 0x80, 0xe0, 0x7a, 0x29, 0x28, 0xfe, 0xbe, 0x42)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_Searches"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_SearchesTest()
    {
        Assert.That(FOLDERTYPEID_Searches, Is.EqualTo(new Guid(0x0b0ba2e3, 0x405f, 0x415e, 0xa6, 0xee, 0xca, 0xd6, 0x25, 0x20, 0x78, 0x53)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_SearchHome"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_SearchHomeTest()
    {
        Assert.That(FOLDERTYPEID_SearchHome, Is.EqualTo(new Guid(0x834d8a44, 0x0974, 0x4ed6, 0x86, 0x6e, 0xf2, 0x03, 0xd8, 0x0b, 0x38, 0x10)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_StorageProviderGeneric"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_StorageProviderGenericTest()
    {
        Assert.That(FOLDERTYPEID_StorageProviderGeneric, Is.EqualTo(new Guid(0x4F01EBC5, 0x2385, 0x41f2, 0xA2, 0x8E, 0x2C, 0x5C, 0x91, 0xFB, 0x56, 0xE0)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_StorageProviderDocuments"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_StorageProviderDocumentsTest()
    {
        Assert.That(FOLDERTYPEID_StorageProviderDocuments, Is.EqualTo(new Guid(0xDD61BD66, 0x70E8, 0x48dd, 0x96, 0x55, 0x65, 0xC5, 0xE1, 0xAA, 0xC2, 0xD1)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_StorageProviderPictures"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_StorageProviderPicturesTest()
    {
        Assert.That(FOLDERTYPEID_StorageProviderPictures, Is.EqualTo(new Guid(0x71d642a9, 0xf2b1, 0x42cd, 0xad, 0x92, 0xeb, 0x93, 0x0, 0xc7, 0xcc, 0xa)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_StorageProviderMusic"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_StorageProviderMusicTest()
    {
        Assert.That(FOLDERTYPEID_StorageProviderMusic, Is.EqualTo(new Guid(0x672ECD7E, 0xAF04, 0x4399, 0x87, 0x5C, 0x02, 0x90, 0x84, 0x5B, 0x62, 0x47)));
    }

    /// <summary>Validates that the value of the <see cref = "FOLDERTYPEID_StorageProviderVideos"/> property is correct.</summary>
    [Test]
    public static void FOLDERTYPEID_StorageProviderVideosTest()
    {
        Assert.That(FOLDERTYPEID_StorageProviderVideos, Is.EqualTo(new Guid(0x51294DA1, 0xD7B1, 0x485b, 0x9E, 0x9A, 0x17, 0xCF, 0xFE, 0x33, 0xE1, 0x87)));
    }
}