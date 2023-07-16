// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpResourceManager.xml' path='doc/member[@name="ISpResourceManager"]/*'/>
[Guid("93384E18-5014-43D5-ADBB-A78E055926BD")]
[NativeTypeName("struct ISpResourceManager : IServiceProvider")]
[NativeInheritance("IServiceProvider")]
public unsafe partial struct ISpResourceManager : ISpResourceManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpResourceManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpResourceManager*, Guid*, void**, int> )(lpVtbl[0]))((ISpResourceManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpResourceManager*, uint> )(lpVtbl[1]))((ISpResourceManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpResourceManager*, uint> )(lpVtbl[2]))((ISpResourceManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IServiceProvider.QueryService"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryService([NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpResourceManager*, Guid*, Guid*, void**, int> )(lpVtbl[3]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidService, riid, ppvObject);
    }

    /// <include file='ISpResourceManager.xml' path='doc/member[@name="ISpResourceManager.SetObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetObject([NativeTypeName("const GUID &")] Guid* guidServiceId, IUnknown* pUnkObject)
    {
        return ((delegate* unmanaged<ISpResourceManager*, Guid*, IUnknown*, int> )(lpVtbl[4]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidServiceId, pUnkObject);
    }

    /// <include file='ISpResourceManager.xml' path='doc/member[@name="ISpResourceManager.GetObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetObject([NativeTypeName("const GUID &")] Guid* guidServiceId, [NativeTypeName("const IID &")] Guid* ObjectCLSID, [NativeTypeName("const IID &")] Guid* ObjectIID, BOOL fReleaseWhenLastExternalRefReleased, void** ppObject)
    {
        return ((delegate* unmanaged<ISpResourceManager*, Guid*, Guid*, Guid*, BOOL, void**, int> )(lpVtbl[5]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidServiceId, ObjectCLSID, ObjectIID, fReleaseWhenLastExternalRefReleased, ppObject);
    }

    public interface Interface : IServiceProvider.Interface
    {
        [VtblIndex(4)]
        HRESULT SetObject([NativeTypeName("const GUID &")] Guid* guidServiceId, IUnknown* pUnkObject);
        [VtblIndex(5)]
        HRESULT GetObject([NativeTypeName("const GUID &")] Guid* guidServiceId, [NativeTypeName("const IID &")] Guid* ObjectCLSID, [NativeTypeName("const IID &")] Guid* ObjectIID, BOOL fReleaseWhenLastExternalRefReleased, void** ppObject);
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
        [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> QueryService;
        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetObject;
        [NativeTypeName("HRESULT (const GUID &, const IID &, const IID &, BOOL, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, Guid*, BOOL, void**, int> GetObject;
    }
}