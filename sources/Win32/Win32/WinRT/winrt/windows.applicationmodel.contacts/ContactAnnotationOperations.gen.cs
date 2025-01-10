// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum ContactAnnotationOperations : uint
{
    ContactAnnotationOperations_None = 0,
    ContactAnnotationOperations_ContactProfile = 0x1,
    ContactAnnotationOperations_Message = 0x2,
    ContactAnnotationOperations_AudioCall = 0x4,
    ContactAnnotationOperations_VideoCall = 0x8,
    ContactAnnotationOperations_SocialFeeds = 0x10,
    ContactAnnotationOperations_Share = 0x20,
}
