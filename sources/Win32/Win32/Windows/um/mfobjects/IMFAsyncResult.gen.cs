// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AC6B7889-0740-4D51-8619-905994A55CC6")]
[NativeTypeName("struct IMFAsyncResult : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFAsyncResult : IMFAsyncResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFAsyncResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFAsyncResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFAsyncResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFAsyncResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetState(IUnknown* ppunkState)
    {
        return ((delegate* unmanaged<IMFAsyncResult, IUnknown*, int>)((*lpVtbl)[3]))(
            this,
            ppunkState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatus()
    {
        return ((delegate* unmanaged<IMFAsyncResult, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStatus(HRESULT hrStatus)
    {
        return ((delegate* unmanaged<IMFAsyncResult, HRESULT, int>)((*lpVtbl)[5]))(this, hrStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetObject(IUnknown* ppObject)
    {
        return ((delegate* unmanaged<IMFAsyncResult, IUnknown*, int>)((*lpVtbl)[6]))(
            this,
            ppObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IUnknown GetStateNoAddRef()
    {
        return ((delegate* unmanaged<IMFAsyncResult, IUnknown>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetState(IUnknown* ppunkState);

        [VtblIndex(4)]
        HRESULT GetStatus();

        [VtblIndex(5)]
        HRESULT SetStatus(HRESULT hrStatus);

        [VtblIndex(6)]
        HRESULT GetObject(IUnknown* ppObject);

        [VtblIndex(7)]
        IUnknown GetStateNoAddRef();
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

    /// <summary>Initializes a new instance of the <see cref = "IMFAsyncResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFAsyncResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFAsyncResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFAsyncResult(Silk.NET.Windows.IUnknown value)
    {
        return new IMFAsyncResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFAsyncResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFAsyncResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFAsyncResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
