// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IApplicationActivationManager.xml' path='doc/member[@name="IApplicationActivationManager"]/*' />
[Guid("2E941141-7F97-4756-BA1D-9DECDE894A3D")]
[NativeTypeName("struct IApplicationActivationManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationActivationManager : IApplicationActivationManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationActivationManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationActivationManager*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationActivationManager*, uint>)(lpVtbl[1]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationActivationManager*, uint>)(lpVtbl[2]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationActivationManager.xml' path='doc/member[@name="IApplicationActivationManager.ActivateApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ActivateApplication([NativeTypeName("LPCWSTR")] ushort* appUserModelId, [NativeTypeName("LPCWSTR")] ushort* arguments, ACTIVATEOPTIONS options, [NativeTypeName("DWORD *")] uint* processId)
    {
        return ((delegate* unmanaged<IApplicationActivationManager*, ushort*, ushort*, ACTIVATEOPTIONS, uint*, int>)(lpVtbl[3]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this), appUserModelId, arguments, options, processId);
    }

    /// <include file='IApplicationActivationManager.xml' path='doc/member[@name="IApplicationActivationManager.ActivateForFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ActivateForFile([NativeTypeName("LPCWSTR")] ushort* appUserModelId, IShellItemArray* itemArray, [NativeTypeName("LPCWSTR")] ushort* verb, [NativeTypeName("DWORD *")] uint* processId)
    {
        return ((delegate* unmanaged<IApplicationActivationManager*, ushort*, IShellItemArray*, ushort*, uint*, int>)(lpVtbl[4]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this), appUserModelId, itemArray, verb, processId);
    }

    /// <include file='IApplicationActivationManager.xml' path='doc/member[@name="IApplicationActivationManager.ActivateForProtocol"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ActivateForProtocol([NativeTypeName("LPCWSTR")] ushort* appUserModelId, IShellItemArray* itemArray, [NativeTypeName("DWORD *")] uint* processId)
    {
        return ((delegate* unmanaged<IApplicationActivationManager*, ushort*, IShellItemArray*, uint*, int>)(lpVtbl[5]))((IApplicationActivationManager*)Unsafe.AsPointer(ref this), appUserModelId, itemArray, processId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ActivateApplication([NativeTypeName("LPCWSTR")] ushort* appUserModelId, [NativeTypeName("LPCWSTR")] ushort* arguments, ACTIVATEOPTIONS options, [NativeTypeName("DWORD *")] uint* processId);

        [VtblIndex(4)]
        HRESULT ActivateForFile([NativeTypeName("LPCWSTR")] ushort* appUserModelId, IShellItemArray* itemArray, [NativeTypeName("LPCWSTR")] ushort* verb, [NativeTypeName("DWORD *")] uint* processId);

        [VtblIndex(5)]
        HRESULT ActivateForProtocol([NativeTypeName("LPCWSTR")] ushort* appUserModelId, IShellItemArray* itemArray, [NativeTypeName("DWORD *")] uint* processId);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, ACTIVATEOPTIONS, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ACTIVATEOPTIONS, uint*, int> ActivateApplication;

        [NativeTypeName("HRESULT (LPCWSTR, IShellItemArray *, LPCWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IShellItemArray*, ushort*, uint*, int> ActivateForFile;

        [NativeTypeName("HRESULT (LPCWSTR, IShellItemArray *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IShellItemArray*, uint*, int> ActivateForProtocol;
    }
}
