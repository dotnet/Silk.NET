// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct COLORMATCHSETUPA
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public HWND hwndOwner;

    [NativeTypeName("PCSTR")]
    public sbyte* pSourceName;

    [NativeTypeName("PCSTR")]
    public sbyte* pDisplayName;

    [NativeTypeName("PCSTR")]
    public sbyte* pPrinterName;

    [NativeTypeName("DWORD")]
    public uint dwRenderIntent;

    [NativeTypeName("DWORD")]
    public uint dwProofingIntent;

    [NativeTypeName("PSTR")]
    public sbyte* pMonitorProfile;

    [NativeTypeName("DWORD")]
    public uint ccMonitorProfile;

    [NativeTypeName("PSTR")]
    public sbyte* pPrinterProfile;

    [NativeTypeName("DWORD")]
    public uint ccPrinterProfile;

    [NativeTypeName("PSTR")]
    public sbyte* pTargetProfile;

    [NativeTypeName("DWORD")]
    public uint ccTargetProfile;

    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpfnHook;
    public LPARAM lParam;

    [NativeTypeName("PCMSCALLBACKA")]
    public delegate* unmanaged<COLORMATCHSETUPA*, LPARAM, BOOL> lpfnApplyCallback;
    public LPARAM lParamApplyCallback;
}
