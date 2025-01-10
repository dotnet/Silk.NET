// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum KnownFolderId
{
    KnownFolderId_AppCaptures = 0,
    KnownFolderId_CameraRoll = 1,
    KnownFolderId_DocumentsLibrary = 2,
    KnownFolderId_HomeGroup = 3,
    KnownFolderId_MediaServerDevices = 4,
    KnownFolderId_MusicLibrary = 5,
    KnownFolderId_Objects3D = 6,
    KnownFolderId_PicturesLibrary = 7,
    KnownFolderId_Playlists = 8,
    KnownFolderId_RecordedCalls = 9,
    KnownFolderId_RemovableDevices = 10,
    KnownFolderId_SavedPictures = 11,
    KnownFolderId_Screenshots = 12,
    KnownFolderId_VideosLibrary = 13,
    KnownFolderId_AllAppMods = 14,
    KnownFolderId_CurrentAppMods = 15,
    KnownFolderId_DownloadsFolder = 16,
}
