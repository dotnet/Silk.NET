// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000000-0000-0000-0000-000000000000")]
[NativeTypeName("struct tagMFASYNCRESULT : IMFAsyncResult")]
[NativeInheritance("IMFAsyncResult")]
public unsafe partial struct MFASYNCRESULT : MFASYNCRESULT.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_tagMFASYNCRESULT));
    public void*** lpVtbl;
    public OVERLAPPED overlapped;
    public IMFAsyncCallback pCallback;
    public HRESULT hrStatusResult;

    [NativeTypeName("DWORD")]
    public uint dwBytesTransferred;
    public HANDLE hEvent;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<MFASYNCRESULT, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<MFASYNCRESULT, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<MFASYNCRESULT, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetState(IUnknown* ppunkState)
    {
        return ((delegate* unmanaged<MFASYNCRESULT, IUnknown*, int>)((*lpVtbl)[3]))(
            this,
            ppunkState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatus()
    {
        return ((delegate* unmanaged<MFASYNCRESULT, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStatus(HRESULT hrStatus)
    {
        return ((delegate* unmanaged<MFASYNCRESULT, HRESULT, int>)((*lpVtbl)[5]))(this, hrStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetObject(IUnknown* ppObject)
    {
        return ((delegate* unmanaged<MFASYNCRESULT, IUnknown*, int>)((*lpVtbl)[6]))(this, ppObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IUnknown GetStateNoAddRef()
    {
        return ((delegate* unmanaged<MFASYNCRESULT, IUnknown>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IMFAsyncResult.Interface { }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetStatus;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> SetStatus;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetObject;

        [NativeTypeName("IUnknown *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown> GetStateNoAddRef;
    }

    /// <summary>Initializes a new instance of the <see cref = "MFASYNCRESULT"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public MFASYNCRESULT(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFAsyncResult"/> to <see cref = "MFASYNCRESULT"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFAsyncResult"/> instance to be converted </param>
    public static explicit operator MFASYNCRESULT(Silk.NET.Windows.IMFAsyncResult value)
    {
        return new MFASYNCRESULT(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "MFASYNCRESULT"/> to <see cref = "Silk.NET.Windows.IMFAsyncResult"/>.</summary>
    /// <param name = "value">The <see cref = "MFASYNCRESULT"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFAsyncResult(MFASYNCRESULT value)
    {
        return new Silk.NET.Windows.IMFAsyncResult(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "MFASYNCRESULT"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator MFASYNCRESULT(Silk.NET.Windows.IUnknown value)
    {
        return new MFASYNCRESULT(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "MFASYNCRESULT"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "MFASYNCRESULT"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(MFASYNCRESULT value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
