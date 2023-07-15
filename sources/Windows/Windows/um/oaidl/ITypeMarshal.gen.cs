// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITypeMarshal.xml' path='doc/member[@name="ITypeMarshal"]/*'/>
[Guid("0000002D-0000-0000-C000-000000000046")]
[NativeTypeName("struct ITypeMarshal : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITypeMarshal : ITypeMarshal.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITypeMarshal));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITypeMarshal*, Guid*, void**, int> )(lpVtbl[0]))((ITypeMarshal*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITypeMarshal*, uint> )(lpVtbl[1]))((ITypeMarshal*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITypeMarshal*, uint> )(lpVtbl[2]))((ITypeMarshal*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITypeMarshal.xml' path='doc/member[@name="ITypeMarshal.Size"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Size([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG *")] uint* pSize)
    {
        return ((delegate* unmanaged<ITypeMarshal*, void*, uint, void*, uint*, int> )(lpVtbl[3]))((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwDestContext, pvDestContext, pSize);
    }

    /// <include file='ITypeMarshal.xml' path='doc/member[@name="ITypeMarshal.Marshal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Marshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG")] uint cbBufferLength, byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int> )(lpVtbl[4]))((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
    }

    /// <include file='ITypeMarshal.xml' path='doc/member[@name="ITypeMarshal.Unmarshal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Unmarshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cbBufferLength, byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<ITypeMarshal*, void*, uint, uint, byte*, uint*, int> )(lpVtbl[5]))((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType, dwFlags, cbBufferLength, pBuffer, pcbRead);
    }

    /// <include file='ITypeMarshal.xml' path='doc/member[@name="ITypeMarshal.Free"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Free([NativeTypeName("PVOID")] void* pvType)
    {
        return ((delegate* unmanaged<ITypeMarshal*, void*, int> )(lpVtbl[6]))((ITypeMarshal*)Unsafe.AsPointer(ref this), pvType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Size([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG *")] uint* pSize);
        [VtblIndex(4)]
        HRESULT Marshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("PVOID")] void* pvDestContext, [NativeTypeName("ULONG")] uint cbBufferLength, byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbWritten);
        [VtblIndex(5)]
        HRESULT Unmarshal([NativeTypeName("PVOID")] void* pvType, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cbBufferLength, byte* pBuffer, [NativeTypeName("ULONG *")] uint* pcbRead);
        [VtblIndex(6)]
        HRESULT Free([NativeTypeName("PVOID")] void* pvType);
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
        [NativeTypeName("HRESULT (PVOID, DWORD, PVOID, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, void*, uint*, int> Size;
        [NativeTypeName("HRESULT (PVOID, DWORD, PVOID, ULONG, BYTE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, void*, uint, byte*, uint*, int> Marshal;
        [NativeTypeName("HRESULT (PVOID, DWORD, ULONG, BYTE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint, byte*, uint*, int> Unmarshal;
        [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> Free;
    }
}