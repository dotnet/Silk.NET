// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("15552CB7-7B80-4AC4-8660-A4B97F7C70F0")]
[NativeTypeName("struct IAdaptiveMediaSourceDownloadResult2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceDownloadResult2
    : IAdaptiveMediaSourceDownloadResult2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceDownloadResult2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResourceByteRangeOffset(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, IReference<ulong>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ResourceByteRangeOffset(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
            IReference<ulong>* value
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, IReference<ulong>*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResourceByteRangeLength(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, IReference<ulong>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ResourceByteRangeLength(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
            IReference<ulong>* value
    )
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadResult2, IReference<ulong>*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResourceByteRangeOffset(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(7)]
        HRESULT put_ResourceByteRangeOffset(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
                IReference<ulong>* value
        );

        [VtblIndex(8)]
        HRESULT get_ResourceByteRangeLength(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(9)]
        HRESULT put_ResourceByteRangeLength(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")]
                IReference<ulong>* value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>**, int> get_ResourceByteRangeOffset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>*, int> put_ResourceByteRangeOffset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>**, int> get_ResourceByteRangeLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>*, int> put_ResourceByteRangeLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdaptiveMediaSourceDownloadResult2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdaptiveMediaSourceDownloadResult2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdaptiveMediaSourceDownloadResult2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSourceDownloadResult2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAdaptiveMediaSourceDownloadResult2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSourceDownloadResult2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSourceDownloadResult2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAdaptiveMediaSourceDownloadResult2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdaptiveMediaSourceDownloadResult2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSourceDownloadResult2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAdaptiveMediaSourceDownloadResult2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSourceDownloadResult2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSourceDownloadResult2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAdaptiveMediaSourceDownloadResult2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
