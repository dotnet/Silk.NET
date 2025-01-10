// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIDEVICEOBJECTINSTANCE
{
    [NativeTypeName("DWORD")]
    public uint dwSize;
    public Guid guidType;

    [NativeTypeName("DWORD")]
    public uint dwOfs;

    [NativeTypeName("DWORD")]
    public uint dwType;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("WCHAR[260]")]
    public _tszName_e__FixedBuffer tszName;

    [NativeTypeName("DWORD")]
    public uint dwFFMaxForce;

    [NativeTypeName("DWORD")]
    public uint dwFFForceResolution;

    [NativeTypeName("WORD")]
    public ushort wCollectionNumber;

    [NativeTypeName("WORD")]
    public ushort wDesignatorIndex;

    [NativeTypeName("WORD")]
    public ushort wUsagePage;

    [NativeTypeName("WORD")]
    public ushort wUsage;

    [NativeTypeName("DWORD")]
    public uint dwDimension;

    [NativeTypeName("WORD")]
    public ushort wExponent;

    [NativeTypeName("WORD")]
    public ushort wReportId;

    [InlineArray(260)]
    public partial struct _tszName_e__FixedBuffer
    {
        public ushort e0;
    }
}
