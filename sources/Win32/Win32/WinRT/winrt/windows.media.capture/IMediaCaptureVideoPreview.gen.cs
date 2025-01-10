// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("27727073-549E-447F-A20A-4F03C479D8C0")]
[NativeTypeName("struct IMediaCaptureVideoPreview : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureVideoPreview
    : IMediaCaptureVideoPreview.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureVideoPreview));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaCaptureVideoPreview, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaCaptureVideoPreview, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaCaptureVideoPreview, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaCaptureVideoPreview, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaCaptureVideoPreview, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaCaptureVideoPreview, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartPreviewAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IMediaCaptureVideoPreview, IAsyncAction*, int>)((*lpVtbl)[6]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartPreviewToCustomSinkAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension customMediaSink,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureVideoPreview,
                IMediaEncodingProfile,
                IMediaExtension,
                IAsyncAction*,
                int>)((*lpVtbl)[7])
        )(this, encodingProfile, customMediaSink, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartPreviewToCustomSinkIdAsync(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile encodingProfile,
        HSTRING customSinkActivationId,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet customSinkSettings,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureVideoPreview,
                IMediaEncodingProfile,
                HSTRING,
                IPropertySet,
                IAsyncAction*,
                int>)((*lpVtbl)[8])
        )(this, encodingProfile, customSinkActivationId, customSinkSettings, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StopPreviewAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IMediaCaptureVideoPreview, IAsyncAction*, int>)((*lpVtbl)[9]))(
            this,
            asyncInfo
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartPreviewAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(7)]
        HRESULT StartPreviewToCustomSinkAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            [NativeTypeName("ABI::Windows::Media::IMediaExtension *")]
                IMediaExtension customMediaSink,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(8)]
        HRESULT StartPreviewToCustomSinkIdAsync(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile encodingProfile,
            HSTRING customSinkActivationId,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet customSinkSettings,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(9)]
        HRESULT StopPreviewAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
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
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> StartPreviewAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Media::IMediaExtension *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            IMediaExtension,
            IAsyncAction*,
            int> StartPreviewToCustomSinkAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaEncodingProfile,
            HSTRING,
            IPropertySet,
            IAsyncAction*,
            int> StartPreviewToCustomSinkIdAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> StopPreviewAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCaptureVideoPreview"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCaptureVideoPreview(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaCaptureVideoPreview"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaCaptureVideoPreview(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaCaptureVideoPreview(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureVideoPreview"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureVideoPreview"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaCaptureVideoPreview value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCaptureVideoPreview"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCaptureVideoPreview(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaCaptureVideoPreview(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureVideoPreview"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureVideoPreview"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaCaptureVideoPreview value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
