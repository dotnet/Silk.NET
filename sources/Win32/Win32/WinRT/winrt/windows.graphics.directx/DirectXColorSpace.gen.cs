// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.directx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DirectXColorSpace
{
    DirectXColorSpace_RgbFullG22NoneP709 = 0,
    DirectXColorSpace_RgbFullG10NoneP709 = 1,
    DirectXColorSpace_RgbStudioG22NoneP709 = 2,
    DirectXColorSpace_RgbStudioG22NoneP2020 = 3,
    DirectXColorSpace_Reserved = 4,
    DirectXColorSpace_YccFullG22NoneP709X601 = 5,
    DirectXColorSpace_YccStudioG22LeftP601 = 6,
    DirectXColorSpace_YccFullG22LeftP601 = 7,
    DirectXColorSpace_YccStudioG22LeftP709 = 8,
    DirectXColorSpace_YccFullG22LeftP709 = 9,
    DirectXColorSpace_YccStudioG22LeftP2020 = 10,
    DirectXColorSpace_YccFullG22LeftP2020 = 11,
    DirectXColorSpace_RgbFullG2084NoneP2020 = 12,
    DirectXColorSpace_YccStudioG2084LeftP2020 = 13,
    DirectXColorSpace_RgbStudioG2084NoneP2020 = 14,
    DirectXColorSpace_YccStudioG22TopLeftP2020 = 15,
    DirectXColorSpace_YccStudioG2084TopLeftP2020 = 16,
    DirectXColorSpace_RgbFullG22NoneP2020 = 17,
    DirectXColorSpace_YccStudioGHlgTopLeftP2020 = 18,
    DirectXColorSpace_YccFullGHlgTopLeftP2020 = 19,
    DirectXColorSpace_RgbStudioG24NoneP709 = 20,
    DirectXColorSpace_RgbStudioG24NoneP2020 = 21,
    DirectXColorSpace_YccStudioG24LeftP709 = 22,
    DirectXColorSpace_YccStudioG24LeftP2020 = 23,
    DirectXColorSpace_YccStudioG24TopLeftP2020 = 24,
}
