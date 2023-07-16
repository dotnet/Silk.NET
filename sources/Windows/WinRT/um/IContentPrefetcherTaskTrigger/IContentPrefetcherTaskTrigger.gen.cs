// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContentPrefetcherTaskTrigger.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IContentPrefetcherTaskTrigger.xml' path='doc/member[@name="IContentPrefetcherTaskTrigger"]/*'/>
[Guid("1B35A14A-6094-4799-A60E-E474E15D4DC9")]
[NativeTypeName("struct IContentPrefetcherTaskTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IContentPrefetcherTaskTrigger : IContentPrefetcherTaskTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContentPrefetcherTaskTrigger));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContentPrefetcherTaskTrigger*, Guid*, void**, int> )(lpVtbl[0]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContentPrefetcherTaskTrigger*, uint> )(lpVtbl[1]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContentPrefetcherTaskTrigger*, uint> )(lpVtbl[2]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IContentPrefetcherTaskTrigger*, uint*, Guid**, int> )(lpVtbl[3]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContentPrefetcherTaskTrigger*, HSTRING*, int> )(lpVtbl[4]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContentPrefetcherTaskTrigger*, TrustLevel*, int> )(lpVtbl[5]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContentPrefetcherTaskTrigger.xml' path='doc/member[@name="IContentPrefetcherTaskTrigger.TriggerContentPrefetcherTask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TriggerContentPrefetcherTask([NativeTypeName("LPCWSTR")] ushort* packageFullName)
    {
        return ((delegate* unmanaged<IContentPrefetcherTaskTrigger*, ushort*, int> )(lpVtbl[6]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), packageFullName);
    }

    /// <include file='IContentPrefetcherTaskTrigger.xml' path='doc/member[@name="IContentPrefetcherTaskTrigger.IsRegisteredForContentPrefetch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsRegisteredForContentPrefetch([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("boolean *")] byte* isRegistered)
    {
        return ((delegate* unmanaged<IContentPrefetcherTaskTrigger*, ushort*, byte*, int> )(lpVtbl[7]))((IContentPrefetcherTaskTrigger*)Unsafe.AsPointer(ref this), packageFullName, isRegistered);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TriggerContentPrefetcherTask([NativeTypeName("LPCWSTR")] ushort* packageFullName);
        [VtblIndex(7)]
        HRESULT IsRegisteredForContentPrefetch([NativeTypeName("LPCWSTR")] ushort* packageFullName, [NativeTypeName("boolean *")] byte* isRegistered);
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
        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;
        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;
        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> TriggerContentPrefetcherTask;
        [NativeTypeName("HRESULT (LPCWSTR, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, int> IsRegisteredForContentPrefetch;
    }
}