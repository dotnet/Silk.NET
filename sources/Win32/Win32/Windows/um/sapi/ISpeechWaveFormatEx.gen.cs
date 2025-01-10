// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7A1EF0D5-1581-4741-88E4-209A49F11A10")]
[NativeTypeName("struct ISpeechWaveFormatEx : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechWaveFormatEx : ISpeechWaveFormatEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechWaveFormatEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechWaveFormatEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechWaveFormatEx, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISpeechWaveFormatEx, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISpeechWaveFormatEx,
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
    public HRESULT get_FormatTag(short* FormatTag)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, short*, int>)((*lpVtbl)[7]))(
            this,
            FormatTag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_FormatTag(short FormatTag)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, short, int>)((*lpVtbl)[8]))(
            this,
            FormatTag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Channels(short* Channels)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, short*, int>)((*lpVtbl)[9]))(
            this,
            Channels
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Channels(short Channels)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, short, int>)((*lpVtbl)[10]))(
            this,
            Channels
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SamplesPerSec([NativeTypeName("long *")] int* SamplesPerSec)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, int*, int>)((*lpVtbl)[11]))(
            this,
            SamplesPerSec
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SamplesPerSec([NativeTypeName("long")] int SamplesPerSec)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, int, int>)((*lpVtbl)[12]))(
            this,
            SamplesPerSec
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AvgBytesPerSec([NativeTypeName("long *")] int* AvgBytesPerSec)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, int*, int>)((*lpVtbl)[13]))(
            this,
            AvgBytesPerSec
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_AvgBytesPerSec([NativeTypeName("long")] int AvgBytesPerSec)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, int, int>)((*lpVtbl)[14]))(
            this,
            AvgBytesPerSec
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_BlockAlign(short* BlockAlign)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, short*, int>)((*lpVtbl)[15]))(
            this,
            BlockAlign
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_BlockAlign(short BlockAlign)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, short, int>)((*lpVtbl)[16]))(
            this,
            BlockAlign
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_BitsPerSample(short* BitsPerSample)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, short*, int>)((*lpVtbl)[17]))(
            this,
            BitsPerSample
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_BitsPerSample(short BitsPerSample)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, short, int>)((*lpVtbl)[18]))(
            this,
            BitsPerSample
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ExtraData(VARIANT* ExtraData)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, VARIANT*, int>)((*lpVtbl)[19]))(
            this,
            ExtraData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ExtraData(VARIANT ExtraData)
    {
        return ((delegate* unmanaged<ISpeechWaveFormatEx, VARIANT, int>)((*lpVtbl)[20]))(
            this,
            ExtraData
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_FormatTag(short* FormatTag);

        [VtblIndex(8)]
        HRESULT put_FormatTag(short FormatTag);

        [VtblIndex(9)]
        HRESULT get_Channels(short* Channels);

        [VtblIndex(10)]
        HRESULT put_Channels(short Channels);

        [VtblIndex(11)]
        HRESULT get_SamplesPerSec([NativeTypeName("long *")] int* SamplesPerSec);

        [VtblIndex(12)]
        HRESULT put_SamplesPerSec([NativeTypeName("long")] int SamplesPerSec);

        [VtblIndex(13)]
        HRESULT get_AvgBytesPerSec([NativeTypeName("long *")] int* AvgBytesPerSec);

        [VtblIndex(14)]
        HRESULT put_AvgBytesPerSec([NativeTypeName("long")] int AvgBytesPerSec);

        [VtblIndex(15)]
        HRESULT get_BlockAlign(short* BlockAlign);

        [VtblIndex(16)]
        HRESULT put_BlockAlign(short BlockAlign);

        [VtblIndex(17)]
        HRESULT get_BitsPerSample(short* BitsPerSample);

        [VtblIndex(18)]
        HRESULT put_BitsPerSample(short BitsPerSample);

        [VtblIndex(19)]
        HRESULT get_ExtraData(VARIANT* ExtraData);

        [VtblIndex(20)]
        HRESULT put_ExtraData(VARIANT ExtraData);
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

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_FormatTag;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_FormatTag;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Channels;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_Channels;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SamplesPerSec;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SamplesPerSec;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AvgBytesPerSec;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_AvgBytesPerSec;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_BlockAlign;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_BlockAlign;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_BitsPerSample;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_BitsPerSample;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ExtraData;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ExtraData;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechWaveFormatEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechWaveFormatEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechWaveFormatEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechWaveFormatEx(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechWaveFormatEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechWaveFormatEx"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechWaveFormatEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechWaveFormatEx value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechWaveFormatEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechWaveFormatEx(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechWaveFormatEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechWaveFormatEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechWaveFormatEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechWaveFormatEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
