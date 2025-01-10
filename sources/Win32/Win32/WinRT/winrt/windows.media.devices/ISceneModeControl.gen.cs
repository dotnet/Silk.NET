// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D48E5AF7-8D59-4854-8C62-12C70BA89B7C")]
[NativeTypeName("struct ISceneModeControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISceneModeControl : ISceneModeControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISceneModeControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISceneModeControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISceneModeControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISceneModeControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISceneModeControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISceneModeControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISceneModeControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedModes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **"
        )]
            IVectorView<CaptureSceneMode>** value
    )
    {
        return (
            (delegate* unmanaged<ISceneModeControl, IVectorView<CaptureSceneMode>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Value(
        [NativeTypeName("ABI::Windows::Media::Devices::CaptureSceneMode *")] CaptureSceneMode* value
    )
    {
        return ((delegate* unmanaged<ISceneModeControl, CaptureSceneMode*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetValueAsync(
        [NativeTypeName("ABI::Windows::Media::Devices::CaptureSceneMode")]
            CaptureSceneMode sceneMode,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<ISceneModeControl, CaptureSceneMode, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, sceneMode, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedModes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **"
            )]
                IVectorView<CaptureSceneMode>** value
        );

        [VtblIndex(7)]
        HRESULT get_Value(
            [NativeTypeName("ABI::Windows::Media::Devices::CaptureSceneMode *")]
                CaptureSceneMode* value
        );

        [VtblIndex(8)]
        HRESULT SetValueAsync(
            [NativeTypeName("ABI::Windows::Media::Devices::CaptureSceneMode")]
                CaptureSceneMode sceneMode,
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<CaptureSceneMode>**, int> get_SupportedModes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::CaptureSceneMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CaptureSceneMode*, int> get_Value;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::CaptureSceneMode, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CaptureSceneMode, IAsyncAction*, int> SetValueAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISceneModeControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISceneModeControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISceneModeControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISceneModeControl(Silk.NET.WinRT.IInspectable value)
    {
        return new ISceneModeControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISceneModeControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISceneModeControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISceneModeControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISceneModeControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISceneModeControl(Silk.NET.Windows.IUnknown value)
    {
        return new ISceneModeControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISceneModeControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISceneModeControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISceneModeControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
