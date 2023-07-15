// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfClientId.xml' path='doc/member[@name="ITfClientId"]/*'/>
[Guid("D60A7B49-1B9F-4BE2-B702-47E9DC05DEC3")]
[NativeTypeName("struct ITfClientId : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfClientId : ITfClientId.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfClientId));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfClientId*, Guid*, void**, int> )(lpVtbl[0]))((ITfClientId*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfClientId*, uint> )(lpVtbl[1]))((ITfClientId*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfClientId*, uint> )(lpVtbl[2]))((ITfClientId*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfClientId.xml' path='doc/member[@name="ITfClientId.GetClientId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClientId([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("TfClientId *")] uint* ptid)
    {
        return ((delegate* unmanaged<ITfClientId*, Guid*, uint*, int> )(lpVtbl[3]))((ITfClientId*)Unsafe.AsPointer(ref this), rclsid, ptid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetClientId([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("TfClientId *")] uint* ptid);
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
        [NativeTypeName("HRESULT (const IID &, TfClientId *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetClientId;
    }
}