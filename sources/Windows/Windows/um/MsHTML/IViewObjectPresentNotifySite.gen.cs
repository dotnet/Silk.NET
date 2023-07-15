// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IViewObjectPresentNotifySite.xml' path='doc/member[@name="IViewObjectPresentNotifySite"]/*'/>
[Guid("305107FA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IViewObjectPresentNotifySite : IViewObjectPresentSite")]
[NativeInheritance("IViewObjectPresentSite")]
public unsafe partial struct IViewObjectPresentNotifySite : IViewObjectPresentNotifySite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IViewObjectPresentNotifySite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IViewObjectPresentNotifySite*, Guid*, void**, int> )(lpVtbl[0]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IViewObjectPresentNotifySite*, uint> )(lpVtbl[1]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IViewObjectPresentNotifySite*, uint> )(lpVtbl[2]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IViewObjectPresentSite.CreateSurfacePresenter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSurfacePresenter(IUnknown* pDevice, uint width, uint height, uint backBufferCount, DXGI_FORMAT format, VIEW_OBJECT_ALPHA_MODE mode, ISurfacePresenter** ppQueue)
    {
        return ((delegate* unmanaged<IViewObjectPresentNotifySite*, IUnknown*, uint, uint, uint, DXGI_FORMAT, VIEW_OBJECT_ALPHA_MODE, ISurfacePresenter**, int> )(lpVtbl[3]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this), pDevice, width, height, backBufferCount, format, mode, ppQueue);
    }

    /// <inheritdoc cref = "IViewObjectPresentSite.IsHardwareComposition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsHardwareComposition(BOOL* pIsHardwareComposition)
    {
        return ((delegate* unmanaged<IViewObjectPresentNotifySite*, BOOL*, int> )(lpVtbl[4]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this), pIsHardwareComposition);
    }

    /// <inheritdoc cref = "IViewObjectPresentSite.SetCompositionMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetCompositionMode(VIEW_OBJECT_COMPOSITION_MODE mode)
    {
        return ((delegate* unmanaged<IViewObjectPresentNotifySite*, VIEW_OBJECT_COMPOSITION_MODE, int> )(lpVtbl[5]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this), mode);
    }

    /// <include file='IViewObjectPresentNotifySite.xml' path='doc/member[@name="IViewObjectPresentNotifySite.RequestFrame"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestFrame()
    {
        return ((delegate* unmanaged<IViewObjectPresentNotifySite*, int> )(lpVtbl[6]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IViewObjectPresentSite.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestFrame();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RequestFrame;
    }
}