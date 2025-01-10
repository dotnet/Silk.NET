// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DIACTIONFORMATA
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwActionSize;

    [NativeTypeName("DWORD")]
    public uint dwDataSize;

    [NativeTypeName("DWORD")]
    public uint dwNumActions;

    [NativeTypeName("LPDIACTIONA")]
    public DIACTIONA* rgoAction;
    public Guid guidActionMap;

    [NativeTypeName("DWORD")]
    public uint dwGenre;

    [NativeTypeName("DWORD")]
    public uint dwBufferSize;

    [NativeTypeName("LONG")]
    public int lAxisMin;

    [NativeTypeName("LONG")]
    public int lAxisMax;
    public HINSTANCE hInstString;
    public FILETIME ftTimeStamp;

    [NativeTypeName("DWORD")]
    public uint dwCRC;

    [NativeTypeName("CHAR[260]")]
    public _tszActionMap_e__FixedBuffer tszActionMap;

    [InlineArray(260)]
    public partial struct _tszActionMap_e__FixedBuffer
    {
        public sbyte e0;
    }
}
