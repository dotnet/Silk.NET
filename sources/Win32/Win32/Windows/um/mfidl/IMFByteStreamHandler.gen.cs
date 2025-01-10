// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BB420AA4-765B-4A1F-91FE-D6A8A143924C")]
[NativeTypeName("struct IMFByteStreamHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFByteStreamHandler : IMFByteStreamHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFByteStreamHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFByteStreamHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFByteStreamHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFByteStreamHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginCreateObject(
        IMFByteStream pByteStream,
        [NativeTypeName("LPCWSTR")] ushort* pwszURL,
        [NativeTypeName("DWORD")] uint dwFlags,
        IPropertyStore pProps,
        IUnknown* ppIUnknownCancelCookie,
        IMFAsyncCallback pCallback,
        IUnknown punkState
    )
    {
        return (
            (delegate* unmanaged<
                IMFByteStreamHandler,
                IMFByteStream,
                ushort*,
                uint,
                IPropertyStore,
                IUnknown*,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[3])
        )(
            this,
            pByteStream,
            pwszURL,
            dwFlags,
            pProps,
            ppIUnknownCancelCookie,
            pCallback,
            punkState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndCreateObject(
        IMFAsyncResult pResult,
        MF_OBJECT_TYPE* pObjectType,
        IUnknown* ppObject
    )
    {
        return (
            (delegate* unmanaged<
                IMFByteStreamHandler,
                IMFAsyncResult,
                MF_OBJECT_TYPE*,
                IUnknown*,
                int>)((*lpVtbl)[4])
        )(this, pResult, pObjectType, ppObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelObjectCreation(IUnknown pIUnknownCancelCookie)
    {
        return ((delegate* unmanaged<IMFByteStreamHandler, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            pIUnknownCancelCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMaxNumberOfBytesRequiredForResolution(
        [NativeTypeName("QWORD *")] ulong* pqwBytes
    )
    {
        return ((delegate* unmanaged<IMFByteStreamHandler, ulong*, int>)((*lpVtbl)[6]))(
            this,
            pqwBytes
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginCreateObject(
            IMFByteStream pByteStream,
            [NativeTypeName("LPCWSTR")] ushort* pwszURL,
            [NativeTypeName("DWORD")] uint dwFlags,
            IPropertyStore pProps,
            IUnknown* ppIUnknownCancelCookie,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(4)]
        HRESULT EndCreateObject(
            IMFAsyncResult pResult,
            MF_OBJECT_TYPE* pObjectType,
            IUnknown* ppObject
        );

        [VtblIndex(5)]
        HRESULT CancelObjectCreation(IUnknown pIUnknownCancelCookie);

        [VtblIndex(6)]
        HRESULT GetMaxNumberOfBytesRequiredForResolution(
            [NativeTypeName("QWORD *")] ulong* pqwBytes
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

        [NativeTypeName(
            "HRESULT (IMFByteStream *, LPCWSTR, DWORD, IPropertyStore *, IUnknown **, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFByteStream,
            ushort*,
            uint,
            IPropertyStore,
            IUnknown*,
            IMFAsyncCallback,
            IUnknown,
            int> BeginCreateObject;

        [NativeTypeName(
            "HRESULT (IMFAsyncResult *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            MF_OBJECT_TYPE*,
            IUnknown*,
            int> EndCreateObject;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> CancelObjectCreation;

        [NativeTypeName("HRESULT (QWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetMaxNumberOfBytesRequiredForResolution;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFByteStreamHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFByteStreamHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFByteStreamHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFByteStreamHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IMFByteStreamHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFByteStreamHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFByteStreamHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFByteStreamHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
