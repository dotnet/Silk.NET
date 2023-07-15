// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IColumnProvider.xml' path='doc/member[@name="IColumnProvider"]/*'/>
[Guid("E8025004-1C42-11D2-BE2C-00A0C9A83DA1")]
[NativeTypeName("struct IColumnProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IColumnProvider : IColumnProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IColumnProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IColumnProvider*, Guid*, void**, int> )(lpVtbl[0]))((IColumnProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IColumnProvider*, uint> )(lpVtbl[1]))((IColumnProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IColumnProvider*, uint> )(lpVtbl[2]))((IColumnProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IColumnProvider.xml' path='doc/member[@name="IColumnProvider.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("LPCSHCOLUMNINIT")] SHCOLUMNINIT* psci)
    {
        return ((delegate* unmanaged<IColumnProvider*, SHCOLUMNINIT*, int> )(lpVtbl[3]))((IColumnProvider*)Unsafe.AsPointer(ref this), psci);
    }

    /// <include file='IColumnProvider.xml' path='doc/member[@name="IColumnProvider.GetColumnInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetColumnInfo([NativeTypeName("DWORD")] uint dwIndex, SHCOLUMNINFO* psci)
    {
        return ((delegate* unmanaged<IColumnProvider*, uint, SHCOLUMNINFO*, int> )(lpVtbl[4]))((IColumnProvider*)Unsafe.AsPointer(ref this), dwIndex, psci);
    }

    /// <include file='IColumnProvider.xml' path='doc/member[@name="IColumnProvider.GetItemData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetItemData([NativeTypeName("LPCSHCOLUMNID")] PROPERTYKEY* pscid, [NativeTypeName("LPCSHCOLUMNDATA")] SHCOLUMNDATA* pscd, VARIANT* pvarData)
    {
        return ((delegate* unmanaged<IColumnProvider*, PROPERTYKEY*, SHCOLUMNDATA*, VARIANT*, int> )(lpVtbl[5]))((IColumnProvider*)Unsafe.AsPointer(ref this), pscid, pscd, pvarData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("LPCSHCOLUMNINIT")] SHCOLUMNINIT* psci);
        [VtblIndex(4)]
        HRESULT GetColumnInfo([NativeTypeName("DWORD")] uint dwIndex, SHCOLUMNINFO* psci);
        [VtblIndex(5)]
        HRESULT GetItemData([NativeTypeName("LPCSHCOLUMNID")] PROPERTYKEY* pscid, [NativeTypeName("LPCSHCOLUMNDATA")] SHCOLUMNDATA* pscd, VARIANT* pvarData);
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
        [NativeTypeName("HRESULT (LPCSHCOLUMNINIT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SHCOLUMNINIT*, int> Initialize;
        [NativeTypeName("HRESULT (DWORD, SHCOLUMNINFO *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SHCOLUMNINFO*, int> GetColumnInfo;
        [NativeTypeName("HRESULT (LPCSHCOLUMNID, LPCSHCOLUMNDATA, VARIANT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, SHCOLUMNDATA*, VARIANT*, int> GetItemData;
    }
}