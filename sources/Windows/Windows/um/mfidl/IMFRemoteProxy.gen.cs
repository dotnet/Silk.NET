// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFRemoteProxy.xml' path='doc/member[@name="IMFRemoteProxy"]/*'/>
[Guid("994E23AD-1CC2-493C-B9FA-46F1CB040FA4")]
[NativeTypeName("struct IMFRemoteProxy : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRemoteProxy : IMFRemoteProxy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRemoteProxy));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRemoteProxy*, Guid*, void**, int> )(lpVtbl[0]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFRemoteProxy*, uint> )(lpVtbl[1]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRemoteProxy*, uint> )(lpVtbl[2]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFRemoteProxy.xml' path='doc/member[@name="IMFRemoteProxy.GetRemoteObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRemoteObject([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IMFRemoteProxy*, Guid*, void**, int> )(lpVtbl[3]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='IMFRemoteProxy.xml' path='doc/member[@name="IMFRemoteProxy.GetRemoteHost"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRemoteHost([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IMFRemoteProxy*, Guid*, void**, int> )(lpVtbl[4]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRemoteObject([NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(4)]
        HRESULT GetRemoteHost([NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetRemoteObject;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetRemoteHost;
    }
}