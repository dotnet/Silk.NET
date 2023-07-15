// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPropertyBag.xml' path='doc/member[@name="IPropertyBag"]/*'/>
[Guid("55272A00-42CB-11CE-8135-00AA004BB851")]
[NativeTypeName("struct IPropertyBag : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyBag : IPropertyBag.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyBag));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyBag*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyBag*, uint> )(lpVtbl[1]))((IPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyBag*, uint> )(lpVtbl[2]))((IPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyBag.xml' path='doc/member[@name="IPropertyBag.Read"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar, IErrorLog* pErrorLog)
    {
        return ((delegate* unmanaged<IPropertyBag*, ushort*, VARIANT*, IErrorLog*, int> )(lpVtbl[3]))((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar, pErrorLog);
    }

    /// <include file='IPropertyBag.xml' path='doc/member[@name="IPropertyBag.Write"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar)
    {
        return ((delegate* unmanaged<IPropertyBag*, ushort*, VARIANT*, int> )(lpVtbl[4]))((IPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar, IErrorLog* pErrorLog);
        [VtblIndex(4)]
        HRESULT Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar);
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
        [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *, IErrorLog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, IErrorLog*, int> Read;
        [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> Write;
    }
}