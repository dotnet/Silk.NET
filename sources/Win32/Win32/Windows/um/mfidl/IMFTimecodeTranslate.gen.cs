// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AB9D8661-F7E8-4EF4-9861-89F334F94E74")]
[NativeTypeName("struct IMFTimecodeTranslate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimecodeTranslate : IMFTimecodeTranslate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimecodeTranslate));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimecodeTranslate, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTimecodeTranslate, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimecodeTranslate, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginConvertTimecodeToHNS(
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pPropVarTimecode,
        IMFAsyncCallback pCallback,
        IUnknown punkState
    )
    {
        return (
            (delegate* unmanaged<
                IMFTimecodeTranslate,
                PROPVARIANT*,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[3])
        )(this, pPropVarTimecode, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndConvertTimecodeToHNS(
        IMFAsyncResult pResult,
        [NativeTypeName("MFTIME *")] long* phnsTime
    )
    {
        return (
            (delegate* unmanaged<IMFTimecodeTranslate, IMFAsyncResult, long*, int>)((*lpVtbl)[4])
        )(this, pResult, phnsTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginConvertHNSToTimecode(
        [NativeTypeName("MFTIME")] long hnsTime,
        IMFAsyncCallback pCallback,
        IUnknown punkState
    )
    {
        return (
            (delegate* unmanaged<IMFTimecodeTranslate, long, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[5]
            )
        )(this, hnsTime, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndConvertHNSToTimecode(IMFAsyncResult pResult, PROPVARIANT* pPropVarTimecode)
    {
        return (
            (delegate* unmanaged<IMFTimecodeTranslate, IMFAsyncResult, PROPVARIANT*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pResult, pPropVarTimecode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginConvertTimecodeToHNS(
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pPropVarTimecode,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(4)]
        HRESULT EndConvertTimecodeToHNS(
            IMFAsyncResult pResult,
            [NativeTypeName("MFTIME *")] long* phnsTime
        );

        [VtblIndex(5)]
        HRESULT BeginConvertHNSToTimecode(
            [NativeTypeName("MFTIME")] long hnsTime,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(6)]
        HRESULT EndConvertHNSToTimecode(IMFAsyncResult pResult, PROPVARIANT* pPropVarTimecode);
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

        [NativeTypeName(
            "HRESULT (const PROPVARIANT *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPVARIANT*,
            IMFAsyncCallback,
            IUnknown,
            int> BeginConvertTimecodeToHNS;

        [NativeTypeName("HRESULT (IMFAsyncResult *, MFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, long*, int> EndConvertTimecodeToHNS;

        [NativeTypeName(
            "HRESULT (MFTIME, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            long,
            IMFAsyncCallback,
            IUnknown,
            int> BeginConvertHNSToTimecode;

        [NativeTypeName("HRESULT (IMFAsyncResult *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            PROPVARIANT*,
            int> EndConvertHNSToTimecode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimecodeTranslate"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimecodeTranslate(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimecodeTranslate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimecodeTranslate(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimecodeTranslate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimecodeTranslate"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimecodeTranslate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimecodeTranslate value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
