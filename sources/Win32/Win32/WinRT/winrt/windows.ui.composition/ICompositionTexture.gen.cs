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

[Guid("347D03A0-1C0A-4C0B-B232-8570B2B1A4EA")]
[NativeTypeName("struct ICompositionTexture : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionTexture : ICompositionTexture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionTexture));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionTexture, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionTexture, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionTexture, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionTexture, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionTexture, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionTexture, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceRect(
        [NativeTypeName("ABI::Windows::Graphics::RectInt32 *")] RectInt32* value
    )
    {
        return ((delegate* unmanaged<ICompositionTexture, RectInt32*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SourceRect(
        [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 value
    )
    {
        return ((delegate* unmanaged<ICompositionTexture, RectInt32, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AlphaMode(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")]
            DirectXAlphaMode* value
    )
    {
        return ((delegate* unmanaged<ICompositionTexture, DirectXAlphaMode*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AlphaMode(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode value
    )
    {
        return ((delegate* unmanaged<ICompositionTexture, DirectXAlphaMode, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ColorSpace(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXColorSpace *")]
            DirectXColorSpace* value
    )
    {
        return ((delegate* unmanaged<ICompositionTexture, DirectXColorSpace*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ColorSpace(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXColorSpace")]
            DirectXColorSpace value
    )
    {
        return ((delegate* unmanaged<ICompositionTexture, DirectXColorSpace, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceRect(
            [NativeTypeName("ABI::Windows::Graphics::RectInt32 *")] RectInt32* value
        );

        [VtblIndex(7)]
        HRESULT put_SourceRect(
            [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 value
        );

        [VtblIndex(8)]
        HRESULT get_AlphaMode(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")]
                DirectXAlphaMode* value
        );

        [VtblIndex(9)]
        HRESULT put_AlphaMode(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")]
                DirectXAlphaMode value
        );

        [VtblIndex(10)]
        HRESULT get_ColorSpace(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXColorSpace *")]
                DirectXColorSpace* value
        );

        [VtblIndex(11)]
        HRESULT put_ColorSpace(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXColorSpace")]
                DirectXColorSpace value
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::RectInt32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RectInt32*, int> get_SourceRect;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::RectInt32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RectInt32, int> put_SourceRect;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::DirectXAlphaMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DirectXAlphaMode*, int> get_AlphaMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::DirectXAlphaMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DirectXAlphaMode, int> put_AlphaMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::DirectXColorSpace *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DirectXColorSpace*, int> get_ColorSpace;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::DirectXColorSpace) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DirectXColorSpace, int> put_ColorSpace;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionTexture"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionTexture(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionTexture"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionTexture(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionTexture(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionTexture"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionTexture"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionTexture value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionTexture"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionTexture(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionTexture(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionTexture"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionTexture"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionTexture value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
