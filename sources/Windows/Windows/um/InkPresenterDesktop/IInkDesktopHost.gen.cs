// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IInkDesktopHost.xml' path='doc/member[@name="IInkDesktopHost"]/*' />
[Guid("4CE7D875-A981-4140-A1FF-AD93258E8D59")]
[NativeTypeName("struct IInkDesktopHost : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IInkDesktopHost : IInkDesktopHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInkDesktopHost));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInkDesktopHost*, Guid*, void**, int>)(lpVtbl[0]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInkDesktopHost*, uint>)(lpVtbl[1]))((IInkDesktopHost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInkDesktopHost*, uint>)(lpVtbl[2]))((IInkDesktopHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInkDesktopHost.xml' path='doc/member[@name="IInkDesktopHost.QueueWorkItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueueWorkItem(IInkHostWorkItem* workItem)
    {
        return ((delegate* unmanaged<IInkDesktopHost*, IInkHostWorkItem*, int>)(lpVtbl[3]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), workItem);
    }

    /// <include file='IInkDesktopHost.xml' path='doc/member[@name="IInkDesktopHost.CreateInkPresenter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateInkPresenter([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IInkDesktopHost*, Guid*, void**, int>)(lpVtbl[4]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='IInkDesktopHost.xml' path='doc/member[@name="IInkDesktopHost.CreateAndInitializeInkPresenter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateAndInitializeInkPresenter(IUnknown* rootVisual, float width, float height, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IInkDesktopHost*, IUnknown*, float, float, Guid*, void**, int>)(lpVtbl[5]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), rootVisual, width, height, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueueWorkItem(IInkHostWorkItem* workItem);

        [VtblIndex(4)]
        HRESULT CreateInkPresenter([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(5)]
        HRESULT CreateAndInitializeInkPresenter(IUnknown* rootVisual, float width, float height, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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

        [NativeTypeName("HRESULT (IInkHostWorkItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInkHostWorkItem*, int> QueueWorkItem;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> CreateInkPresenter;

        [NativeTypeName("HRESULT (IUnknown *, float, float, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, float, float, Guid*, void**, int> CreateAndInitializeInkPresenter;
    }
}
