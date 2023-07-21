// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHandlerActivationHost.xml' path='doc/member[@name="IHandlerActivationHost"]/*' />
[Guid("35094A87-8BB1-4237-96C6-C417EEBDB078")]
[NativeTypeName("struct IHandlerActivationHost : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHandlerActivationHost : IHandlerActivationHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHandlerActivationHost));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHandlerActivationHost*, Guid*, void**, int>)(lpVtbl[0]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHandlerActivationHost*, uint>)(lpVtbl[1]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHandlerActivationHost*, uint>)(lpVtbl[2]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHandlerActivationHost.xml' path='doc/member[@name="IHandlerActivationHost.BeforeCoCreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeforeCoCreateInstance([NativeTypeName("const IID &")] Guid* clsidHandler, IShellItemArray* itemsBeingActivated, IHandlerInfo* handlerInfo)
    {
        return ((delegate* unmanaged<IHandlerActivationHost*, Guid*, IShellItemArray*, IHandlerInfo*, int>)(lpVtbl[3]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this), clsidHandler, itemsBeingActivated, handlerInfo);
    }

    /// <include file='IHandlerActivationHost.xml' path='doc/member[@name="IHandlerActivationHost.BeforeCreateProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeforeCreateProcess([NativeTypeName("LPCWSTR")] ushort* applicationPath, [NativeTypeName("LPCWSTR")] ushort* commandLine, IHandlerInfo* handlerInfo)
    {
        return ((delegate* unmanaged<IHandlerActivationHost*, ushort*, ushort*, IHandlerInfo*, int>)(lpVtbl[4]))((IHandlerActivationHost*)Unsafe.AsPointer(ref this), applicationPath, commandLine, handlerInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeforeCoCreateInstance([NativeTypeName("const IID &")] Guid* clsidHandler, IShellItemArray* itemsBeingActivated, IHandlerInfo* handlerInfo);

        [VtblIndex(4)]
        HRESULT BeforeCreateProcess([NativeTypeName("LPCWSTR")] ushort* applicationPath, [NativeTypeName("LPCWSTR")] ushort* commandLine, IHandlerInfo* handlerInfo);
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

        [NativeTypeName("HRESULT (const IID &, IShellItemArray *, IHandlerInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IShellItemArray*, IHandlerInfo*, int> BeforeCoCreateInstance;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IHandlerInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IHandlerInfo*, int> BeforeCreateProcess;
    }
}
