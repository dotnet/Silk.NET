// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISurrogateService.xml' path='doc/member[@name="ISurrogateService"]/*'/>
[Guid("000001D4-0000-0000-C000-000000000046")]
[NativeTypeName("struct ISurrogateService : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISurrogateService : ISurrogateService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISurrogateService));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISurrogateService*, Guid*, void**, int> )(lpVtbl[0]))((ISurrogateService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISurrogateService*, uint> )(lpVtbl[1]))((ISurrogateService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISurrogateService*, uint> )(lpVtbl[2]))((ISurrogateService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISurrogateService.xml' path='doc/member[@name="ISurrogateService.Init"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Init([NativeTypeName("const GUID &")] Guid* rguidProcessID, IProcessLock* pProcessLock, BOOL* pfApplicationAware)
    {
        return ((delegate* unmanaged<ISurrogateService*, Guid*, IProcessLock*, BOOL*, int> )(lpVtbl[3]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidProcessID, pProcessLock, pfApplicationAware);
    }

    /// <include file='ISurrogateService.xml' path='doc/member[@name="ISurrogateService.ApplicationLaunch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ApplicationLaunch([NativeTypeName("const GUID &")] Guid* rguidApplID, ApplicationType appType)
    {
        return ((delegate* unmanaged<ISurrogateService*, Guid*, ApplicationType, int> )(lpVtbl[4]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID, appType);
    }

    /// <include file='ISurrogateService.xml' path='doc/member[@name="ISurrogateService.ApplicationFree"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ApplicationFree([NativeTypeName("const GUID &")] Guid* rguidApplID)
    {
        return ((delegate* unmanaged<ISurrogateService*, Guid*, int> )(lpVtbl[5]))((ISurrogateService*)Unsafe.AsPointer(ref this), rguidApplID);
    }

    /// <include file='ISurrogateService.xml' path='doc/member[@name="ISurrogateService.CatalogRefresh"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CatalogRefresh([NativeTypeName("ULONG")] uint ulReserved)
    {
        return ((delegate* unmanaged<ISurrogateService*, uint, int> )(lpVtbl[6]))((ISurrogateService*)Unsafe.AsPointer(ref this), ulReserved);
    }

    /// <include file='ISurrogateService.xml' path='doc/member[@name="ISurrogateService.ProcessShutdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ProcessShutdown(ShutdownType shutdownType)
    {
        return ((delegate* unmanaged<ISurrogateService*, ShutdownType, int> )(lpVtbl[7]))((ISurrogateService*)Unsafe.AsPointer(ref this), shutdownType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Init([NativeTypeName("const GUID &")] Guid* rguidProcessID, IProcessLock* pProcessLock, BOOL* pfApplicationAware);
        [VtblIndex(4)]
        HRESULT ApplicationLaunch([NativeTypeName("const GUID &")] Guid* rguidApplID, ApplicationType appType);
        [VtblIndex(5)]
        HRESULT ApplicationFree([NativeTypeName("const GUID &")] Guid* rguidApplID);
        [VtblIndex(6)]
        HRESULT CatalogRefresh([NativeTypeName("ULONG")] uint ulReserved);
        [VtblIndex(7)]
        HRESULT ProcessShutdown(ShutdownType shutdownType);
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
        [NativeTypeName("HRESULT (const GUID &, IProcessLock *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IProcessLock*, BOOL*, int> Init;
        [NativeTypeName("HRESULT (const GUID &, ApplicationType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ApplicationType, int> ApplicationLaunch;
        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> ApplicationFree;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CatalogRefresh;
        [NativeTypeName("HRESULT (ShutdownType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ShutdownType, int> ProcessShutdown;
    }
}