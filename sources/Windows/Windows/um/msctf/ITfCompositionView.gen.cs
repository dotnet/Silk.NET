// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfCompositionView.xml' path='doc/member[@name="ITfCompositionView"]/*' />
[Guid("D7540241-F9A1-4364-BEFC-DBCD2C4395B7")]
[NativeTypeName("struct ITfCompositionView : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCompositionView : ITfCompositionView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCompositionView));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCompositionView*, Guid*, void**, int>)(lpVtbl[0]))((ITfCompositionView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCompositionView*, uint>)(lpVtbl[1]))((ITfCompositionView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCompositionView*, uint>)(lpVtbl[2]))((ITfCompositionView*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCompositionView.xml' path='doc/member[@name="ITfCompositionView.GetOwnerClsid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOwnerClsid([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<ITfCompositionView*, Guid*, int>)(lpVtbl[3]))((ITfCompositionView*)Unsafe.AsPointer(ref this), pclsid);
    }

    /// <include file='ITfCompositionView.xml' path='doc/member[@name="ITfCompositionView.GetRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRange(ITfRange** ppRange)
    {
        return ((delegate* unmanaged<ITfCompositionView*, ITfRange**, int>)(lpVtbl[4]))((ITfCompositionView*)Unsafe.AsPointer(ref this), ppRange);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOwnerClsid([NativeTypeName("CLSID *")] Guid* pclsid);

        [VtblIndex(4)]
        HRESULT GetRange(ITfRange** ppRange);
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetOwnerClsid;

        [NativeTypeName("HRESULT (ITfRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange**, int> GetRange;
    }
}
