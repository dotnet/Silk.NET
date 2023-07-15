// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDataObjectProvider.xml' path='doc/member[@name="IDataObjectProvider"]/*'/>
[Guid("3D25F6D6-4B2A-433C-9184-7C33AD35D001")]
[NativeTypeName("struct IDataObjectProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDataObjectProvider : IDataObjectProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataObjectProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataObjectProvider*, Guid*, void**, int> )(lpVtbl[0]))((IDataObjectProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDataObjectProvider*, uint> )(lpVtbl[1]))((IDataObjectProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataObjectProvider*, uint> )(lpVtbl[2]))((IDataObjectProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDataObjectProvider.xml' path='doc/member[@name="IDataObjectProvider.GetDataObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDataObject(IDataObject** dataObject)
    {
        return ((delegate* unmanaged<IDataObjectProvider*, IDataObject**, int> )(lpVtbl[3]))((IDataObjectProvider*)Unsafe.AsPointer(ref this), dataObject);
    }

    /// <include file='IDataObjectProvider.xml' path='doc/member[@name="IDataObjectProvider.SetDataObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDataObject(IDataObject* dataObject)
    {
        return ((delegate* unmanaged<IDataObjectProvider*, IDataObject*, int> )(lpVtbl[4]))((IDataObjectProvider*)Unsafe.AsPointer(ref this), dataObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDataObject(IDataObject** dataObject);
        [VtblIndex(4)]
        HRESULT SetDataObject(IDataObject* dataObject);
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
        [NativeTypeName("HRESULT (IDataObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject**, int> GetDataObject;
        [NativeTypeName("HRESULT (IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, int> SetDataObject;
    }
}