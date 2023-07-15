// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFContentDecryptorContext.xml' path='doc/member[@name="IMFContentDecryptorContext"]/*'/>
[Guid("7EC4B1BD-43FB-4763-85D2-64FCB5C5F4CB")]
[NativeTypeName("struct IMFContentDecryptorContext : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFContentDecryptorContext : IMFContentDecryptorContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentDecryptorContext));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext*, Guid*, void**, int> )(lpVtbl[0]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext*, uint> )(lpVtbl[1]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext*, uint> )(lpVtbl[2]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentDecryptorContext.xml' path='doc/member[@name="IMFContentDecryptorContext.InitializeHardwareKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeHardwareKey(uint InputPrivateDataByteCount, [NativeTypeName("const void *")] void* InputPrivateData, [NativeTypeName("UINT64 *")] ulong* OutputPrivateData)
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext*, uint, void*, ulong*, int> )(lpVtbl[3]))((IMFContentDecryptorContext*)Unsafe.AsPointer(ref this), InputPrivateDataByteCount, InputPrivateData, OutputPrivateData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeHardwareKey(uint InputPrivateDataByteCount, [NativeTypeName("const void *")] void* InputPrivateData, [NativeTypeName("UINT64 *")] ulong* OutputPrivateData);
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
        [NativeTypeName("HRESULT (UINT, const void *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, ulong*, int> InitializeHardwareKey;
    }
}