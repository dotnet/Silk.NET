// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDirectManipulationUpdateManager.xml' path='doc/member[@name="IDirectManipulationUpdateManager"]/*'/>
[Guid("B0AE62FD-BE34-46E7-9CAA-D361FACBB9CC")]
[NativeTypeName("struct IDirectManipulationUpdateManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationUpdateManager : IDirectManipulationUpdateManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationUpdateManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateManager*, Guid*, void**, int> )(lpVtbl[0]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateManager*, uint> )(lpVtbl[1]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateManager*, uint> )(lpVtbl[2]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationUpdateManager.xml' path='doc/member[@name="IDirectManipulationUpdateManager.RegisterWaitHandleCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterWaitHandleCallback(HANDLE handle, IDirectManipulationUpdateHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateManager*, HANDLE, IDirectManipulationUpdateHandler*, uint*, int> )(lpVtbl[3]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), handle, eventHandler, cookie);
    }

    /// <include file='IDirectManipulationUpdateManager.xml' path='doc/member[@name="IDirectManipulationUpdateManager.UnregisterWaitHandleCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterWaitHandleCallback([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateManager*, uint, int> )(lpVtbl[4]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IDirectManipulationUpdateManager.xml' path='doc/member[@name="IDirectManipulationUpdateManager.Update"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Update(IDirectManipulationFrameInfoProvider* frameInfo)
    {
        return ((delegate* unmanaged<IDirectManipulationUpdateManager*, IDirectManipulationFrameInfoProvider*, int> )(lpVtbl[5]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), frameInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterWaitHandleCallback(HANDLE handle, IDirectManipulationUpdateHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie);
        [VtblIndex(4)]
        HRESULT UnregisterWaitHandleCallback([NativeTypeName("DWORD")] uint cookie);
        [VtblIndex(5)]
        HRESULT Update(IDirectManipulationFrameInfoProvider* frameInfo);
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
        [NativeTypeName("HRESULT (HANDLE, IDirectManipulationUpdateHandler *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, IDirectManipulationUpdateHandler*, uint*, int> RegisterWaitHandleCallback;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnregisterWaitHandleCallback;
        [NativeTypeName("HRESULT (IDirectManipulationFrameInfoProvider *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationFrameInfoProvider*, int> Update;
    }
}