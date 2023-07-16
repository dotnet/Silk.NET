// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFDeviceTransformCallback.xml' path='doc/member[@name="IMFDeviceTransformCallback"]/*'/>
[Guid("6D5CB646-29EC-41FB-8179-8C4C6D750811")]
[NativeTypeName("struct IMFDeviceTransformCallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.17134.0")]
public unsafe partial struct IMFDeviceTransformCallback : IMFDeviceTransformCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFDeviceTransformCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDeviceTransformCallback*, Guid*, void**, int> )(lpVtbl[0]))((IMFDeviceTransformCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFDeviceTransformCallback*, uint> )(lpVtbl[1]))((IMFDeviceTransformCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDeviceTransformCallback*, uint> )(lpVtbl[2]))((IMFDeviceTransformCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFDeviceTransformCallback.xml' path='doc/member[@name="IMFDeviceTransformCallback.OnBufferSent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnBufferSent(IMFAttributes* pCallbackAttributes, [NativeTypeName("DWORD")] uint pinId)
    {
        return ((delegate* unmanaged<IMFDeviceTransformCallback*, IMFAttributes*, uint, int> )(lpVtbl[3]))((IMFDeviceTransformCallback*)Unsafe.AsPointer(ref this), pCallbackAttributes, pinId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnBufferSent(IMFAttributes* pCallbackAttributes, [NativeTypeName("DWORD")] uint pinId);
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
        [NativeTypeName("HRESULT (IMFAttributes *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, uint, int> OnBufferSent;
    }
}