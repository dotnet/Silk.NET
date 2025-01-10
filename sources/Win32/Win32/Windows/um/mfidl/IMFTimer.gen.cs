// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E56E4CBD-8F70-49D8-A0F8-EDB3D6AB9BF2")]
[NativeTypeName("struct IMFTimer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimer : IMFTimer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTimer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTimer(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LONGLONG")] long llClockTime,
        IMFAsyncCallback pCallback,
        IUnknown punkState,
        IUnknown* ppunkKey
    )
    {
        return (
            (delegate* unmanaged<IMFTimer, uint, long, IMFAsyncCallback, IUnknown, IUnknown*, int>)(
                (*lpVtbl)[3]
            )
        )(this, dwFlags, llClockTime, pCallback, punkState, ppunkKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CancelTimer(IUnknown punkKey)
    {
        return ((delegate* unmanaged<IMFTimer, IUnknown, int>)((*lpVtbl)[4]))(this, punkKey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetTimer(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LONGLONG")] long llClockTime,
            IMFAsyncCallback pCallback,
            IUnknown punkState,
            IUnknown* ppunkKey
        );

        [VtblIndex(4)]
        HRESULT CancelTimer(IUnknown punkKey);
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
            "HRESULT (DWORD, LONGLONG, IMFAsyncCallback *, IUnknown *, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            long,
            IMFAsyncCallback,
            IUnknown,
            IUnknown*,
            int> SetTimer;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> CancelTimer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimer(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
