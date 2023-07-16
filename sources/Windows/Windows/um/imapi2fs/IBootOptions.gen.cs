// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions"]/*'/>
[Guid("2C941FD4-975B-59BE-A960-9A2A262853A5")]
[NativeTypeName("struct IBootOptions : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IBootOptions : IBootOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBootOptions));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBootOptions*, Guid*, void**, int> )(lpVtbl[0]))((IBootOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBootOptions*, uint> )(lpVtbl[1]))((IBootOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBootOptions*, uint> )(lpVtbl[2]))((IBootOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IBootOptions*, uint*, int> )(lpVtbl[3]))((IBootOptions*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IBootOptions*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IBootOptions*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IBootOptions*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IBootOptions*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IBootOptions*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IBootOptions*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.get_BootImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BootImage(IStream** pVal)
    {
        return ((delegate* unmanaged<IBootOptions*, IStream**, int> )(lpVtbl[7]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.get_Manufacturer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Manufacturer([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IBootOptions*, ushort**, int> )(lpVtbl[8]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.put_Manufacturer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Manufacturer([NativeTypeName("BSTR")] ushort* newVal)
    {
        return ((delegate* unmanaged<IBootOptions*, ushort*, int> )(lpVtbl[9]))((IBootOptions*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.get_PlatformId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PlatformId(PlatformId* pVal)
    {
        return ((delegate* unmanaged<IBootOptions*, PlatformId*, int> )(lpVtbl[10]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.put_PlatformId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PlatformId(PlatformId newVal)
    {
        return ((delegate* unmanaged<IBootOptions*, PlatformId, int> )(lpVtbl[11]))((IBootOptions*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.get_Emulation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Emulation(EmulationType* pVal)
    {
        return ((delegate* unmanaged<IBootOptions*, EmulationType*, int> )(lpVtbl[12]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.put_Emulation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Emulation(EmulationType newVal)
    {
        return ((delegate* unmanaged<IBootOptions*, EmulationType, int> )(lpVtbl[13]))((IBootOptions*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.get_ImageSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ImageSize([NativeTypeName("ULONG *")] uint* pVal)
    {
        return ((delegate* unmanaged<IBootOptions*, uint*, int> )(lpVtbl[14]))((IBootOptions*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IBootOptions.xml' path='doc/member[@name="IBootOptions.AssignBootImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT AssignBootImage(IStream* newVal)
    {
        return ((delegate* unmanaged<IBootOptions*, IStream*, int> )(lpVtbl[15]))((IBootOptions*)Unsafe.AsPointer(ref this), newVal);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_BootImage(IStream** pVal);
        [VtblIndex(8)]
        HRESULT get_Manufacturer([NativeTypeName("BSTR *")] ushort** pVal);
        [VtblIndex(9)]
        HRESULT put_Manufacturer([NativeTypeName("BSTR")] ushort* newVal);
        [VtblIndex(10)]
        HRESULT get_PlatformId(PlatformId* pVal);
        [VtblIndex(11)]
        HRESULT put_PlatformId(PlatformId newVal);
        [VtblIndex(12)]
        HRESULT get_Emulation(EmulationType* pVal);
        [VtblIndex(13)]
        HRESULT put_Emulation(EmulationType newVal);
        [VtblIndex(14)]
        HRESULT get_ImageSize([NativeTypeName("ULONG *")] uint* pVal);
        [VtblIndex(15)]
        HRESULT AssignBootImage(IStream* newVal);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream**, int> get_BootImage;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Manufacturer;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Manufacturer;
        [NativeTypeName("HRESULT (PlatformId *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PlatformId*, int> get_PlatformId;
        [NativeTypeName("HRESULT (PlatformId) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PlatformId, int> put_PlatformId;
        [NativeTypeName("HRESULT (EmulationType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EmulationType*, int> get_Emulation;
        [NativeTypeName("HRESULT (EmulationType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EmulationType, int> put_Emulation;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ImageSize;
        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> AssignBootImage;
    }
}