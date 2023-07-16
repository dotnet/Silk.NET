// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IErrorLog.xml' path='doc/member[@name="IErrorLog"]/*'/>
[Guid("3127CA40-446E-11CE-8135-00AA004BB851")]
[NativeTypeName("struct IErrorLog : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IErrorLog : IErrorLog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IErrorLog));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IErrorLog*, Guid*, void**, int> )(lpVtbl[0]))((IErrorLog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IErrorLog*, uint> )(lpVtbl[1]))((IErrorLog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IErrorLog*, uint> )(lpVtbl[2]))((IErrorLog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IErrorLog.xml' path='doc/member[@name="IErrorLog.AddError"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddError([NativeTypeName("LPCOLESTR")] ushort* pszPropName, EXCEPINFO* pExcepInfo)
    {
        return ((delegate* unmanaged<IErrorLog*, ushort*, EXCEPINFO*, int> )(lpVtbl[3]))((IErrorLog*)Unsafe.AsPointer(ref this), pszPropName, pExcepInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddError([NativeTypeName("LPCOLESTR")] ushort* pszPropName, EXCEPINFO* pExcepInfo);
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
        [NativeTypeName("HRESULT (LPCOLESTR, EXCEPINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, EXCEPINFO*, int> AddError;
    }
}