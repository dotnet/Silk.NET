// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaEngineEME.xml' path='doc/member[@name="IMFMediaEngineEME"]/*' />
[Guid("50DC93E4-BA4F-4275-AE66-83E836E57469")]
[NativeTypeName("struct IMFMediaEngineEME : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaEngineEME : IMFMediaEngineEME.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineEME));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineEME*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineEME*, uint>)(lpVtbl[1]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineEME*, uint>)(lpVtbl[2]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineEME.xml' path='doc/member[@name="IMFMediaEngineEME.get_Keys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Keys(IMFMediaKeys** keys)
    {
        return ((delegate* unmanaged<IMFMediaEngineEME*, IMFMediaKeys**, int>)(lpVtbl[3]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), keys);
    }

    /// <include file='IMFMediaEngineEME.xml' path='doc/member[@name="IMFMediaEngineEME.SetMediaKeys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetMediaKeys(IMFMediaKeys* keys)
    {
        return ((delegate* unmanaged<IMFMediaEngineEME*, IMFMediaKeys*, int>)(lpVtbl[4]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), keys);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Keys(IMFMediaKeys** keys);

        [VtblIndex(4)]
        HRESULT SetMediaKeys(IMFMediaKeys* keys);
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

        [NativeTypeName("HRESULT (IMFMediaKeys **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaKeys**, int> get_Keys;

        [NativeTypeName("HRESULT (IMFMediaKeys *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaKeys*, int> SetMediaKeys;
    }
}
