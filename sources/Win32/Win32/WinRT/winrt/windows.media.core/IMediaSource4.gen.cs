// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BDAFAD57-8EFF-4C63-85A6-84DE0AE3E4F2")]
[NativeTypeName("struct IMediaSource4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaSource4 : IMediaSource4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaSource4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaSource4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaSource4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaSource4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaSource4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaSource4, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaSource4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AdaptiveMediaSource(
        [NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **")]
            IAdaptiveMediaSource* value
    )
    {
        return ((delegate* unmanaged<IMediaSource4, IAdaptiveMediaSource*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaStreamSource(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
            IMediaStreamSource* value
    )
    {
        return ((delegate* unmanaged<IMediaSource4, IMediaStreamSource*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MseStreamSource(
        [NativeTypeName("ABI::Windows::Media::Core::IMseStreamSource **")] IMseStreamSource* value
    )
    {
        return ((delegate* unmanaged<IMediaSource4, IMseStreamSource*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Uri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return ((delegate* unmanaged<IMediaSource4, IUriRuntimeClass*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IMediaSource4, IAsyncAction*, int>)((*lpVtbl)[10]))(
            this,
            operation
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AdaptiveMediaSource(
            [NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **")]
                IAdaptiveMediaSource* value
        );

        [VtblIndex(7)]
        HRESULT get_MediaStreamSource(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")]
                IMediaStreamSource* value
        );

        [VtblIndex(8)]
        HRESULT get_MseStreamSource(
            [NativeTypeName("ABI::Windows::Media::Core::IMseStreamSource **")]
                IMseStreamSource* value
        );

        [VtblIndex(9)]
        HRESULT get_Uri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(10)]
        HRESULT OpenAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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
            "HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAdaptiveMediaSource*, int> get_AdaptiveMediaSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaStreamSource*, int> get_MediaStreamSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMseStreamSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMseStreamSource*, int> get_MseStreamSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_Uri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> OpenAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaSource4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaSource4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaSource4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaSource4(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaSource4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaSource4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaSource4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaSource4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaSource4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaSource4(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaSource4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaSource4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaSource4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaSource4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
