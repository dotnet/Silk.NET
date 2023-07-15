// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Gdiplus;
/// <include file='IImageBytes.xml' path='doc/member[@name="IImageBytes"]/*'/>
[Guid("025D1823-6C7D-447B-BBDB-A3CBC3DFA2FC")]
[NativeTypeName("struct IImageBytes : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IImageBytes : IImageBytes.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageBytes));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IImageBytes*, Guid*, void**, int> )(lpVtbl[0]))((IImageBytes*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IImageBytes*, uint> )(lpVtbl[1]))((IImageBytes*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IImageBytes*, uint> )(lpVtbl[2]))((IImageBytes*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IImageBytes.xml' path='doc/member[@name="IImageBytes.CountBytes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CountBytes(uint* pcb)
    {
        return ((delegate* unmanaged<IImageBytes*, uint*, int> )(lpVtbl[3]))((IImageBytes*)Unsafe.AsPointer(ref this), pcb);
    }

    /// <include file='IImageBytes.xml' path='doc/member[@name="IImageBytes.LockBytes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LockBytes(uint cb, [NativeTypeName("ULONG")] uint ulOffset, [NativeTypeName("const void **")] void** ppvBytes)
    {
        return ((delegate* unmanaged<IImageBytes*, uint, uint, void**, int> )(lpVtbl[4]))((IImageBytes*)Unsafe.AsPointer(ref this), cb, ulOffset, ppvBytes);
    }

    /// <include file='IImageBytes.xml' path='doc/member[@name="IImageBytes.UnlockBytes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UnlockBytes([NativeTypeName("const void *")] void* pvBytes, uint cb, [NativeTypeName("ULONG")] uint ulOffset)
    {
        return ((delegate* unmanaged<IImageBytes*, void*, uint, uint, int> )(lpVtbl[5]))((IImageBytes*)Unsafe.AsPointer(ref this), pvBytes, cb, ulOffset);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CountBytes(uint* pcb);
        [VtblIndex(4)]
        HRESULT LockBytes(uint cb, [NativeTypeName("ULONG")] uint ulOffset, [NativeTypeName("const void **")] void** ppvBytes);
        [VtblIndex(5)]
        HRESULT UnlockBytes([NativeTypeName("const void *")] void* pvBytes, uint cb, [NativeTypeName("ULONG")] uint ulOffset);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> CountBytes;
        [NativeTypeName("HRESULT (UINT, ULONG, const void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, void**, int> LockBytes;
        [NativeTypeName("HRESULT (const void *, UINT, ULONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint, int> UnlockBytes;
    }
}