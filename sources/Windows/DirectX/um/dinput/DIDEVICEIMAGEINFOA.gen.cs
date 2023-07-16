// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA"]/*'/>
public unsafe partial struct DIDEVICEIMAGEINFOA
{
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.tszImagePath"]/*'/>
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte tszImagePath[260];
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.dwViewID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwViewID;
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.rcOverlay"]/*'/>
    public RECT rcOverlay;
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.dwObjID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwObjID;
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.dwcValidPts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcValidPts;
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.rgptCalloutLine"]/*'/>
    [NativeTypeName("POINT[5]")]
    public _rgptCalloutLine_e__FixedBuffer rgptCalloutLine;
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.rcCalloutRect"]/*'/>
    public RECT rcCalloutRect;
    /// <include file='DIDEVICEIMAGEINFOA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOA.dwTextAlign"]/*'/>
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