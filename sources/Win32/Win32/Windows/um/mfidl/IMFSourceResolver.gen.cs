// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FBE5A32D-A497-4B61-BB85-97B1A848A6E3")]
[NativeTypeName("struct IMFSourceResolver : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSourceResolver : IMFSourceResolver.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceResolver));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceResolver, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSourceResolver, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceResolver, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateObjectFromURL(
        [NativeTypeName("LPCWSTR")] ushort* pwszURL,
        [NativeTypeName("DWORD")] uint dwFlags,
        IPropertyStore pProps,
        MF_OBJECT_TYPE* pObjectType,
        IUnknown* ppObject
    )
    {
        return (
            (delegate* unmanaged<
                IMFSourceResolver,
                ushort*,
                uint,
                IPropertyStore,
                MF_OBJECT_TYPE*,
                IUnknown*,
                int>)((*lpVtbl)[3])
        )(this, pwszURL, dwFlags, pProps, pObjectType, ppObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateObjectFromByteStream(
        IMFByteStream pByteStream,
        [NativeTypeName("LPCWSTR")] ushort* pwszURL,
        [NativeTypeName("DWORD")] uint dwFlags,
        IPropertyStore pProps,
        MF_OBJECT_TYPE* pObjectType,
        IUnknown* ppObject
    )
    {
        return (
            (delegate* unmanaged<
                IMFSourceResolver,
                IMFByteStream,
                ushort*,
                uint,
                IPropertyStore,
                MF_OBJECT_TYPE*,
                IUnknown*,
                int>)((*lpVtbl)[4])
        )(this, pByteStream, pwszURL, dwFlags, pProps, pObjectType, ppObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginCreateObjectFromURL(
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
                IMFSourceResolver,
                ushort*,
                uint,
                IPropertyStore,
                IUnknown*,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[5])
        )(this, pwszURL, dwFlags, pProps, ppIUnknownCancelCookie, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndCreateObjectFromURL(
        IMFAsyncResult pResult,
        MF_OBJECT_TYPE* pObjectType,
        IUnknown* ppObject
    )
    {
        return (
            (delegate* unmanaged<
                IMFSourceResolver,
                IMFAsyncResult,
                MF_OBJECT_TYPE*,
                IUnknown*,
                int>)((*lpVtbl)[6])
        )(this, pResult, pObjectType, ppObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BeginCreateObjectFromByteStream(
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
                IMFSourceResolver,
                IMFByteStream,
                ushort*,
                uint,
                IPropertyStore,
                IUnknown*,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[7])
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
    [VtblIndex(8)]
    public HRESULT EndCreateObjectFromByteStream(
        IMFAsyncResult pResult,
        MF_OBJECT_TYPE* pObjectType,
        IUnknown* ppObject
    )
    {
        return (
            (delegate* unmanaged<
                IMFSourceResolver,
                IMFAsyncResult,
                MF_OBJECT_TYPE*,
                IUnknown*,
                int>)((*lpVtbl)[8])
        )(this, pResult, pObjectType, ppObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CancelObjectCreation(IUnknown pIUnknownCancelCookie)
    {
        return ((delegate* unmanaged<IMFSourceResolver, IUnknown, int>)((*lpVtbl)[9]))(
            this,
            pIUnknownCancelCookie
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateObjectFromURL(
            [NativeTypeName("LPCWSTR")] ushort* pwszURL,
            [NativeTypeName("DWORD")] uint dwFlags,
            IPropertyStore pProps,
            MF_OBJECT_TYPE* pObjectType,
            IUnknown* ppObject
        );

        [VtblIndex(4)]
        HRESULT CreateObjectFromByteStream(
            IMFByteStream pByteStream,
            [NativeTypeName("LPCWSTR")] ushort* pwszURL,
            [NativeTypeName("DWORD")] uint dwFlags,
            IPropertyStore pProps,
            MF_OBJECT_TYPE* pObjectType,
            IUnknown* ppObject
        );

        [VtblIndex(5)]
        HRESULT BeginCreateObjectFromURL(
            [NativeTypeName("LPCWSTR")] ushort* pwszURL,
            [NativeTypeName("DWORD")] uint dwFlags,
            IPropertyStore pProps,
            IUnknown* ppIUnknownCancelCookie,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(6)]
        HRESULT EndCreateObjectFromURL(
            IMFAsyncResult pResult,
            MF_OBJECT_TYPE* pObjectType,
            IUnknown* ppObject
        );

        [VtblIndex(7)]
        HRESULT BeginCreateObjectFromByteStream(
            IMFByteStream pByteStream,
            [NativeTypeName("LPCWSTR")] ushort* pwszURL,
            [NativeTypeName("DWORD")] uint dwFlags,
            IPropertyStore pProps,
            IUnknown* ppIUnknownCancelCookie,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(8)]
        HRESULT EndCreateObjectFromByteStream(
            IMFAsyncResult pResult,
            MF_OBJECT_TYPE* pObjectType,
            IUnknown* ppObject
        );

        [VtblIndex(9)]
        HRESULT CancelObjectCreation(IUnknown pIUnknownCancelCookie);
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
            "HRESULT (LPCWSTR, DWORD, IPropertyStore *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IPropertyStore,
            MF_OBJECT_TYPE*,
            IUnknown*,
            int> CreateObjectFromURL;

        [NativeTypeName(
            "HRESULT (IMFByteStream *, LPCWSTR, DWORD, IPropertyStore *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFByteStream,
            ushort*,
            uint,
            IPropertyStore,
            MF_OBJECT_TYPE*,
            IUnknown*,
            int> CreateObjectFromByteStream;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD, IPropertyStore *, IUnknown **, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IPropertyStore,
            IUnknown*,
            IMFAsyncCallback,
            IUnknown,
            int> BeginCreateObjectFromURL;

        [NativeTypeName(
            "HRESULT (IMFAsyncResult *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            MF_OBJECT_TYPE*,
            IUnknown*,
            int> EndCreateObjectFromURL;

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
            int> BeginCreateObjectFromByteStream;

        [NativeTypeName(
            "HRESULT (IMFAsyncResult *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            MF_OBJECT_TYPE*,
            IUnknown*,
            int> EndCreateObjectFromByteStream;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> CancelObjectCreation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSourceResolver"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSourceResolver(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSourceResolver"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSourceResolver(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSourceResolver(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSourceResolver"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSourceResolver"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSourceResolver value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
