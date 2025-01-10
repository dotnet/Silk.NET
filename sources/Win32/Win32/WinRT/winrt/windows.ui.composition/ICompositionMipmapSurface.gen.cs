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

[Guid("4863675C-CF4A-4B1C-9ECE-C5EC0C2B2FE6")]
[NativeTypeName("struct ICompositionMipmapSurface : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionMipmapSurface
    : ICompositionMipmapSurface.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionMipmapSurface));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionMipmapSurface, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionMipmapSurface, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionMipmapSurface, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionMipmapSurface, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionMipmapSurface, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionMipmapSurface, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LevelCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ICompositionMipmapSurface, uint*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AlphaMode(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")]
            DirectXAlphaMode* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionMipmapSurface, DirectXAlphaMode*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PixelFormat(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat *")]
            DirectXPixelFormat* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionMipmapSurface, DirectXPixelFormat*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SizeInt32(
        [NativeTypeName("ABI::Windows::Graphics::SizeInt32 *")] SizeInt32* value
    )
    {
        return ((delegate* unmanaged<ICompositionMipmapSurface, SizeInt32*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDrawingSurfaceForLevel(
        [NativeTypeName("UINT32")] uint level,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")]
            ICompositionDrawingSurface* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionMipmapSurface,
                uint,
                ICompositionDrawingSurface*,
                int>)((*lpVtbl)[10])
        )(this, level, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LevelCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_AlphaMode(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode *")]
                DirectXAlphaMode* value
        );

        [VtblIndex(8)]
        HRESULT get_PixelFormat(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat *")]
                DirectXPixelFormat* value
        );

        [VtblIndex(9)]
        HRESULT get_SizeInt32(
            [NativeTypeName("ABI::Windows::Graphics::SizeInt32 *")] SizeInt32* value
        );

        [VtblIndex(10)]
        HRESULT GetDrawingSurfaceForLevel(
            [NativeTypeName("UINT32")] uint level,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")]
                ICompositionDrawingSurface* result
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_LevelCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::DirectXAlphaMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DirectXAlphaMode*, int> get_AlphaMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::DirectXPixelFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DirectXPixelFormat*, int> get_PixelFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SizeInt32*, int> get_SizeInt32;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::UI::Composition::ICompositionDrawingSurface **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ICompositionDrawingSurface*,
            int> GetDrawingSurfaceForLevel;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionMipmapSurface"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionMipmapSurface(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionMipmapSurface"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionMipmapSurface(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionMipmapSurface(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionMipmapSurface"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionMipmapSurface"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionMipmapSurface value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionMipmapSurface"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionMipmapSurface(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionMipmapSurface(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionMipmapSurface"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionMipmapSurface"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionMipmapSurface value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
