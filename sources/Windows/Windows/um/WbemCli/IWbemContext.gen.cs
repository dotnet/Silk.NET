// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext"]/*'/>
[Guid("44ACA674-E8FC-11D0-A07C-00C04FB68820")]
[NativeTypeName("struct IWbemContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemContext : IWbemContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemContext));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemContext*, Guid*, void**, int> )(lpVtbl[0]))((IWbemContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemContext*, uint> )(lpVtbl[1]))((IWbemContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemContext*, uint> )(lpVtbl[2]))((IWbemContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IWbemContext** ppNewCopy)
    {
        return ((delegate* unmanaged<IWbemContext*, IWbemContext**, int> )(lpVtbl[3]))((IWbemContext*)Unsafe.AsPointer(ref this), ppNewCopy);
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.GetNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNames([NativeTypeName("long")] int lFlags, SAFEARRAY** pNames)
    {
        return ((delegate* unmanaged<IWbemContext*, int, SAFEARRAY**, int> )(lpVtbl[4]))((IWbemContext*)Unsafe.AsPointer(ref this), lFlags, pNames);
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.BeginEnumeration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginEnumeration([NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemContext*, int, int> )(lpVtbl[5]))((IWbemContext*)Unsafe.AsPointer(ref this), lFlags);
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IWbemContext*, int, ushort**, VARIANT*, int> )(lpVtbl[6]))((IWbemContext*)Unsafe.AsPointer(ref this), lFlags, pstrName, pValue);
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.EndEnumeration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EndEnumeration()
    {
        return ((delegate* unmanaged<IWbemContext*, int> )(lpVtbl[7]))((IWbemContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.SetValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IWbemContext*, ushort*, int, VARIANT*, int> )(lpVtbl[8]))((IWbemContext*)Unsafe.AsPointer(ref this), wszName, lFlags, pValue);
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.GetValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IWbemContext*, ushort*, int, VARIANT*, int> )(lpVtbl[9]))((IWbemContext*)Unsafe.AsPointer(ref this), wszName, lFlags, pValue);
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.DeleteValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemContext*, ushort*, int, int> )(lpVtbl[10]))((IWbemContext*)Unsafe.AsPointer(ref this), wszName, lFlags);
    }

    /// <include file='IWbemContext.xml' path='doc/member[@name="IWbemContext.DeleteAll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteAll()
    {
        return ((delegate* unmanaged<IWbemContext*, int> )(lpVtbl[11]))((IWbemContext*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IWbemContext** ppNewCopy);
        [VtblIndex(4)]
        HRESULT GetNames([NativeTypeName("long")] int lFlags, SAFEARRAY** pNames);
        [VtblIndex(5)]
        HRESULT BeginEnumeration([NativeTypeName("long")] int lFlags);
        [VtblIndex(6)]
        HRESULT Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, VARIANT* pValue);
        [VtblIndex(7)]
        HRESULT EndEnumeration();
        [VtblIndex(8)]
        HRESULT SetValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pValue);
        [VtblIndex(9)]
        HRESULT GetValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pValue);
        [VtblIndex(10)]
        HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags);
        [VtblIndex(11)]
        HRESULT DeleteAll();
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
        [NativeTypeName("HRESULT (IWbemContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWbemContext**, int> Clone;
        [NativeTypeName("HRESULT (long, SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, SAFEARRAY**, int> GetNames;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> BeginEnumeration;
        [NativeTypeName("HRESULT (long, BSTR *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, VARIANT*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndEnumeration;
        [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int> SetValue;
        [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int> GetValue;
        [NativeTypeName("HRESULT (LPCWSTR, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> DeleteValue;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DeleteAll;
    }
}