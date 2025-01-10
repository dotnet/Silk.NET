// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2F69D622-20B5-41E9-AFDF-89CED1DDA04E")]
[NativeTypeName("struct IMFMediaEngineExtension : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaEngineExtension
    : IMFMediaEngineExtension.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineExtension));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaEngineExtension, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CanPlayType(
        BOOL AudioOnly,
        [NativeTypeName("BSTR")] ushort* MimeType,
        MF_MEDIA_ENGINE_CANPLAY* pAnswer
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaEngineExtension,
                BOOL,
                ushort*,
                MF_MEDIA_ENGINE_CANPLAY*,
                int>)((*lpVtbl)[3])
        )(this, AudioOnly, MimeType, pAnswer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginCreateObject(
        [NativeTypeName("BSTR")] ushort* bstrURL,
        IMFByteStream pByteStream,
        MF_OBJECT_TYPE type,
        IUnknown* ppIUnknownCancelCookie,
        IMFAsyncCallback pCallback,
        IUnknown punkState
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaEngineExtension,
                ushort*,
                IMFByteStream,
                MF_OBJECT_TYPE,
                IUnknown*,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[4])
        )(this, bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelObjectCreation(IUnknown pIUnknownCancelCookie)
    {
        return ((delegate* unmanaged<IMFMediaEngineExtension, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            pIUnknownCancelCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndCreateObject(IMFAsyncResult pResult, IUnknown* ppObject)
    {
        return (
            (delegate* unmanaged<IMFMediaEngineExtension, IMFAsyncResult, IUnknown*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pResult, ppObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CanPlayType(
            BOOL AudioOnly,
            [NativeTypeName("BSTR")] ushort* MimeType,
            MF_MEDIA_ENGINE_CANPLAY* pAnswer
        );

        [VtblIndex(4)]
        HRESULT BeginCreateObject(
            [NativeTypeName("BSTR")] ushort* bstrURL,
            IMFByteStream pByteStream,
            MF_OBJECT_TYPE type,
            IUnknown* ppIUnknownCancelCookie,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(5)]
        HRESULT CancelObjectCreation(IUnknown pIUnknownCancelCookie);

        [VtblIndex(6)]
        HRESULT EndCreateObject(IMFAsyncResult pResult, IUnknown* ppObject);
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

        [NativeTypeName("HRESULT (BOOL, BSTR, MF_MEDIA_ENGINE_CANPLAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            BOOL,
            ushort*,
            MF_MEDIA_ENGINE_CANPLAY*,
            int> CanPlayType;

        [NativeTypeName(
            "HRESULT (BSTR, IMFByteStream *, MF_OBJECT_TYPE, IUnknown **, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IMFByteStream,
            MF_OBJECT_TYPE,
            IUnknown*,
            IMFAsyncCallback,
            IUnknown,
            int> BeginCreateObject;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> CancelObjectCreation;

        [NativeTypeName("HRESULT (IMFAsyncResult *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, IUnknown*, int> EndCreateObject;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaEngineExtension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaEngineExtension(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaEngineExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaEngineExtension(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaEngineExtension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaEngineExtension"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaEngineExtension"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaEngineExtension value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
