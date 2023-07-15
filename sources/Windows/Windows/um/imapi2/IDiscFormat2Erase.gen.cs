// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase"]/*'/>
[Guid("27354156-8F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscFormat2Erase : IDiscFormat2")]
[NativeInheritance("IDiscFormat2")]
public unsafe partial struct IDiscFormat2Erase : IDiscFormat2Erase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscFormat2Erase));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, Guid*, void**, int> )(lpVtbl[0]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, uint> )(lpVtbl[1]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, uint> )(lpVtbl[2]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, uint*, int> )(lpVtbl[3]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IDiscFormat2.IsRecorderSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsRecorderSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, IDiscRecorder2*, short*, int> )(lpVtbl[7]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), recorder, value);
    }

    /// <inheritdoc cref = "IDiscFormat2.IsCurrentMediaSupported"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsCurrentMediaSupported(IDiscRecorder2* recorder, [NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, IDiscRecorder2*, short*, int> )(lpVtbl[8]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), recorder, value);
    }

    /// <inheritdoc cref = "IDiscFormat2.get_MediaPhysicallyBlank"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MediaPhysicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, short*, int> )(lpVtbl[9]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IDiscFormat2.get_MediaHeuristicallyBlank"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MediaHeuristicallyBlank([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, short*, int> )(lpVtbl[10]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref = "IDiscFormat2.get_SupportedMediaTypes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SupportedMediaTypes(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, SAFEARRAY**, int> )(lpVtbl[11]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase.put_Recorder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Recorder(IDiscRecorder2* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, IDiscRecorder2*, int> )(lpVtbl[12]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase.get_Recorder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Recorder(IDiscRecorder2** value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, IDiscRecorder2**, int> )(lpVtbl[13]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase.put_FullErase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_FullErase([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, short, int> )(lpVtbl[14]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase.get_FullErase"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_FullErase([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, short*, int> )(lpVtbl[15]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase.get_CurrentPhysicalMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, IMAPI_MEDIA_PHYSICAL_TYPE*, int> )(lpVtbl[16]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase.put_ClientName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, ushort*, int> )(lpVtbl[17]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase.get_ClientName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, ushort**, int> )(lpVtbl[18]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2Erase.xml' path='doc/member[@name="IDiscFormat2Erase.EraseMedia"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EraseMedia()
    {
        return ((delegate* unmanaged<IDiscFormat2Erase*, int> )(lpVtbl[19]))((IDiscFormat2Erase*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDiscFormat2.Interface
    {
        [VtblIndex(12)]
        HRESULT put_Recorder(IDiscRecorder2* value);
        [VtblIndex(13)]
        HRESULT get_Recorder(IDiscRecorder2** value);
        [VtblIndex(14)]
        HRESULT put_FullErase([NativeTypeName("VARIANT_BOOL")] short value);
        [VtblIndex(15)]
        HRESULT get_FullErase([NativeTypeName("VARIANT_BOOL *")] short* value);
        [VtblIndex(16)]
        HRESULT get_CurrentPhysicalMediaType(IMAPI_MEDIA_PHYSICAL_TYPE* value);
        [VtblIndex(17)]
        HRESULT put_ClientName([NativeTypeName("BSTR")] ushort* value);
        [VtblIndex(18)]
        HRESULT get_ClientName([NativeTypeName("BSTR *")] ushort** value);
        [VtblIndex(19)]
        HRESULT EraseMedia();
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
        [NativeTypeName("HRESULT (IDiscRecorder2 *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, short*, int> IsRecorderSupported;
        [NativeTypeName("HRESULT (IDiscRecorder2 *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, short*, int> IsCurrentMediaSupported;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_MediaPhysicallyBlank;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_MediaHeuristicallyBlank;
        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_SupportedMediaTypes;
        [NativeTypeName("HRESULT (IDiscRecorder2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, int> put_Recorder;
        [NativeTypeName("HRESULT (IDiscRecorder2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2**, int> get_Recorder;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_FullErase;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_FullErase;
        [NativeTypeName("HRESULT (IMAPI_MEDIA_PHYSICAL_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_MEDIA_PHYSICAL_TYPE*, int> get_CurrentPhysicalMediaType;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_ClientName;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ClientName;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EraseMedia;
    }
}