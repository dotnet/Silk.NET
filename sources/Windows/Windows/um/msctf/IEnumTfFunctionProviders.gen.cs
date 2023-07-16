// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IEnumTfFunctionProviders.xml' path='doc/member[@name="IEnumTfFunctionProviders"]/*'/>
[Guid("E4B24DB0-0990-11D3-8DF0-00105A2799B5")]
[NativeTypeName("struct IEnumTfFunctionProviders : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfFunctionProviders : IEnumTfFunctionProviders.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfFunctionProviders));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTfFunctionProviders*, Guid*, void**, int> )(lpVtbl[0]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint> )(lpVtbl[1]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint> )(lpVtbl[2]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfFunctionProviders.xml' path='doc/member[@name="IEnumTfFunctionProviders.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfFunctionProviders** ppEnum)
    {
        return ((delegate* unmanaged<IEnumTfFunctionProviders*, IEnumTfFunctionProviders**, int> )(lpVtbl[3]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumTfFunctionProviders.xml' path='doc/member[@name="IEnumTfFunctionProviders.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfFunctionProvider** ppCmdobj, [NativeTypeName("ULONG *")] uint* pcFetch)
    {
        return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint, ITfFunctionProvider**, uint*, int> )(lpVtbl[4]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ulCount, ppCmdobj, pcFetch);
    }

    /// <include file='IEnumTfFunctionProviders.xml' path='doc/member[@name="IEnumTfFunctionProviders.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfFunctionProviders*, int> )(lpVtbl[5]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumTfFunctionProviders.xml' path='doc/member[@name="IEnumTfFunctionProviders.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint, int> )(lpVtbl[6]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfFunctionProviders** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfFunctionProvider** ppCmdobj, [NativeTypeName("ULONG *")] uint* pcFetch);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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
        [NativeTypeName("HRESULT (IEnumTfFunctionProviders **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfFunctionProviders**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, ITfFunctionProvider **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfFunctionProvider**, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}