// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FB22C6E1-80A2-4667-9936-DBEAF6EEFE95")]
[NativeTypeName("struct ICompositionGraphicsDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGraphicsDevice
    : ICompositionGraphicsDevice.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGraphicsDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositionGraphicsDevice, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionGraphicsDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionGraphicsDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICompositionGraphicsDevice, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionGraphicsDevice, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionGraphicsDevice, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateDrawingSurface(
        [NativeTypeName("ABI::Windows::Foundation::Size")] Size sizePixels,
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
            DirectXPixelFormat pixelFormat,
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")]
            DirectXAlphaMode alphaMode,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")]
            ICompositionDrawingSurface* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionGraphicsDevice,
                Size,
                DirectXPixelFormat,
                DirectXAlphaMode,
                ICompositionDrawingSurface*,
                int>)((*lpVtbl)[6])
        )(this, sizePixels, pixelFormat, alphaMode, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_RenderingDeviceReplaced(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCompositionGraphicsDevice_Windows__CUI__CComposition__CRenderingDeviceReplacedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionGraphicsDevice,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[7])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_RenderingDeviceReplaced(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICompositionGraphicsDevice, EventRegistrationToken, int>)(
                (*lpVtbl)[8]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateDrawingSurface(
            [NativeTypeName("ABI::Windows::Foundation::Size")] Size sizePixels,
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
                DirectXPixelFormat pixelFormat,
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")]
                DirectXAlphaMode alphaMode,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")]
                ICompositionDrawingSurface* result
        );

        [VtblIndex(7)]
        HRESULT add_RenderingDeviceReplaced(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCompositionGraphicsDevice_Windows__CUI__CComposition__CRenderingDeviceReplacedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(8)]
        HRESULT remove_RenderingDeviceReplaced(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Foundation::Size, ABI::Windows::Graphics::DirectX::DirectXPixelFormat, ABI::Windows::Graphics::DirectX::DirectXAlphaMode, ABI::Windows::UI::Composition::ICompositionDrawingSurface **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Size,
            DirectXPixelFormat,
            DirectXAlphaMode,
            ICompositionDrawingSurface*,
            int> CreateDrawingSurface;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CComposition__CCompositionGraphicsDevice_Windows__CUI__CComposition__CRenderingDeviceReplacedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_RenderingDeviceReplaced;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_RenderingDeviceReplaced;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionGraphicsDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionGraphicsDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionGraphicsDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionGraphicsDevice(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionGraphicsDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionGraphicsDevice"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionGraphicsDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionGraphicsDevice value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionGraphicsDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionGraphicsDevice(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionGraphicsDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionGraphicsDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionGraphicsDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionGraphicsDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
