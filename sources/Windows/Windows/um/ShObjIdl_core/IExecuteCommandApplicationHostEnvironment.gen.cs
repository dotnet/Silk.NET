// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IExecuteCommandApplicationHostEnvironment.xml' path='doc/member[@name="IExecuteCommandApplicationHostEnvironment"]/*' />
[Guid("18B21AA9-E184-4FF0-9F5E-F882D03771B3")]
[NativeTypeName("struct IExecuteCommandApplicationHostEnvironment : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExecuteCommandApplicationHostEnvironment : IExecuteCommandApplicationHostEnvironment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExecuteCommandApplicationHostEnvironment));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExecuteCommandApplicationHostEnvironment*, Guid*, void**, int>)(lpVtbl[0]))((IExecuteCommandApplicationHostEnvironment*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IExecuteCommandApplicationHostEnvironment*, uint>)(lpVtbl[1]))((IExecuteCommandApplicationHostEnvironment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExecuteCommandApplicationHostEnvironment*, uint>)(lpVtbl[2]))((IExecuteCommandApplicationHostEnvironment*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExecuteCommandApplicationHostEnvironment.xml' path='doc/member[@name="IExecuteCommandApplicationHostEnvironment.GetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetValue(AHE_TYPE* pahe)
    {
        return ((delegate* unmanaged<IExecuteCommandApplicationHostEnvironment*, AHE_TYPE*, int>)(lpVtbl[3]))((IExecuteCommandApplicationHostEnvironment*)Unsafe.AsPointer(ref this), pahe);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetValue(AHE_TYPE* pahe);
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

        [NativeTypeName("HRESULT (AHE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AHE_TYPE*, int> GetValue;
    }
}
