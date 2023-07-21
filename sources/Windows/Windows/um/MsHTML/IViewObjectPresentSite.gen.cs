// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IViewObjectPresentSite.xml' path='doc/member[@name="IViewObjectPresentSite"]/*' />
[Guid("305106E1-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IViewObjectPresentSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IViewObjectPresentSite : IViewObjectPresentSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IViewObjectPresentSite));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IViewObjectPresentSite*, Guid*, void**, int>)(lpVtbl[0]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IViewObjectPresentSite*, uint>)(lpVtbl[1]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IViewObjectPresentSite*, uint>)(lpVtbl[2]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IViewObjectPresentSite.xml' path='doc/member[@name="IViewObjectPresentSite.CreateSurfacePresenter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSurfacePresenter(IUnknown* pDevice, uint width, uint height, uint backBufferCount, DXGI_FORMAT format, VIEW_OBJECT_ALPHA_MODE mode, ISurfacePresenter** ppQueue)
    {
        return ((delegate* unmanaged<IViewObjectPresentSite*, IUnknown*, uint, uint, uint, DXGI_FORMAT, VIEW_OBJECT_ALPHA_MODE, ISurfacePresenter**, int>)(lpVtbl[3]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this), pDevice, width, height, backBufferCount, format, mode, ppQueue);
    }

    /// <include file='IViewObjectPresentSite.xml' path='doc/member[@name="IViewObjectPresentSite.IsHardwareComposition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsHardwareComposition(BOOL* pIsHardwareComposition)
    {
        return ((delegate* unmanaged<IViewObjectPresentSite*, BOOL*, int>)(lpVtbl[4]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this), pIsHardwareComposition);
    }

    /// <include file='IViewObjectPresentSite.xml' path='doc/member[@name="IViewObjectPresentSite.SetCompositionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetCompositionMode(VIEW_OBJECT_COMPOSITION_MODE mode)
    {
        return ((delegate* unmanaged<IViewObjectPresentSite*, VIEW_OBJECT_COMPOSITION_MODE, int>)(lpVtbl[5]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this), mode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSurfacePresenter(IUnknown* pDevice, uint width, uint height, uint backBufferCount, DXGI_FORMAT format, VIEW_OBJECT_ALPHA_MODE mode, ISurfacePresenter** ppQueue);

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

        [NativeTypeName("HRESULT (IUnknown *, UINT, UINT, UINT, DXGI_FORMAT, VIEW_OBJECT_ALPHA_MODE, ISurfacePresenter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, uint, uint, DXGI_FORMAT, VIEW_OBJECT_ALPHA_MODE, ISurfacePresenter**, int> CreateSurfacePresenter;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsHardwareComposition;

        [NativeTypeName("HRESULT (VIEW_OBJECT_COMPOSITION_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VIEW_OBJECT_COMPOSITION_MODE, int> SetCompositionMode;
    }
}
