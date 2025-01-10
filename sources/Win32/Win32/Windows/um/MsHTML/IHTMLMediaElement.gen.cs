// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510706-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLMediaElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLMediaElement : IHTMLMediaElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLMediaElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLMediaElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLMediaElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLMediaElement, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IHTMLMediaElement, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLMediaElement,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_error(IHTMLMediaError* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, IHTMLMediaError*, int>)((*lpVtbl)[7]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, ushort*, int>)((*lpVtbl)[8]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, ushort**, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_currentSrc([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, ushort**, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_networkState(ushort* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, ushort*, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_preload([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, ushort*, int>)((*lpVtbl)[12]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_preload([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, ushort**, int>)((*lpVtbl)[13]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_buffered(IHTMLTimeRanges* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, IHTMLTimeRanges*, int>)((*lpVtbl)[14]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT load()
    {
        return ((delegate* unmanaged<IHTMLMediaElement, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT canPlayType(
        [NativeTypeName("BSTR")] ushort* type,
        [NativeTypeName("BSTR *")] ushort** canPlay
    )
    {
        return ((delegate* unmanaged<IHTMLMediaElement, ushort*, ushort**, int>)((*lpVtbl)[16]))(
            this,
            type,
            canPlay
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_seeking([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short*, int>)((*lpVtbl)[17]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_currentTime(float v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float, int>)((*lpVtbl)[18]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_currentTime(float* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float*, int>)((*lpVtbl)[19]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_initialTime(float* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float*, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_duration(float* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float*, int>)((*lpVtbl)[21]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_paused([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short*, int>)((*lpVtbl)[22]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_defaultPlaybackRate(float v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float, int>)((*lpVtbl)[23]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_defaultPlaybackRate(float* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float*, int>)((*lpVtbl)[24]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_playbackRate(float v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float, int>)((*lpVtbl)[25]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_playbackRate(float* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float*, int>)((*lpVtbl)[26]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_played(IHTMLTimeRanges* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, IHTMLTimeRanges*, int>)((*lpVtbl)[27]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_seekable(IHTMLTimeRanges* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, IHTMLTimeRanges*, int>)((*lpVtbl)[28]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_ended([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short*, int>)((*lpVtbl)[29]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_autoplay([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short, int>)((*lpVtbl)[30]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_autoplay([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short*, int>)((*lpVtbl)[31]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_loop([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short, int>)((*lpVtbl)[32]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_loop([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short*, int>)((*lpVtbl)[33]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT play()
    {
        return ((delegate* unmanaged<IHTMLMediaElement, int>)((*lpVtbl)[34]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT pause()
    {
        return ((delegate* unmanaged<IHTMLMediaElement, int>)((*lpVtbl)[35]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_controls([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short, int>)((*lpVtbl)[36]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_controls([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short*, int>)((*lpVtbl)[37]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_volume(float v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float, int>)((*lpVtbl)[38]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_volume(float* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, float*, int>)((*lpVtbl)[39]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_muted([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short, int>)((*lpVtbl)[40]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_muted([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short*, int>)((*lpVtbl)[41]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_autobuffer([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short, int>)((*lpVtbl)[42]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_autobuffer([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement, short*, int>)((*lpVtbl)[43]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_error(IHTMLMediaError* p);

        [VtblIndex(8)]
        HRESULT put_src([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(9)]
        HRESULT get_src([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT get_currentSrc([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT get_networkState(ushort* p);

        [VtblIndex(12)]
        HRESULT put_preload([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(13)]
        HRESULT get_preload([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(14)]
        HRESULT get_buffered(IHTMLTimeRanges* p);

        [VtblIndex(15)]
        HRESULT load();

        [VtblIndex(16)]
        HRESULT canPlayType(
            [NativeTypeName("BSTR")] ushort* type,
            [NativeTypeName("BSTR *")] ushort** canPlay
        );

        [VtblIndex(17)]
        HRESULT get_seeking([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(18)]
        HRESULT put_currentTime(float v);

        [VtblIndex(19)]
        HRESULT get_currentTime(float* p);

        [VtblIndex(20)]
        HRESULT get_initialTime(float* p);

        [VtblIndex(21)]
        HRESULT get_duration(float* p);

        [VtblIndex(22)]
        HRESULT get_paused([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(23)]
        HRESULT put_defaultPlaybackRate(float v);

        [VtblIndex(24)]
        HRESULT get_defaultPlaybackRate(float* p);

        [VtblIndex(25)]
        HRESULT put_playbackRate(float v);

        [VtblIndex(26)]
        HRESULT get_playbackRate(float* p);

        [VtblIndex(27)]
        HRESULT get_played(IHTMLTimeRanges* p);

        [VtblIndex(28)]
        HRESULT get_seekable(IHTMLTimeRanges* p);

        [VtblIndex(29)]
        HRESULT get_ended([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(30)]
        HRESULT put_autoplay([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(31)]
        HRESULT get_autoplay([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(32)]
        HRESULT put_loop([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(33)]
        HRESULT get_loop([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(34)]
        HRESULT play();

        [VtblIndex(35)]
        HRESULT pause();

        [VtblIndex(36)]
        HRESULT put_controls([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(37)]
        HRESULT get_controls([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(38)]
        HRESULT put_volume(float v);

        [VtblIndex(39)]
        HRESULT get_volume(float* p);

        [VtblIndex(40)]
        HRESULT put_muted([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(41)]
        HRESULT get_muted([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(42)]
        HRESULT put_autobuffer([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(43)]
        HRESULT get_autobuffer([NativeTypeName("VARIANT_BOOL *")] short* p);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (IHTMLMediaError **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLMediaError*, int> get_error;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_src;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_src;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_currentSrc;

        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_networkState;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_preload;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_preload;

        [NativeTypeName("HRESULT (IHTMLTimeRanges **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTimeRanges*, int> get_buffered;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> load;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> canPlayType;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_seeking;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_currentTime;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_currentTime;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_initialTime;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_duration;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_paused;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_defaultPlaybackRate;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_defaultPlaybackRate;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_playbackRate;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_playbackRate;

        [NativeTypeName("HRESULT (IHTMLTimeRanges **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTimeRanges*, int> get_played;

        [NativeTypeName("HRESULT (IHTMLTimeRanges **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTimeRanges*, int> get_seekable;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_ended;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_autoplay;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_autoplay;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_loop;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_loop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> play;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> pause;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_controls;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_controls;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_volume;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_volume;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_muted;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_muted;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_autobuffer;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_autobuffer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLMediaElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLMediaElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLMediaElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLMediaElement(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLMediaElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLMediaElement"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLMediaElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLMediaElement value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLMediaElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLMediaElement(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLMediaElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLMediaElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLMediaElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLMediaElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
