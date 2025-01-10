// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PickerLocationId
{
    PickerLocationId_DocumentsLibrary = 0,
    PickerLocationId_ComputerFolder = 1,
    PickerLocationId_Desktop = 2,
    PickerLocationId_Downloads = 3,
    PickerLocationId_HomeGroup = 4,
    PickerLocationId_MusicLibrary = 5,
    PickerLocationId_PicturesLibrary = 6,
    PickerLocationId_VideosLibrary = 7,
    PickerLocationId_Objects3D = 8,
    PickerLocationId_Unspecified = 9,
}
