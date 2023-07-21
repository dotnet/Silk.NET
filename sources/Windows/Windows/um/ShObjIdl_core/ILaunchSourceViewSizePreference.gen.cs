// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ILaunchSourceViewSizePreference.xml' path='doc/member[@name="ILaunchSourceViewSizePreference"]/*' />
[Guid("E5AA01F7-1FB8-4830-8720-4E6734CBD5F3")]
[NativeTypeName("struct ILaunchSourceViewSizePreference : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILaunchSourceViewSizePreference : ILaunchSourceViewSizePreference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILaunchSourceViewSizePreference));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, uint>)(lpVtbl[1]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, uint>)(lpVtbl[2]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILaunchSourceViewSizePreference.xml' path='doc/member[@name="ILaunchSourceViewSizePreference.GetSourceViewToPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSourceViewToPosition(HWND* hwnd)
    {
        return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, HWND*, int>)(lpVtbl[3]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <include file='ILaunchSourceViewSizePreference.xml' path='doc/member[@name="ILaunchSourceViewSizePreference.GetSourceViewSizePreference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSourceViewSizePreference(APPLICATION_VIEW_SIZE_PREFERENCE* sourceSizeAfterLaunch)
    {
        return ((delegate* unmanaged<ILaunchSourceViewSizePreference*, APPLICATION_VIEW_SIZE_PREFERENCE*, int>)(lpVtbl[4]))((ILaunchSourceViewSizePreference*)Unsafe.AsPointer(ref this), sourceSizeAfterLaunch);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSourceViewToPosition(HWND* hwnd);

        [VtblIndex(4)]
        HRESULT GetSourceViewSizePreference(APPLICATION_VIEW_SIZE_PREFERENCE* sourceSizeAfterLaunch);
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetSourceViewToPosition;

        [NativeTypeName("HRESULT (APPLICATION_VIEW_SIZE_PREFERENCE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPLICATION_VIEW_SIZE_PREFERENCE*, int> GetSourceViewSizePreference;
    }
}
