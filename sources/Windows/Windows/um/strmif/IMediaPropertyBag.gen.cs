// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMediaPropertyBag.xml' path='doc/member[@name="IMediaPropertyBag"]/*'/>
[Guid("6025A880-C0D5-11D0-BD4E-00A0C911CE86")]
[NativeTypeName("struct IMediaPropertyBag : IPropertyBag")]
[NativeInheritance("IPropertyBag")]
public unsafe partial struct IMediaPropertyBag : IMediaPropertyBag.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPropertyBag));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPropertyBag*, Guid*, void**, int> )(lpVtbl[0]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaPropertyBag*, uint> )(lpVtbl[1]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPropertyBag*, uint> )(lpVtbl[2]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPropertyBag.Read"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar, IErrorLog* pErrorLog)
    {
        return ((delegate* unmanaged<IMediaPropertyBag*, ushort*, VARIANT*, IErrorLog*, int> )(lpVtbl[3]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar, pErrorLog);
    }

    /// <inheritdoc cref = "IPropertyBag.Write"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar)
    {
        return ((delegate* unmanaged<IMediaPropertyBag*, ushort*, VARIANT*, int> )(lpVtbl[4]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar);
    }

    /// <include file='IMediaPropertyBag.xml' path='doc/member[@name="IMediaPropertyBag.EnumProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumProperty([NativeTypeName("ULONG")] uint iProperty, VARIANT* pvarPropertyName, VARIANT* pvarPropertyValue)
    {
        return ((delegate* unmanaged<IMediaPropertyBag*, uint, VARIANT*, VARIANT*, int> )(lpVtbl[5]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), iProperty, pvarPropertyName, pvarPropertyValue);
    }

    public interface Interface : IPropertyBag.Interface
    {
        [VtblIndex(5)]
        HRESULT EnumProperty([NativeTypeName("ULONG")] uint iProperty, VARIANT* pvarPropertyName, VARIANT* pvarPropertyValue);
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
        [NativeTypeName("HRESULT (ULONG, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, VARIANT*, VARIANT*, int> EnumProperty;
    }
}