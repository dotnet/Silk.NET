// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appserviceinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='ICorrelationVectorSource.xml' path='doc/member[@name="ICorrelationVectorSource"]/*' />
[Guid("152B8A3B-B9B9-4685-B56E-974847BC7545")]
[NativeTypeName("struct ICorrelationVectorSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICorrelationVectorSource : ICorrelationVectorSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICorrelationVectorSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICorrelationVectorSource*, Guid*, void**, int>)(lpVtbl[0]))((ICorrelationVectorSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICorrelationVectorSource*, uint>)(lpVtbl[1]))((ICorrelationVectorSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICorrelationVectorSource*, uint>)(lpVtbl[2]))((ICorrelationVectorSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICorrelationVectorSource.xml' path='doc/member[@name="ICorrelationVectorSource.get_CorrelationVector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_CorrelationVector(HSTRING* cv)
    {
        return ((delegate* unmanaged<ICorrelationVectorSource*, HSTRING*, int>)(lpVtbl[3]))((ICorrelationVectorSource*)Unsafe.AsPointer(ref this), cv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_CorrelationVector(HSTRING* cv);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CorrelationVector;
    }
}
