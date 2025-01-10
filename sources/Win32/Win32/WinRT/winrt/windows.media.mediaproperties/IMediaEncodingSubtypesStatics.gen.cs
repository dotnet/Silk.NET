// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("37B6580E-A171-4464-BA5A-53189E48C1C8")]
[NativeTypeName("struct IMediaEncodingSubtypesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingSubtypesStatics
    : IMediaEncodingSubtypesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingSubtypesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaEncodingSubtypesStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IMediaEncodingSubtypesStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IMediaEncodingSubtypesStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Aac(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AacAdts(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Ac3(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AmrNb(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AmrWb(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Argb32(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Asf(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Avi(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Bgra8(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Bmp(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Eac3(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Float(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Gif(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_H263(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_H264(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_H264Es(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Hevc(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_HevcEs(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Iyuv(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Jpeg(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_JpegXr(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Mjpg(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Mpeg(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_Mpeg1(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_Mpeg2(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Mp3(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_Mpeg4(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_Nv12(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[33]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_Pcm(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[34]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_Png(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[35]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_Rgb24(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[36]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_Rgb32(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[37]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_Tiff(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[38]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_Wave(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[39]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_Wma8(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[40]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_Wma9(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[41]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_Wmv3(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[42]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_Wvc1(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[43]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_Yuy2(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[44]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_Yv12(HSTRING* value)
    {
        return ((delegate* unmanaged<IMediaEncodingSubtypesStatics, HSTRING*, int>)((*lpVtbl)[45]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Aac(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AacAdts(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Ac3(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_AmrNb(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_AmrWb(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Argb32(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Asf(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Avi(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_Bgra8(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_Bmp(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_Eac3(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_Float(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_Gif(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_H263(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_H264(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_H264Es(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_Hevc(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_HevcEs(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_Iyuv(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_Jpeg(HSTRING* value);

        [VtblIndex(26)]
        HRESULT get_JpegXr(HSTRING* value);

        [VtblIndex(27)]
        HRESULT get_Mjpg(HSTRING* value);

        [VtblIndex(28)]
        HRESULT get_Mpeg(HSTRING* value);

        [VtblIndex(29)]
        HRESULT get_Mpeg1(HSTRING* value);

        [VtblIndex(30)]
        HRESULT get_Mpeg2(HSTRING* value);

        [VtblIndex(31)]
        HRESULT get_Mp3(HSTRING* value);

        [VtblIndex(32)]
        HRESULT get_Mpeg4(HSTRING* value);

        [VtblIndex(33)]
        HRESULT get_Nv12(HSTRING* value);

        [VtblIndex(34)]
        HRESULT get_Pcm(HSTRING* value);

        [VtblIndex(35)]
        HRESULT get_Png(HSTRING* value);

        [VtblIndex(36)]
        HRESULT get_Rgb24(HSTRING* value);

        [VtblIndex(37)]
        HRESULT get_Rgb32(HSTRING* value);

        [VtblIndex(38)]
        HRESULT get_Tiff(HSTRING* value);

        [VtblIndex(39)]
        HRESULT get_Wave(HSTRING* value);

        [VtblIndex(40)]
        HRESULT get_Wma8(HSTRING* value);

        [VtblIndex(41)]
        HRESULT get_Wma9(HSTRING* value);

        [VtblIndex(42)]
        HRESULT get_Wmv3(HSTRING* value);

        [VtblIndex(43)]
        HRESULT get_Wvc1(HSTRING* value);

        [VtblIndex(44)]
        HRESULT get_Yuy2(HSTRING* value);

        [VtblIndex(45)]
        HRESULT get_Yv12(HSTRING* value);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Aac;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AacAdts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Ac3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AmrNb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AmrWb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Argb32;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Asf;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Avi;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Bgra8;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Bmp;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Eac3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Float;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Gif;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_H263;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_H264;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_H264Es;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Hevc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_HevcEs;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Iyuv;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Jpeg;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_JpegXr;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mjpg;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mpeg;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mpeg1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mpeg2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mp3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Mpeg4;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Nv12;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Pcm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Png;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Rgb24;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Rgb32;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Tiff;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Wave;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Wma8;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Wma9;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Wmv3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Wvc1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Yuy2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Yv12;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaEncodingSubtypesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaEncodingSubtypesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaEncodingSubtypesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaEncodingSubtypesStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaEncodingSubtypesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEncodingSubtypesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEncodingSubtypesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaEncodingSubtypesStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaEncodingSubtypesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaEncodingSubtypesStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaEncodingSubtypesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaEncodingSubtypesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaEncodingSubtypesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaEncodingSubtypesStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
