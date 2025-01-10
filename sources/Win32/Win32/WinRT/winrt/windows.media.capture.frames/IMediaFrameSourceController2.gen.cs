// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EFC49FD4-FCF2-4A03-B4E4-AC9628739BEE")]
[NativeTypeName("struct IMediaFrameSourceController2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSourceController2
    : IMediaFrameSourceController2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSourceController2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaFrameSourceController2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaFrameSourceController2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaFrameSourceController2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSourceController2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaFrameSourceController2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IMediaFrameSourceController2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropertyByExtendedIdAsync(
        [NativeTypeName("UINT32")] uint extendedPropertyIdLength,
        byte* extendedPropertyId,
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* maxPropertyValueSize,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaFrameSourceController2,
                uint,
                byte*,
                IReference<uint>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, extendedPropertyIdLength, extendedPropertyId, maxPropertyValueSize, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPropertyByExtendedIdAsync(
        [NativeTypeName("UINT32")] uint extendedPropertyIdLength,
        byte* extendedPropertyId,
        [NativeTypeName("UINT32")] uint propertyValueLength,
        byte* propertyValue,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **"
        )]
            IAsyncOperation<MediaFrameSourceSetPropertyStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IMediaFrameSourceController2,
                uint,
                byte*,
                uint,
                byte*,
                IAsyncOperation<MediaFrameSourceSetPropertyStatus>**,
                int>)((*lpVtbl)[7])
        )(
            this,
            extendedPropertyIdLength,
            extendedPropertyId,
            propertyValueLength,
            propertyValue,
            operation
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPropertyByExtendedIdAsync(
            [NativeTypeName("UINT32")] uint extendedPropertyIdLength,
            byte* extendedPropertyId,
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* maxPropertyValueSize,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT SetPropertyByExtendedIdAsync(
            [NativeTypeName("UINT32")] uint extendedPropertyIdLength,
            byte* extendedPropertyId,
            [NativeTypeName("UINT32")] uint propertyValueLength,
            byte* propertyValue,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **"
            )]
                IAsyncOperation<MediaFrameSourceSetPropertyStatus>** operation
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
            "HRESULT (UINT32, BYTE *, ABI::Windows::Foundation::__FIReference_1_UINT32_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceGetPropertyResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            IReference<uint>*,
            IAsyncOperation<IntPtr>**,
            int> GetPropertyByExtendedIdAsync;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, UINT32, BYTE *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceSetPropertyStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            uint,
            byte*,
            IAsyncOperation<MediaFrameSourceSetPropertyStatus>**,
            int> SetPropertyByExtendedIdAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaFrameSourceController2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaFrameSourceController2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaFrameSourceController2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaFrameSourceController2(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaFrameSourceController2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFrameSourceController2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFrameSourceController2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaFrameSourceController2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaFrameSourceController2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaFrameSourceController2(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaFrameSourceController2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFrameSourceController2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFrameSourceController2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaFrameSourceController2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
