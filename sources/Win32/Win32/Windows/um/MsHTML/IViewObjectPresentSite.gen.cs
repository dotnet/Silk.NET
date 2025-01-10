// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305106E1-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IViewObjectPresentSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IViewObjectPresentSite : IViewObjectPresentSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IViewObjectPresentSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IViewObjectPresentSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IViewObjectPresentSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IViewObjectPresentSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSurfacePresenter(
        IUnknown pDevice,
        uint width,
        uint height,
        uint backBufferCount,
        DXGI_FORMAT format,
        VIEW_OBJECT_ALPHA_MODE mode,
        ISurfacePresenter* ppQueue
    )
    {
        return (
            (delegate* unmanaged<
                IViewObjectPresentSite,
                IUnknown,
                uint,
                uint,
                uint,
                DXGI_FORMAT,
                VIEW_OBJECT_ALPHA_MODE,
                ISurfacePresenter*,
                int>)((*lpVtbl)[3])
        )(this, pDevice, width, height, backBufferCount, format, mode, ppQueue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsHardwareComposition(BOOL* pIsHardwareComposition)
    {
        return ((delegate* unmanaged<IViewObjectPresentSite, BOOL*, int>)((*lpVtbl)[4]))(
            this,
            pIsHardwareComposition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetCompositionMode(VIEW_OBJECT_COMPOSITION_MODE mode)
    {
        return (
            (delegate* unmanaged<IViewObjectPresentSite, VIEW_OBJECT_COMPOSITION_MODE, int>)(
                (*lpVtbl)[5]
            )
        )(this, mode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSurfacePresenter(
            IUnknown pDevice,
            uint width,
            uint height,
            uint backBufferCount,
            DXGI_FORMAT format,
            VIEW_OBJECT_ALPHA_MODE mode,
            ISurfacePresenter* ppQueue
        );

        [VtblIndex(4)]
        HRESULT IsHardwareComposition(BOOL* pIsHardwareComposition);

        [VtblIndex(5)]
        HRESULT SetCompositionMode(VIEW_OBJECT_COMPOSITION_MODE mode);
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

        [NativeTypeName(
            "HRESULT (IUnknown *, UINT, UINT, UINT, DXGI_FORMAT, VIEW_OBJECT_ALPHA_MODE, ISurfacePresenter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            uint,
            uint,
            uint,
            DXGI_FORMAT,
            VIEW_OBJECT_ALPHA_MODE,
            ISurfacePresenter*,
            int> CreateSurfacePresenter;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsHardwareComposition;

        [NativeTypeName("HRESULT (VIEW_OBJECT_COMPOSITION_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VIEW_OBJECT_COMPOSITION_MODE, int> SetCompositionMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IViewObjectPresentSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IViewObjectPresentSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IViewObjectPresentSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IViewObjectPresentSite(Silk.NET.Windows.IUnknown value)
    {
        return new IViewObjectPresentSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IViewObjectPresentSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IViewObjectPresentSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IViewObjectPresentSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
