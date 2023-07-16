// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMultisessionSequential2.xml' path='doc/member[@name="IMultisessionSequential2"]/*'/>
[Guid("B507CA22-2204-11DD-966A-001AA01BBC58")]
[NativeTypeName("struct IMultisessionSequential2 : IMultisessionSequential")]
[NativeInheritance("IMultisessionSequential")]
public unsafe partial struct IMultisessionSequential2 : IMultisessionSequential2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMultisessionSequential2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, Guid*, void**, int> )(lpVtbl[0]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, uint> )(lpVtbl[1]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, uint> )(lpVtbl[2]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, uint*, int> )(lpVtbl[3]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IMultisession.get_IsSupportedOnCurrentMediaState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsSupportedOnCurrentMediaState([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, short*, int> )(lpVtbl[7]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IMultisession.put_InUse"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_InUse([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, short, int> )(lpVtbl[8]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IMultisession.get_InUse"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InUse([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, short*, int> )(lpVtbl[9]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IMultisession.get_ImportRecorder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ImportRecorder(IDiscRecorder2** value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, IDiscRecorder2**, int> )(lpVtbl[10]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IMultisessionSequential.get_IsFirstDataSession"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsFirstDataSession([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, short*, int> )(lpVtbl[11]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IMultisessionSequential.get_StartAddressOfPreviousSession"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_StartAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, int*, int> )(lpVtbl[12]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IMultisessionSequential.get_LastWrittenAddressOfPreviousSession"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LastWrittenAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, int*, int> )(lpVtbl[13]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IMultisessionSequential.get_NextWritableAddress"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_NextWritableAddress([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, int*, int> )(lpVtbl[14]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IMultisessionSequential.get_FreeSectorsOnMedia"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, int*, int> )(lpVtbl[15]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMultisessionSequential2.xml' path='doc/member[@name="IMultisessionSequential2.get_WriteUnitSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_WriteUnitSize([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential2*, int*, int> )(lpVtbl[16]))((IMultisessionSequential2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IMultisessionSequential.Interface
    {
        [VtblIndex(16)]
        HRESULT get_WriteUnitSize([NativeTypeName("LONG *")] int* value);
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
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsSupportedOnCurrentMediaState;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_InUse;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_InUse;
        [NativeTypeName("HRESULT (IDiscRecorder2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2**, int> get_ImportRecorder;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsFirstDataSession;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartAddressOfPreviousSession;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastWrittenAddressOfPreviousSession;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NextWritableAddress;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FreeSectorsOnMedia;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_WriteUnitSize;
    }
}