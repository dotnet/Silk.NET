// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("947CB473-A39E-4362-ABBF-9F8B5070A062")]
[NativeTypeName("struct IMediaOverlayLayerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaOverlayLayerFactory
    : IMediaOverlayLayerFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaOverlayLayerFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaOverlayLayerFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaOverlayLayerFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaOverlayLayerFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaOverlayLayerFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaOverlayLayerFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaOverlayLayerFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithCompositorDefinition(
        [NativeTypeName("ABI::Windows::Media::Effects::IVideoCompositorDefinition *")]
            IVideoCompositorDefinition compositorDefinition,
        [NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlayLayer **")]
            IMediaOverlayLayer* mediaOverlayLayer
    )
    {
        return (
            (delegate* unmanaged<
                IMediaOverlayLayerFactory,
                IVideoCompositorDefinition,
                IMediaOverlayLayer*,
                int>)((*lpVtbl)[6])
        )(this, compositorDefinition, mediaOverlayLayer);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithCompositorDefinition(
            [NativeTypeName("ABI::Windows::Media::Effects::IVideoCompositorDefinition *")]
                IVideoCompositorDefinition compositorDefinition,
            [NativeTypeName("ABI::Windows::Media::Editing::IMediaOverlayLayer **")]
                IMediaOverlayLayer* mediaOverlayLayer
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
            "HRESULT (ABI::Windows::Media::Effects::IVideoCompositorDefinition *, ABI::Windows::Media::Editing::IMediaOverlayLayer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVideoCompositorDefinition,
            IMediaOverlayLayer*,
            int> CreateWithCompositorDefinition;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaOverlayLayerFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaOverlayLayerFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaOverlayLayerFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaOverlayLayerFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaOverlayLayerFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaOverlayLayerFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaOverlayLayerFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaOverlayLayerFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaOverlayLayerFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaOverlayLayerFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaOverlayLayerFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaOverlayLayerFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaOverlayLayerFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaOverlayLayerFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
