// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D8D715A3-6E5E-11D0-B3F0-00AA003761C5")]
[NativeTypeName("struct IAMVfwCompressDialogs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMVfwCompressDialogs : IAMVfwCompressDialogs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMVfwCompressDialogs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMVfwCompressDialogs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShowDialog(int iDialog, HWND hwnd)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs, int, HWND, int>)((*lpVtbl)[3]))(
            this,
            iDialog,
            hwnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetState([NativeTypeName("LPVOID")] void* pState, int* pcbState)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs, void*, int*, int>)((*lpVtbl)[4]))(
            this,
            pState,
            pcbState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetState([NativeTypeName("LPVOID")] void* pState, int cbState)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs, void*, int, int>)((*lpVtbl)[5]))(
            this,
            pState,
            cbState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SendDriverMessage(
        int uMsg,
        [NativeTypeName("long")] int dw1,
        [NativeTypeName("long")] int dw2
    )
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs, int, int, int, int>)((*lpVtbl)[6]))(
            this,
            uMsg,
            dw1,
            dw2
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShowDialog(int iDialog, HWND hwnd);

        [VtblIndex(4)]
        HRESULT GetState([NativeTypeName("LPVOID")] void* pState, int* pcbState);

        [VtblIndex(5)]
        HRESULT SetState([NativeTypeName("LPVOID")] void* pState, int cbState);

        [VtblIndex(6)]
        HRESULT SendDriverMessage(
            int uMsg,
            [NativeTypeName("long")] int dw1,
            [NativeTypeName("long")] int dw2
        );
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

        [NativeTypeName("HRESULT (int, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HWND, int> ShowDialog;

        [NativeTypeName("HRESULT (LPVOID, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int*, int> GetState;

        [NativeTypeName("HRESULT (LPVOID, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int, int> SetState;

        [NativeTypeName("HRESULT (int, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int> SendDriverMessage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMVfwCompressDialogs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMVfwCompressDialogs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMVfwCompressDialogs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMVfwCompressDialogs(Silk.NET.Windows.IUnknown value)
    {
        return new IAMVfwCompressDialogs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMVfwCompressDialogs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMVfwCompressDialogs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMVfwCompressDialogs value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
