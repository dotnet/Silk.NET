// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPropertyChangeArray.xml' path='doc/member[@name="IPropertyChangeArray"]/*'/>
[Guid("380F5CAD-1B5E-42F2-805D-637FD392D31E")]
[NativeTypeName("struct IPropertyChangeArray : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyChangeArray : IPropertyChangeArray.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyChangeArray));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, uint> )(lpVtbl[1]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, uint> )(lpVtbl[2]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyChangeArray.xml' path='doc/member[@name="IPropertyChangeArray.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* pcOperations)
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, uint*, int> )(lpVtbl[3]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), pcOperations);
    }

    /// <include file='IPropertyChangeArray.xml' path='doc/member[@name="IPropertyChangeArray.GetAt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAt(uint iIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, uint, Guid*, void**, int> )(lpVtbl[4]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), iIndex, riid, ppv);
    }

    /// <include file='IPropertyChangeArray.xml' path='doc/member[@name="IPropertyChangeArray.InsertAt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InsertAt(uint iIndex, IPropertyChange* ppropChange)
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, uint, IPropertyChange*, int> )(lpVtbl[5]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), iIndex, ppropChange);
    }

    /// <include file='IPropertyChangeArray.xml' path='doc/member[@name="IPropertyChangeArray.Append"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Append(IPropertyChange* ppropChange)
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, IPropertyChange*, int> )(lpVtbl[6]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), ppropChange);
    }

    /// <include file='IPropertyChangeArray.xml' path='doc/member[@name="IPropertyChangeArray.AppendOrReplace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AppendOrReplace(IPropertyChange* ppropChange)
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, IPropertyChange*, int> )(lpVtbl[7]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), ppropChange);
    }

    /// <include file='IPropertyChangeArray.xml' path='doc/member[@name="IPropertyChangeArray.RemoveAt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveAt(uint iIndex)
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, uint, int> )(lpVtbl[8]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), iIndex);
    }

    /// <include file='IPropertyChangeArray.xml' path='doc/member[@name="IPropertyChangeArray.IsKeyInArray"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsKeyInArray([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyChangeArray*, PROPERTYKEY*, int> )(lpVtbl[9]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), key);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(uint* pcOperations);
        [VtblIndex(4)]
        HRESULT GetAt(uint iIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(5)]
        HRESULT InsertAt(uint iIndex, IPropertyChange* ppropChange);
        [VtblIndex(6)]
        HRESULT Append(IPropertyChange* ppropChange);
        [VtblIndex(7)]
        HRESULT AppendOrReplace(IPropertyChange* ppropChange);
        [VtblIndex(8)]
        HRESULT RemoveAt(uint iIndex);
        [VtblIndex(9)]
        HRESULT IsKeyInArray([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;
        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetAt;
        [NativeTypeName("HRESULT (UINT, IPropertyChange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertyChange*, int> InsertAt;
        [NativeTypeName("HRESULT (IPropertyChange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyChange*, int> Append;
        [NativeTypeName("HRESULT (IPropertyChange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyChange*, int> AppendOrReplace;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveAt;
        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> IsKeyInArray;
    }
}