// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ICDBurnExt.xml' path='doc/member[@name="ICDBurnExt"]/*' />
[Guid("2271DCCA-74FC-4414-8FB7-C56B05ACE2D7")]
[NativeTypeName("struct ICDBurnExt : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICDBurnExt : ICDBurnExt.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICDBurnExt));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICDBurnExt*, Guid*, void**, int>)(lpVtbl[0]))((ICDBurnExt*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICDBurnExt*, uint>)(lpVtbl[1]))((ICDBurnExt*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICDBurnExt*, uint>)(lpVtbl[2]))((ICDBurnExt*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICDBurnExt.xml' path='doc/member[@name="ICDBurnExt.GetSupportedActionTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSupportedActionTypes([NativeTypeName("CDBE_ACTIONS *")] uint* pdwActions)
    {
        return ((delegate* unmanaged<ICDBurnExt*, uint*, int>)(lpVtbl[3]))((ICDBurnExt*)Unsafe.AsPointer(ref this), pdwActions);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSupportedActionTypes([NativeTypeName("CDBE_ACTIONS *")] uint* pdwActions);
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

        [NativeTypeName("HRESULT (CDBE_ACTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSupportedActionTypes;
    }
}
