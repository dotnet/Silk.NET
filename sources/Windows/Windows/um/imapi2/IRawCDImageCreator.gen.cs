// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator"]/*'/>
[Guid("25983550-9D65-49CE-B335-40630D901227")]
[NativeTypeName("struct IRawCDImageCreator : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IRawCDImageCreator : IRawCDImageCreator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRawCDImageCreator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, Guid*, void**, int> )(lpVtbl[0]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, uint> )(lpVtbl[1]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, uint> )(lpVtbl[2]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, uint*, int> )(lpVtbl[3]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.CreateResultImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateResultImage(IStream** resultStream)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, IStream**, int> )(lpVtbl[7]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), resultStream);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.AddTrack"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddTrack(IMAPI_CD_SECTOR_TYPE dataType, IStream* data, [NativeTypeName("LONG *")] int* trackIndex)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, IMAPI_CD_SECTOR_TYPE, IStream*, int*, int> )(lpVtbl[8]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), dataType, data, trackIndex);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.AddSpecialPregap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddSpecialPregap(IStream* data)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, IStream*, int> )(lpVtbl[9]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), data);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.AddSubcodeRWGenerator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddSubcodeRWGenerator(IStream* subcode)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, IStream*, int> )(lpVtbl[10]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), subcode);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.put_ResultingImageType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ResultingImageType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE, int> )(lpVtbl[11]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_ResultingImageType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ResultingImageType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE* value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE*, int> )(lpVtbl[12]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_StartOfLeadout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_StartOfLeadout([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int*, int> )(lpVtbl[13]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.put_StartOfLeadoutLimit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_StartOfLeadoutLimit([NativeTypeName("LONG")] int value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int, int> )(lpVtbl[14]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_StartOfLeadoutLimit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_StartOfLeadoutLimit([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int*, int> )(lpVtbl[15]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.put_DisableGaplessAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_DisableGaplessAudio([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, short, int> )(lpVtbl[16]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_DisableGaplessAudio"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_DisableGaplessAudio([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, short*, int> )(lpVtbl[17]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.put_MediaCatalogNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_MediaCatalogNumber([NativeTypeName("BSTR")] ushort* value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, ushort*, int> )(lpVtbl[18]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_MediaCatalogNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MediaCatalogNumber([NativeTypeName("BSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, ushort**, int> )(lpVtbl[19]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.put_StartingTrackNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_StartingTrackNumber([NativeTypeName("LONG")] int value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int, int> )(lpVtbl[20]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_StartingTrackNumber"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_StartingTrackNumber([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int*, int> )(lpVtbl[21]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_TrackInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_TrackInfo([NativeTypeName("LONG")] int trackIndex, IRawCDImageTrackInfo** value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int, IRawCDImageTrackInfo**, int> )(lpVtbl[22]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), trackIndex, value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_NumberOfExistingTracks"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_NumberOfExistingTracks([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int*, int> )(lpVtbl[23]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_LastUsedUserSectorInImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_LastUsedUserSectorInImage([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, int*, int> )(lpVtbl[24]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRawCDImageCreator.xml' path='doc/member[@name="IRawCDImageCreator.get_ExpectedTableOfContents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_ExpectedTableOfContents(SAFEARRAY** value)
    {
        return ((delegate* unmanaged<IRawCDImageCreator*, SAFEARRAY**, int> )(lpVtbl[25]))((IRawCDImageCreator*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT CreateResultImage(IStream** resultStream);
        [VtblIndex(8)]
        HRESULT AddTrack(IMAPI_CD_SECTOR_TYPE dataType, IStream* data, [NativeTypeName("LONG *")] int* trackIndex);
        [VtblIndex(9)]
        HRESULT AddSpecialPregap(IStream* data);
        [VtblIndex(10)]
        HRESULT AddSubcodeRWGenerator(IStream* subcode);
        [VtblIndex(11)]
        HRESULT put_ResultingImageType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE value);
        [VtblIndex(12)]
        HRESULT get_ResultingImageType(IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE* value);
        [VtblIndex(13)]
        HRESULT get_StartOfLeadout([NativeTypeName("LONG *")] int* value);
        [VtblIndex(14)]
        HRESULT put_StartOfLeadoutLimit([NativeTypeName("LONG")] int value);
        [VtblIndex(15)]
        HRESULT get_StartOfLeadoutLimit([NativeTypeName("LONG *")] int* value);
        [VtblIndex(16)]
        HRESULT put_DisableGaplessAudio([NativeTypeName("VARIANT_BOOL")] short value);
        [VtblIndex(17)]
        HRESULT get_DisableGaplessAudio([NativeTypeName("VARIANT_BOOL *")] short* value);
        [VtblIndex(18)]
        HRESULT put_MediaCatalogNumber([NativeTypeName("BSTR")] ushort* value);
        [VtblIndex(19)]
        HRESULT get_MediaCatalogNumber([NativeTypeName("BSTR *")] ushort** value);
        [VtblIndex(20)]
        HRESULT put_StartingTrackNumber([NativeTypeName("LONG")] int value);
        [VtblIndex(21)]
        HRESULT get_StartingTrackNumber([NativeTypeName("LONG *")] int* value);
        [VtblIndex(22)]
        HRESULT get_TrackInfo([NativeTypeName("LONG")] int trackIndex, IRawCDImageTrackInfo** value);
        [VtblIndex(23)]
        HRESULT get_NumberOfExistingTracks([NativeTypeName("LONG *")] int* value);
        [VtblIndex(24)]
        HRESULT get_LastUsedUserSectorInImage([NativeTypeName("LONG *")] int* value);
        [VtblIndex(25)]
        HRESULT get_ExpectedTableOfContents(SAFEARRAY** value);
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
        public delegate* unmanaged<TSelf*, IStream**, int> CreateResultImage;
        [NativeTypeName("HRESULT (IMAPI_CD_SECTOR_TYPE, IStream *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_CD_SECTOR_TYPE, IStream*, int*, int> AddTrack;
        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> AddSpecialPregap;
        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> AddSubcodeRWGenerator;
        [NativeTypeName("HRESULT (IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE, int> put_ResultingImageType;
        [NativeTypeName("HRESULT (IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE*, int> get_ResultingImageType;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartOfLeadout;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_StartOfLeadoutLimit;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartOfLeadoutLimit;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_DisableGaplessAudio;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_DisableGaplessAudio;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_MediaCatalogNumber;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_MediaCatalogNumber;
        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_StartingTrackNumber;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartingTrackNumber;
        [NativeTypeName("HRESULT (LONG, IRawCDImageTrackInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IRawCDImageTrackInfo**, int> get_TrackInfo;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfExistingTracks;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastUsedUserSectorInImage;
        [NativeTypeName("HRESULT (SAFEARRAY **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SAFEARRAY**, int> get_ExpectedTableOfContents;
    }
}