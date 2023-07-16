// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW"]/*'/>
public unsafe partial struct DIDEVICEIMAGEINFOW
{
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.tszImagePath"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort tszImagePath[260];
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwViewID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwViewID;
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.rcOverlay"]/*'/>
    public RECT rcOverlay;
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwObjID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwObjID;
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwcValidPts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcValidPts;
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.rgptCalloutLine"]/*'/>
    [NativeTypeName("POINT[5]")]
    public _rgptCalloutLine_e__FixedBuffer rgptCalloutLine;
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.rcCalloutRect"]/*'/>
    public RECT rcCalloutRect;
    /// <include file='DIDEVICEIMAGEINFOW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOW.dwTextAlign"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTextAlign;
    /// <include file='_rgptCalloutLine_e__FixedBuffer.xml' path='doc/member[@name="_rgptCalloutLine_e__FixedBuffer"]/*'/>
    public partial struct _rgptCalloutLine_e__FixedBuffer
    {
        public POINT e0;
        public POINT e1;
        public POINT e2;
        public POINT e3;
        public POINT e4;
        [UnscopedRef]
        public ref POINT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<POINT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 5);
    }
}