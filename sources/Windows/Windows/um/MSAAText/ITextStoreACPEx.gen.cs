// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITextStoreACPEx.xml' path='doc/member[@name="ITextStoreACPEx"]/*'/>
[Guid("A2DE3BC2-3D8E-11D3-81A9-F753FBE61A00")]
[NativeTypeName("struct ITextStoreACPEx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITextStoreACPEx : ITextStoreACPEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextStoreACPEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextStoreACPEx*, Guid*, void**, int> )(lpVtbl[0]))((ITextStoreACPEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITextStoreACPEx*, uint> )(lpVtbl[1]))((ITextStoreACPEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextStoreACPEx*, uint> )(lpVtbl[2]))((ITextStoreACPEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITextStoreACPEx.xml' path='doc/member[@name="ITextStoreACPEx.ScrollToRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ScrollToRect([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT rc, [NativeTypeName("DWORD")] uint dwPosition)
    {
        return ((delegate* unmanaged<ITextStoreACPEx*, int, int, RECT, uint, int> )(lpVtbl[3]))((ITextStoreACPEx*)Unsafe.AsPointer(ref this), acpStart, acpEnd, rc, dwPosition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ScrollToRect([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT rc, [NativeTypeName("DWORD")] uint dwPosition);
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
        [NativeTypeName("HRESULT (LONG, LONG, RECT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, RECT, uint, int> ScrollToRect;
    }
}