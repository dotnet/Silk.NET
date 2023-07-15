// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2"]/*'/>
public partial struct VIDEOINFOHEADER2
{
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.rcSource"]/*'/>
    public RECT rcSource;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.rcTarget"]/*'/>
    public RECT rcTarget;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.dwBitRate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBitRate;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.dwBitErrorRate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBitErrorRate;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.AvgTimePerFrame"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long AvgTimePerFrame;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.dwInterlaceFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInterlaceFlags;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.dwCopyProtectFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCopyProtectFlags;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.dwPictAspectRatioX"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPictAspectRatioX;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.dwPictAspectRatioY"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPictAspectRatioY;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_dvdmedia_L317_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
    /// <include file='VIDEOINFOHEADER2.xml' path='doc/member[@name="VIDEOINFOHEADER2.bmiHeader"]/*'/>
    public BITMAPINFOHEADER bmiHeader;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwControlFlags"]/*'/>
    [UnscopedRef]
    public ref uint dwControlFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwControlFlags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwReserved1"]/*'/>
    [UnscopedRef]
    public ref uint dwReserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwReserved1;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwControlFlags"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwControlFlags;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwReserved1"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwReserved1;
    }
}