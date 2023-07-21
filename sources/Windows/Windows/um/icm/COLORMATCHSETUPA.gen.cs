// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA"]/*' />
public unsafe partial struct COLORMATCHSETUPA
{
    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.hwndOwner"]/*' />
    public HWND hwndOwner;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.pSourceName"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pSourceName;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.pDisplayName"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pDisplayName;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.pPrinterName"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* pPrinterName;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.dwRenderIntent"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRenderIntent;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.dwProofingIntent"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProofingIntent;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.pMonitorProfile"]/*' />
    [NativeTypeName("PSTR")]
    public sbyte* pMonitorProfile;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.ccMonitorProfile"]/*' />
    [NativeTypeName("DWORD")]
    public uint ccMonitorProfile;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.pPrinterProfile"]/*' />
    [NativeTypeName("PSTR")]
    public sbyte* pPrinterProfile;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.ccPrinterProfile"]/*' />
    [NativeTypeName("DWORD")]
    public uint ccPrinterProfile;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.pTargetProfile"]/*' />
    [NativeTypeName("PSTR")]
    public sbyte* pTargetProfile;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.ccTargetProfile"]/*' />
    [NativeTypeName("DWORD")]
    public uint ccTargetProfile;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.lpfnHook"]/*' />
    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpfnHook;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.lpfnApplyCallback"]/*' />
    [NativeTypeName("PCMSCALLBACKA")]
    public delegate* unmanaged<COLORMATCHSETUPA*, LPARAM, BOOL> lpfnApplyCallback;

    /// <include file='COLORMATCHSETUPA.xml' path='doc/member[@name="COLORMATCHSETUPA.lParamApplyCallback"]/*' />
    public LPARAM lParamApplyCallback;
}
