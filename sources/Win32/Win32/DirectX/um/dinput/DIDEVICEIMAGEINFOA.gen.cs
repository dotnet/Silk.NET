// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIDEVICEIMAGEINFOA
{
    [NativeTypeName("CHAR[260]")]
    public _tszImagePath_e__FixedBuffer tszImagePath;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwViewID;
    public RECT rcOverlay;

    [NativeTypeName("DWORD")]
    public uint dwObjID;

    [NativeTypeName("DWORD")]
    public uint dwcValidPts;

    [NativeTypeName("POINT[5]")]
    public _rgptCalloutLine_e__FixedBuffer rgptCalloutLine;
    public RECT rcCalloutRect;

    [NativeTypeName("DWORD")]
    public uint dwTextAlign;

    [InlineArray(260)]
    public partial struct _tszImagePath_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(5)]
    public partial struct _rgptCalloutLine_e__FixedBuffer
    {
        public POINT e0;
    }
}
