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

[Guid("48587540-6F93-4BB4-B8F3-E89E48948C91")]
[NativeTypeName("struct ICameraCaptureUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraCaptureUI : ICameraCaptureUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraCaptureUI));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICameraCaptureUI, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICameraCaptureUI, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICameraCaptureUI, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICameraCaptureUI, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICameraCaptureUI, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICameraCaptureUI, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PhotoSettings(
        [NativeTypeName("ABI::Windows::Media::Capture::ICameraCaptureUIPhotoCaptureSettings **")]
            ICameraCaptureUIPhotoCaptureSettings* value
    )
    {
        return (
            (delegate* unmanaged<ICameraCaptureUI, ICameraCaptureUIPhotoCaptureSettings*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoSettings(
        [NativeTypeName("ABI::Windows::Media::Capture::ICameraCaptureUIVideoCaptureSettings **")]
            ICameraCaptureUIVideoCaptureSettings* value
    )
    {
        return (
            (delegate* unmanaged<ICameraCaptureUI, ICameraCaptureUIVideoCaptureSettings*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CaptureFileAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMode")]
            CameraCaptureUIMode mode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                ICameraCaptureUI,
                CameraCaptureUIMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, mode, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PhotoSettings(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::ICameraCaptureUIPhotoCaptureSettings **"
            )]
                ICameraCaptureUIPhotoCaptureSettings* value
        );

        [VtblIndex(7)]
        HRESULT get_VideoSettings(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::ICameraCaptureUIVideoCaptureSettings **"
            )]
                ICameraCaptureUIVideoCaptureSettings* value
        );

        [VtblIndex(8)]
        HRESULT CaptureFileAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMode")]
                CameraCaptureUIMode mode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
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
            "HRESULT (ABI::Windows::Media::Capture::ICameraCaptureUIPhotoCaptureSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICameraCaptureUIPhotoCaptureSettings*,
            int> get_PhotoSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::ICameraCaptureUIVideoCaptureSettings **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICameraCaptureUIVideoCaptureSettings*,
            int> get_VideoSettings;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CameraCaptureUIMode,
            IAsyncOperation<IntPtr>**,
            int> CaptureFileAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICameraCaptureUI"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICameraCaptureUI(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICameraCaptureUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICameraCaptureUI(Silk.NET.WinRT.IInspectable value)
    {
        return new ICameraCaptureUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraCaptureUI"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraCaptureUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICameraCaptureUI value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICameraCaptureUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICameraCaptureUI(Silk.NET.Windows.IUnknown value)
    {
        return new ICameraCaptureUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraCaptureUI"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraCaptureUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICameraCaptureUI value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
