// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition"]/*'/>
[Guid("56A868B2-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaPosition : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IMediaPosition : IMediaPosition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPosition));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPosition*, Guid*, void**, int> )(lpVtbl[0]))((IMediaPosition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaPosition*, uint> )(lpVtbl[1]))((IMediaPosition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPosition*, uint> )(lpVtbl[2]))((IMediaPosition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IMediaPosition*, uint*, int> )(lpVtbl[3]))((IMediaPosition*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IMediaPosition*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IMediaPosition*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IMediaPosition*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IMediaPosition*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IMediaPosition*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IMediaPosition*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.get_Duration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Duration([NativeTypeName("REFTIME *")] double* plength)
    {
        return ((delegate* unmanaged<IMediaPosition*, double*, int> )(lpVtbl[7]))((IMediaPosition*)Unsafe.AsPointer(ref this), plength);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.put_CurrentPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CurrentPosition([NativeTypeName("REFTIME")] double llTime)
    {
        return ((delegate* unmanaged<IMediaPosition*, double, int> )(lpVtbl[8]))((IMediaPosition*)Unsafe.AsPointer(ref this), llTime);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.get_CurrentPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CurrentPosition([NativeTypeName("REFTIME *")] double* pllTime)
    {
        return ((delegate* unmanaged<IMediaPosition*, double*, int> )(lpVtbl[9]))((IMediaPosition*)Unsafe.AsPointer(ref this), pllTime);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.get_StopTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_StopTime([NativeTypeName("REFTIME *")] double* pllTime)
    {
        return ((delegate* unmanaged<IMediaPosition*, double*, int> )(lpVtbl[10]))((IMediaPosition*)Unsafe.AsPointer(ref this), pllTime);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.put_StopTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_StopTime([NativeTypeName("REFTIME")] double llTime)
    {
        return ((delegate* unmanaged<IMediaPosition*, double, int> )(lpVtbl[11]))((IMediaPosition*)Unsafe.AsPointer(ref this), llTime);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.get_PrerollTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PrerollTime([NativeTypeName("REFTIME *")] double* pllTime)
    {
        return ((delegate* unmanaged<IMediaPosition*, double*, int> )(lpVtbl[12]))((IMediaPosition*)Unsafe.AsPointer(ref this), pllTime);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.put_PrerollTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PrerollTime([NativeTypeName("REFTIME")] double llTime)
    {
        return ((delegate* unmanaged<IMediaPosition*, double, int> )(lpVtbl[13]))((IMediaPosition*)Unsafe.AsPointer(ref this), llTime);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.put_Rate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Rate(double dRate)
    {
        return ((delegate* unmanaged<IMediaPosition*, double, int> )(lpVtbl[14]))((IMediaPosition*)Unsafe.AsPointer(ref this), dRate);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.get_Rate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Rate(double* pdRate)
    {
        return ((delegate* unmanaged<IMediaPosition*, double*, int> )(lpVtbl[15]))((IMediaPosition*)Unsafe.AsPointer(ref this), pdRate);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.CanSeekForward"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CanSeekForward([NativeTypeName("LONG *")] int* pCanSeekForward)
    {
        return ((delegate* unmanaged<IMediaPosition*, int*, int> )(lpVtbl[16]))((IMediaPosition*)Unsafe.AsPointer(ref this), pCanSeekForward);
    }

    /// <include file='IMediaPosition.xml' path='doc/member[@name="IMediaPosition.CanSeekBackward"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CanSeekBackward([NativeTypeName("LONG *")] int* pCanSeekBackward)
    {
        return ((delegate* unmanaged<IMediaPosition*, int*, int> )(lpVtbl[17]))((IMediaPosition*)Unsafe.AsPointer(ref this), pCanSeekBackward);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Duration([NativeTypeName("REFTIME *")] double* plength);
        [VtblIndex(8)]
        HRESULT put_CurrentPosition([NativeTypeName("REFTIME")] double llTime);
        [VtblIndex(9)]
        HRESULT get_CurrentPosition([NativeTypeName("REFTIME *")] double* pllTime);
        [VtblIndex(10)]
        HRESULT get_StopTime([NativeTypeName("REFTIME *")] double* pllTime);
        [VtblIndex(11)]
        HRESULT put_StopTime([NativeTypeName("REFTIME")] double llTime);
        [VtblIndex(12)]
        HRESULT get_PrerollTime([NativeTypeName("REFTIME *")] double* pllTime);
        [VtblIndex(13)]
        HRESULT put_PrerollTime([NativeTypeName("REFTIME")] double llTime);
        [VtblIndex(14)]
        HRESULT put_Rate(double dRate);
        [VtblIndex(15)]
        HRESULT get_Rate(double* pdRate);
        [VtblIndex(16)]
        HRESULT CanSeekForward([NativeTypeName("LONG *")] int* pCanSeekForward);
        [VtblIndex(17)]
        HRESULT CanSeekBackward([NativeTypeName("LONG *")] int* pCanSeekBackward);
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
        [NativeTypeName("HRESULT (REFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Duration;
        [NativeTypeName("HRESULT (REFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_CurrentPosition;
        [NativeTypeName("HRESULT (REFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_CurrentPosition;
        [NativeTypeName("HRESULT (REFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_StopTime;
        [NativeTypeName("HRESULT (REFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_StopTime;
        [NativeTypeName("HRESULT (REFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_PrerollTime;
        [NativeTypeName("HRESULT (REFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_PrerollTime;
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Rate;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Rate;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CanSeekForward;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CanSeekBackward;
    }
}