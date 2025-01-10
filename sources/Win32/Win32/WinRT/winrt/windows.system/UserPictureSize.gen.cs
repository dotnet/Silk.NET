// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum UserPictureSize
{
    UserPictureSize_Size64x64 = 0,
    UserPictureSize_Size208x208 = 1,
    UserPictureSize_Size424x424 = 2,
    UserPictureSize_Size1080x1080 = 3,
}
