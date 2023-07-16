// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDirectManipulationManager2.xml' path='doc/member[@name="IDirectManipulationManager2"]/*'/>
[Guid("FA1005E9-3D16-484C-BFC9-62B61E56EC4E")]
[NativeTypeName("struct IDirectManipulationManager2 : IDirectManipulationManager")]
[NativeInheritance("IDirectManipulationManager")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDirectManipulationManager2 : IDirectManipulationManager2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationManager2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, Guid*, void**, int> )(lpVtbl[0]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, uint> )(lpVtbl[1]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, uint> )(lpVtbl[2]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDirectManipulationManager.Activate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate(HWND window)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, HWND, int> )(lpVtbl[3]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), window);
    }

    /// <inheritdoc cref = "IDirectManipulationManager.Deactivate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Deactivate(HWND window)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, HWND, int> )(lpVtbl[4]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), window);
    }

    /// <inheritdoc cref = "IDirectManipulationManager.RegisterHitTestTarget"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterHitTestTarget(HWND window, HWND hitTestWindow, DIRECTMANIPULATION_HITTEST_TYPE type)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, HWND, HWND, DIRECTMANIPULATION_HITTEST_TYPE, int> )(lpVtbl[5]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), window, hitTestWindow, type);
    }

    /// <inheritdoc cref = "IDirectManipulationManager.ProcessInput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProcessInput([NativeTypeName("const MSG *")] MSG* message, BOOL* handled)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, MSG*, BOOL*, int> )(lpVtbl[6]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), message, handled);
    }

    /// <inheritdoc cref = "IDirectManipulationManager.GetUpdateManager"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdateManager([NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, Guid*, void**, int> )(lpVtbl[7]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), riid, @object);
    }

    /// <inheritdoc cref = "IDirectManipulationManager.CreateViewport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateViewport(IDirectManipulationFrameInfoProvider* frameInfo, HWND window, [NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, IDirectManipulationFrameInfoProvider*, HWND, Guid*, void**, int> )(lpVtbl[8]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), frameInfo, window, riid, @object);
    }

    /// <inheritdoc cref = "IDirectManipulationManager.CreateContent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateContent(IDirectManipulationFrameInfoProvider* frameInfo, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, IDirectManipulationFrameInfoProvider*, Guid*, Guid*, void**, int> )(lpVtbl[9]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), frameInfo, clsid, riid, @object);
    }

    /// <include file='IDirectManipulationManager2.xml' path='doc/member[@name="IDirectManipulationManager2.CreateBehavior"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateBehavior([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return ((delegate* unmanaged<IDirectManipulationManager2*, Guid*, Guid*, void**, int> )(lpVtbl[10]))((IDirectManipulationManager2*)Unsafe.AsPointer(ref this), clsid, riid, @object);
    }

    public interface Interface : IDirectManipulationManager.Interface
    {
        [VtblIndex(10)]
        HRESULT CreateBehavior([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, void** @object);
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
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Activate;
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Deactivate;
        [NativeTypeName("HRESULT (HWND, HWND, DIRECTMANIPULATION_HITTEST_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HWND, DIRECTMANIPULATION_HITTEST_TYPE, int> RegisterHitTestTarget;
        [NativeTypeName("HRESULT (const MSG *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, BOOL*, int> ProcessInput;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetUpdateManager;
        [NativeTypeName("HRESULT (IDirectManipulationFrameInfoProvider *, HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationFrameInfoProvider*, HWND, Guid*, void**, int> CreateViewport;
        [NativeTypeName("HRESULT (IDirectManipulationFrameInfoProvider *, const IID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationFrameInfoProvider*, Guid*, Guid*, void**, int> CreateContent;
        [NativeTypeName("HRESULT (const IID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> CreateBehavior;
    }
}