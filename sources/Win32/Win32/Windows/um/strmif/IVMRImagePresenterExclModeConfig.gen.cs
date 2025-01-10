// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E6F7CE40-4673-44F1-8F77-5499D68CB4EA")]
[NativeTypeName("struct IVMRImagePresenterExclModeConfig : IVMRImagePresenterConfig")]
[NativeInheritance("IVMRImagePresenterConfig")]
public unsafe partial struct IVMRImagePresenterExclModeConfig
    : IVMRImagePresenterExclModeConfig.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRImagePresenterExclModeConfig));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IVMRImagePresenterExclModeConfig, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig, uint, int>)((*lpVtbl)[3]))(
            this,
            dwRenderFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRenderingPrefs([NativeTypeName("DWORD *")] uint* dwRenderFlags)
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig, uint*, int>)((*lpVtbl)[4]))(
            this,
            dwRenderFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetXlcModeDDObjAndPrimarySurface(
        [NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7 lpDDObj,
        [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7 lpPrimarySurf
    )
    {
        return (
            (delegate* unmanaged<
                IVMRImagePresenterExclModeConfig,
                IDirectDraw7,
                IDirectDrawSurface7,
                int>)((*lpVtbl)[5])
        )(this, lpDDObj, lpPrimarySurf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetXlcModeDDObjAndPrimarySurface(
        [NativeTypeName("LPDIRECTDRAW7 *")] IDirectDraw7* lpDDObj,
        [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7* lpPrimarySurf
    )
    {
        return (
            (delegate* unmanaged<
                IVMRImagePresenterExclModeConfig,
                IDirectDraw7*,
                IDirectDrawSurface7*,
                int>)((*lpVtbl)[6])
        )(this, lpDDObj, lpPrimarySurf);
    }

    public interface Interface : IVMRImagePresenterConfig.Interface
    {
        [VtblIndex(5)]
        HRESULT SetXlcModeDDObjAndPrimarySurface(
            [NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7 lpDDObj,
            [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7 lpPrimarySurf
        );

        [VtblIndex(6)]
        HRESULT GetXlcModeDDObjAndPrimarySurface(
            [NativeTypeName("LPDIRECTDRAW7 *")] IDirectDraw7* lpDDObj,
            [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7* lpPrimarySurf
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetRenderingPrefs;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetRenderingPrefs;

        [NativeTypeName("HRESULT (LPDIRECTDRAW7, LPDIRECTDRAWSURFACE7) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IDirectDraw7,
            IDirectDrawSurface7,
            int> SetXlcModeDDObjAndPrimarySurface;

        [NativeTypeName(
            "HRESULT (LPDIRECTDRAW7 *, LPDIRECTDRAWSURFACE7 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirectDraw7*,
            IDirectDrawSurface7*,
            int> GetXlcModeDDObjAndPrimarySurface;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVMRImagePresenterExclModeConfig"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVMRImagePresenterExclModeConfig(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IVMRImagePresenterConfig"/> to <see cref = "IVMRImagePresenterExclModeConfig"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IVMRImagePresenterConfig"/> instance to be converted </param>
    public static explicit operator IVMRImagePresenterExclModeConfig(
        Silk.NET.Windows.IVMRImagePresenterConfig value
    )
    {
        return new IVMRImagePresenterExclModeConfig(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRImagePresenterExclModeConfig"/> to <see cref = "Silk.NET.Windows.IVMRImagePresenterConfig"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRImagePresenterExclModeConfig"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IVMRImagePresenterConfig(
        IVMRImagePresenterExclModeConfig value
    )
    {
        return new Silk.NET.Windows.IVMRImagePresenterConfig(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVMRImagePresenterExclModeConfig"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVMRImagePresenterExclModeConfig(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IVMRImagePresenterExclModeConfig(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRImagePresenterExclModeConfig"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRImagePresenterExclModeConfig"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IVMRImagePresenterExclModeConfig value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
