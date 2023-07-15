// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/MemoryBuffer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IMemoryBufferByteAccess.xml' path='doc/member[@name="IMemoryBufferByteAccess"]/*'/>
[Guid("5B0D3235-4DBA-4D44-865E-8F1D0E4FD04D")]
[NativeTypeName("struct IMemoryBufferByteAccess : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMemoryBufferByteAccess : IMemoryBufferByteAccess.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMemoryBufferByteAccess));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMemoryBufferByteAccess*, Guid*, void**, int> )(lpVtbl[0]))((IMemoryBufferByteAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMemoryBufferByteAccess*, uint> )(lpVtbl[1]))((IMemoryBufferByteAccess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMemoryBufferByteAccess*, uint> )(lpVtbl[2]))((IMemoryBufferByteAccess*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMemoryBufferByteAccess.xml' path='doc/member[@name="IMemoryBufferByteAccess.GetBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** value, [NativeTypeName("UINT32 *")] uint* capacity)
    {
        return ((delegate* unmanaged<IMemoryBufferByteAccess*, byte**, uint*, int> )(lpVtbl[3]))((IMemoryBufferByteAccess*)Unsafe.AsPointer(ref this), value, capacity);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBuffer(byte** value, [NativeTypeName("UINT32 *")] uint* capacity);
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
        [NativeTypeName("HRESULT (BYTE **, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetBuffer;
    }
}