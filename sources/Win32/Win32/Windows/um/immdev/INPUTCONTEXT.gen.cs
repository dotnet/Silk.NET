// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct INPUTCONTEXT
{
    public HWND hWnd;
    public BOOL fOpen;
    public POINT ptStatusWndPos;
    public POINT ptSoftKbdPos;

    [NativeTypeName("DWORD")]
    public uint fdwConversion;

    [NativeTypeName("DWORD")]
    public uint fdwSentence;

    [NativeTypeName("__AnonymousRecord_immdev_L873_C5")]
    public _lfFont_e__Union lfFont;
    public COMPOSITIONFORM cfCompForm;

    [NativeTypeName("CANDIDATEFORM[4]")]
    public _cfCandForm_e__FixedBuffer cfCandForm;
    public HIMCC hCompStr;
    public HIMCC hCandInfo;
    public HIMCC hGuideLine;
    public HIMCC hPrivate;

    [NativeTypeName("DWORD")]
    public uint dwNumMsgBuf;
    public HIMCC hMsgBuf;

    [NativeTypeName("DWORD")]
    public uint fdwInit;

    [NativeTypeName("DWORD[3]")]
    public _dwReserve_e__FixedBuffer dwReserve;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _lfFont_e__Union
    {
        [FieldOffset(0)]
        public LOGFONTA A;

        [FieldOffset(0)]
        public LOGFONTW W;
    }

    [InlineArray(4)]
    public partial struct _cfCandForm_e__FixedBuffer
    {
        public CANDIDATEFORM e0;
    }

    [InlineArray(3)]
    public partial struct _dwReserve_e__FixedBuffer
    {
        public uint e0;
    }
}
