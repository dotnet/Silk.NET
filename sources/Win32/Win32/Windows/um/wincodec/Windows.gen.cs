// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICConvertBitmapSource(
        [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat,
        IWICBitmapSource pISrc,
        IWICBitmapSource* ppIDst
    );

    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICCreateBitmapFromSection(
        uint width,
        uint height,
        [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
        HANDLE hSection,
        uint stride,
        uint offset,
        IWICBitmap* ppIBitmap
    );

    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICCreateBitmapFromSectionEx(
        uint width,
        uint height,
        [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat,
        HANDLE hSection,
        uint stride,
        uint offset,
        WICSectionAccessLevel desiredAccessLevel,
        IWICBitmap* ppIBitmap
    );

    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICMapGuidToShortName(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint cchName,
        [NativeTypeName("WCHAR *")] ushort* wzName,
        uint* pcchActual
    );

    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICMapShortNameToGuid(
        [NativeTypeName("PCWSTR")] ushort* wzName,
        Guid* pguid
    );

    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICMapSchemaToName(
        [NativeTypeName("const GUID &")] Guid* guidMetadataFormat,
        [NativeTypeName("LPWSTR")] ushort* pwzSchema,
        uint cchName,
        [NativeTypeName("WCHAR *")] ushort* wzName,
        uint* pcchActual
    );
}
