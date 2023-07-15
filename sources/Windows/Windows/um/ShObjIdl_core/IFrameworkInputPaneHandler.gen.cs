// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFrameworkInputPaneHandler.xml' path='doc/member[@name="IFrameworkInputPaneHandler"]/*'/>
[Guid("226C537B-1E76-4D9E-A760-33DB29922F18")]
[NativeTypeName("struct IFrameworkInputPaneHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFrameworkInputPaneHandler : IFrameworkInputPaneHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameworkInputPaneHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler*, Guid*, void**, int> )(lpVtbl[0]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler*, uint> )(lpVtbl[1]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler*, uint> )(lpVtbl[2]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFrameworkInputPaneHandler.xml' path='doc/member[@name="IFrameworkInputPaneHandler.Showing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Showing(RECT* prcInputPaneScreenLocation, BOOL fEnsureFocusedElementInView)
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler*, RECT*, BOOL, int> )(lpVtbl[3]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this), prcInputPaneScreenLocation, fEnsureFocusedElementInView);
    }

    /// <include file='IFrameworkInputPaneHandler.xml' path='doc/member[@name="IFrameworkInputPaneHandler.Hiding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Hiding(BOOL fEnsureFocusedElementInView)
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler*, BOOL, int> )(lpVtbl[4]))((IFrameworkInputPaneHandler*)Unsafe.AsPointer(ref this), fEnsureFocusedElementInView);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Showing(RECT* prcInputPaneScreenLocation, BOOL fEnsureFocusedElementInView);
        [VtblIndex(4)]
        HRESULT Hiding(BOOL fEnsureFocusedElementInView);
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
        [NativeTypeName("HRESULT (RECT *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, BOOL, int> Showing;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Hiding;
    }
}