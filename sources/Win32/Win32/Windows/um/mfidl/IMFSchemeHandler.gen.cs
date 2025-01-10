// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6D4C7B74-52A0-4BB7-B0DB-55F29F47A668")]
[NativeTypeName("struct IMFSchemeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSchemeHandler : IMFSchemeHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSchemeHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSchemeHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSchemeHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSchemeHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginCreateObject(
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
                IMFSchemeHandler,
                ushort*,
                uint,
                IPropertyStore,
                IUnknown*,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[3])
        )(this, pwszURL, dwFlags, pProps, ppIUnknownCancelCookie, pCallback, punkState);
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
                IMFSchemeHandler,
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
        return ((delegate* unmanaged<IMFSchemeHandler, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            pIUnknownCancelCookie
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginCreateObject(
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSchemeHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSchemeHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSchemeHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSchemeHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSchemeHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSchemeHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSchemeHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSchemeHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
