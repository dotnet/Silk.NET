// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct COLORMATCHSETUPW
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public HWND hwndOwner;

    [NativeTypeName("PCWSTR")]
    public ushort* pSourceName;

    [NativeTypeName("PCWSTR")]
    public ushort* pDisplayName;

    [NativeTypeName("PCWSTR")]
    public ushort* pPrinterName;

    [NativeTypeName("DWORD")]
    public uint dwRenderIntent;

    [NativeTypeName("DWORD")]
    public uint dwProofingIntent;

    [NativeTypeName("PWSTR")]
    public ushort* pMonitorProfile;

    [NativeTypeName("DWORD")]
    public uint ccMonitorProfile;

    [NativeTypeName("PWSTR")]
    public ushort* pPrinterProfile;

    [NativeTypeName("DWORD")]
    public uint ccPrinterProfile;

    [NativeTypeName("PWSTR")]
    public ushort* pTargetProfile;

    [NativeTypeName("DWORD")]
    public uint ccTargetProfile;

    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpfnHook;
    public LPARAM lParam;

    [NativeTypeName("PCMSCALLBACKW")]
    public delegate* unmanaged<COLORMATCHSETUPW*, LPARAM, BOOL> lpfnApplyCallback;
    public LPARAM lParamApplyCallback;
}
