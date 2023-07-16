// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster"]/*'/>
[Guid("520CCA62-51A5-11D3-9144-00104BA11C5E")]
[NativeTypeName("struct IDiscMaster : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiscMaster : IDiscMaster.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscMaster));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscMaster*, Guid*, void**, int> )(lpVtbl[0]))((IDiscMaster*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiscMaster*, uint> )(lpVtbl[1]))((IDiscMaster*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscMaster*, uint> )(lpVtbl[2]))((IDiscMaster*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.Open"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Open()
    {
        return ((delegate* unmanaged<IDiscMaster*, int> )(lpVtbl[3]))((IDiscMaster*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.EnumDiscMasterFormats"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumDiscMasterFormats(IEnumDiscMasterFormats** ppEnum)
    {
        return ((delegate* unmanaged<IDiscMaster*, IEnumDiscMasterFormats**, int> )(lpVtbl[4]))((IDiscMaster*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.GetActiveDiscMasterFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetActiveDiscMasterFormat([NativeTypeName("LPIID")] Guid* lpiid)
    {
        return ((delegate* unmanaged<IDiscMaster*, Guid*, int> )(lpVtbl[5]))((IDiscMaster*)Unsafe.AsPointer(ref this), lpiid);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.SetActiveDiscMasterFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetActiveDiscMasterFormat([NativeTypeName("const IID &")] Guid* riid, void** ppUnk)
    {
        return ((delegate* unmanaged<IDiscMaster*, Guid*, void**, int> )(lpVtbl[6]))((IDiscMaster*)Unsafe.AsPointer(ref this), riid, ppUnk);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.EnumDiscRecorders"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumDiscRecorders(IEnumDiscRecorders** ppEnum)
    {
        return ((delegate* unmanaged<IDiscMaster*, IEnumDiscRecorders**, int> )(lpVtbl[7]))((IDiscMaster*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.GetActiveDiscRecorder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetActiveDiscRecorder(IDiscRecorder** ppRecorder)
    {
        return ((delegate* unmanaged<IDiscMaster*, IDiscRecorder**, int> )(lpVtbl[8]))((IDiscMaster*)Unsafe.AsPointer(ref this), ppRecorder);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.SetActiveDiscRecorder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetActiveDiscRecorder(IDiscRecorder* pRecorder)
    {
        return ((delegate* unmanaged<IDiscMaster*, IDiscRecorder*, int> )(lpVtbl[9]))((IDiscMaster*)Unsafe.AsPointer(ref this), pRecorder);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.ClearFormatContent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ClearFormatContent()
    {
        return ((delegate* unmanaged<IDiscMaster*, int> )(lpVtbl[10]))((IDiscMaster*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.ProgressAdvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ProgressAdvise(IDiscMasterProgressEvents* pEvents, [NativeTypeName("UINT_PTR *")] nuint* pvCookie)
    {
        return ((delegate* unmanaged<IDiscMaster*, IDiscMasterProgressEvents*, nuint*, int> )(lpVtbl[11]))((IDiscMaster*)Unsafe.AsPointer(ref this), pEvents, pvCookie);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.ProgressUnadvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ProgressUnadvise([NativeTypeName("UINT_PTR")] nuint vCookie)
    {
        return ((delegate* unmanaged<IDiscMaster*, nuint, int> )(lpVtbl[12]))((IDiscMaster*)Unsafe.AsPointer(ref this), vCookie);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.RecordDisc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RecordDisc([NativeTypeName("boolean")] byte bSimulate, [NativeTypeName("boolean")] byte bEjectAfterBurn)
    {
        return ((delegate* unmanaged<IDiscMaster*, byte, byte, int> )(lpVtbl[13]))((IDiscMaster*)Unsafe.AsPointer(ref this), bSimulate, bEjectAfterBurn);
    }

    /// <include file='IDiscMaster.xml' path='doc/member[@name="IDiscMaster.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IDiscMaster*, int> )(lpVtbl[14]))((IDiscMaster*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Open();
        [VtblIndex(4)]
        HRESULT EnumDiscMasterFormats(IEnumDiscMasterFormats** ppEnum);
        [VtblIndex(5)]
        HRESULT GetActiveDiscMasterFormat([NativeTypeName("LPIID")] Guid* lpiid);
        [VtblIndex(6)]
        HRESULT SetActiveDiscMasterFormat([NativeTypeName("const IID &")] Guid* riid, void** ppUnk);
        [VtblIndex(7)]
        HRESULT EnumDiscRecorders(IEnumDiscRecorders** ppEnum);
        [VtblIndex(8)]
        HRESULT GetActiveDiscRecorder(IDiscRecorder** ppRecorder);
        [VtblIndex(9)]
        HRESULT SetActiveDiscRecorder(IDiscRecorder* pRecorder);
        [VtblIndex(10)]
        HRESULT ClearFormatContent();
        [VtblIndex(11)]
        HRESULT ProgressAdvise(IDiscMasterProgressEvents* pEvents, [NativeTypeName("UINT_PTR *")] nuint* pvCookie);
        [VtblIndex(12)]
        HRESULT ProgressUnadvise([NativeTypeName("UINT_PTR")] nuint vCookie);
        [VtblIndex(13)]
        HRESULT RecordDisc([NativeTypeName("boolean")] byte bSimulate, [NativeTypeName("boolean")] byte bEjectAfterBurn);
        [VtblIndex(14)]
        HRESULT Close();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Open;
        [NativeTypeName("HRESULT (IEnumDiscMasterFormats **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumDiscMasterFormats**, int> EnumDiscMasterFormats;
        [NativeTypeName("HRESULT (LPIID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetActiveDiscMasterFormat;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> SetActiveDiscMasterFormat;
        [NativeTypeName("HRESULT (IEnumDiscRecorders **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumDiscRecorders**, int> EnumDiscRecorders;
        [NativeTypeName("HRESULT (IDiscRecorder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder**, int> GetActiveDiscRecorder;
        [NativeTypeName("HRESULT (IDiscRecorder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder*, int> SetActiveDiscRecorder;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearFormatContent;
        [NativeTypeName("HRESULT (IDiscMasterProgressEvents *, UINT_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscMasterProgressEvents*, nuint*, int> ProgressAdvise;
        [NativeTypeName("HRESULT (UINT_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> ProgressUnadvise;
        [NativeTypeName("HRESULT (boolean, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, byte, int> RecordDisc;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}