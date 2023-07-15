// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex"]/*'/>
[Guid("27354132-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscRecorder2Ex : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiscRecorder2Ex : IDiscRecorder2Ex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscRecorder2Ex));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, Guid*, void**, int> )(lpVtbl[0]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, uint> )(lpVtbl[1]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, uint> )(lpVtbl[2]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.SendCommandNoData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SendCommandNoData(byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE[18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, byte*, uint, byte*, uint, int> )(lpVtbl[3]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), Cdb, CdbSize, SenseBuffer, Timeout);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.SendCommandSendDataToDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SendCommandSendDataToDevice(byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE[18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout, byte* Buffer, [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, byte*, uint, byte*, uint, byte*, uint, int> )(lpVtbl[4]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), Cdb, CdbSize, SenseBuffer, Timeout, Buffer, BufferSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.SendCommandGetDataFromDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SendCommandGetDataFromDevice(byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE[18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout, byte* Buffer, [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize, [NativeTypeName("ULONG_IMAPI2_NOT_NEGATIVE *")] uint* BufferFetched)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, byte*, uint, byte*, uint, byte*, uint, uint*, int> )(lpVtbl[5]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), Cdb, CdbSize, SenseBuffer, Timeout, Buffer, BufferSize, BufferFetched);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.ReadDvdStructure"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadDvdStructure([NativeTypeName("ULONG")] uint format, [NativeTypeName("ULONG")] uint address, [NativeTypeName("ULONG")] uint layer, [NativeTypeName("ULONG")] uint agid, byte** data, [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE *")] uint* count)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, uint, uint, uint, uint, byte**, uint*, int> )(lpVtbl[6]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), format, address, layer, agid, data, count);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.SendDvdStructure"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SendDvdStructure([NativeTypeName("ULONG")] uint format, byte* data, [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE")] uint count)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, uint, byte*, uint, int> )(lpVtbl[7]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), format, data, count);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetAdapterDescriptor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAdapterDescriptor(byte** data, [NativeTypeName("ULONG_IMAPI2_ADAPTER_DESCRIPTOR *")] uint* byteSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, byte**, uint*, int> )(lpVtbl[8]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), data, byteSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetDeviceDescriptor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceDescriptor(byte** data, [NativeTypeName("ULONG_IMAPI2_DEVICE_DESCRIPTOR *")] uint* byteSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, byte**, uint*, int> )(lpVtbl[9]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), data, byteSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetDiscInformation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDiscInformation(byte** discInformation, [NativeTypeName("ULONG_IMAPI2_DISC_INFORMATION *")] uint* byteSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, byte**, uint*, int> )(lpVtbl[10]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), discInformation, byteSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetTrackInformation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetTrackInformation([NativeTypeName("ULONG")] uint address, IMAPI_READ_TRACK_ADDRESS_TYPE addressType, byte** trackInformation, [NativeTypeName("ULONG_IMAPI2_TRACK_INFORMATION *")] uint* byteSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, uint, IMAPI_READ_TRACK_ADDRESS_TYPE, byte**, uint*, int> )(lpVtbl[11]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), address, addressType, trackInformation, byteSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetFeaturePage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFeaturePage(IMAPI_FEATURE_PAGE_TYPE requestedFeature, [NativeTypeName("BOOLEAN")] byte currentFeatureOnly, byte** featureData, [NativeTypeName("ULONG_IMAPI2_FEATURE_PAGE *")] uint* byteSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, IMAPI_FEATURE_PAGE_TYPE, byte, byte**, uint*, int> )(lpVtbl[12]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), requestedFeature, currentFeatureOnly, featureData, byteSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetModePage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetModePage(IMAPI_MODE_PAGE_TYPE requestedModePage, IMAPI_MODE_PAGE_REQUEST_TYPE requestType, byte** modePageData, [NativeTypeName("ULONG_IMAPI2_MODE_PAGE *")] uint* byteSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, IMAPI_MODE_PAGE_TYPE, IMAPI_MODE_PAGE_REQUEST_TYPE, byte**, uint*, int> )(lpVtbl[13]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), requestedModePage, requestType, modePageData, byteSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.SetModePage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetModePage(IMAPI_MODE_PAGE_REQUEST_TYPE requestType, byte* data, [NativeTypeName("ULONG_IMAPI2_MODE_PAGE")] uint byteSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, IMAPI_MODE_PAGE_REQUEST_TYPE, byte*, uint, int> )(lpVtbl[14]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), requestType, data, byteSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetSupportedFeaturePages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetSupportedFeaturePages([NativeTypeName("BOOLEAN")] byte currentFeatureOnly, IMAPI_FEATURE_PAGE_TYPE** featureData, [NativeTypeName("ULONG_IMAPI2_ALL_FEATURE_PAGES *")] uint* byteSize)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, byte, IMAPI_FEATURE_PAGE_TYPE**, uint*, int> )(lpVtbl[15]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), currentFeatureOnly, featureData, byteSize);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetSupportedProfiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetSupportedProfiles([NativeTypeName("BOOLEAN")] byte currentOnly, IMAPI_PROFILE_TYPE** profileTypes, [NativeTypeName("ULONG_IMAPI2_ALL_PROFILES *")] uint* validProfiles)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, byte, IMAPI_PROFILE_TYPE**, uint*, int> )(lpVtbl[16]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), currentOnly, profileTypes, validProfiles);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetSupportedModePages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetSupportedModePages(IMAPI_MODE_PAGE_REQUEST_TYPE requestType, IMAPI_MODE_PAGE_TYPE** modePageTypes, [NativeTypeName("ULONG_IMAPI2_ALL_MODE_PAGES *")] uint* validPages)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, IMAPI_MODE_PAGE_REQUEST_TYPE, IMAPI_MODE_PAGE_TYPE**, uint*, int> )(lpVtbl[17]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), requestType, modePageTypes, validPages);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetByteAlignmentMask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetByteAlignmentMask([NativeTypeName("ULONG *")] uint* value)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, uint*, int> )(lpVtbl[18]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetMaximumNonPageAlignedTransferSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetMaximumNonPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, uint*, int> )(lpVtbl[19]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscRecorder2Ex.xml' path='doc/member[@name="IDiscRecorder2Ex.GetMaximumPageAlignedTransferSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetMaximumPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value)
    {
        return ((delegate* unmanaged<IDiscRecorder2Ex*, uint*, int> )(lpVtbl[20]))((IDiscRecorder2Ex*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SendCommandNoData(byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE[18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout);
        [VtblIndex(4)]
        HRESULT SendCommandSendDataToDevice(byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE[18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout, byte* Buffer, [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize);
        [VtblIndex(5)]
        HRESULT SendCommandGetDataFromDevice(byte* Cdb, [NativeTypeName("ULONG")] uint CdbSize, [NativeTypeName("BYTE[18]")] byte* SenseBuffer, [NativeTypeName("ULONG")] uint Timeout, byte* Buffer, [NativeTypeName("ULONG_IMAPI2_NONZERO")] uint BufferSize, [NativeTypeName("ULONG_IMAPI2_NOT_NEGATIVE *")] uint* BufferFetched);
        [VtblIndex(6)]
        HRESULT ReadDvdStructure([NativeTypeName("ULONG")] uint format, [NativeTypeName("ULONG")] uint address, [NativeTypeName("ULONG")] uint layer, [NativeTypeName("ULONG")] uint agid, byte** data, [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE *")] uint* count);
        [VtblIndex(7)]
        HRESULT SendDvdStructure([NativeTypeName("ULONG")] uint format, byte* data, [NativeTypeName("ULONG_IMAPI2_DVD_STRUCTURE")] uint count);
        [VtblIndex(8)]
        HRESULT GetAdapterDescriptor(byte** data, [NativeTypeName("ULONG_IMAPI2_ADAPTER_DESCRIPTOR *")] uint* byteSize);
        [VtblIndex(9)]
        HRESULT GetDeviceDescriptor(byte** data, [NativeTypeName("ULONG_IMAPI2_DEVICE_DESCRIPTOR *")] uint* byteSize);
        [VtblIndex(10)]
        HRESULT GetDiscInformation(byte** discInformation, [NativeTypeName("ULONG_IMAPI2_DISC_INFORMATION *")] uint* byteSize);
        [VtblIndex(11)]
        HRESULT GetTrackInformation([NativeTypeName("ULONG")] uint address, IMAPI_READ_TRACK_ADDRESS_TYPE addressType, byte** trackInformation, [NativeTypeName("ULONG_IMAPI2_TRACK_INFORMATION *")] uint* byteSize);
        [VtblIndex(12)]
        HRESULT GetFeaturePage(IMAPI_FEATURE_PAGE_TYPE requestedFeature, [NativeTypeName("BOOLEAN")] byte currentFeatureOnly, byte** featureData, [NativeTypeName("ULONG_IMAPI2_FEATURE_PAGE *")] uint* byteSize);
        [VtblIndex(13)]
        HRESULT GetModePage(IMAPI_MODE_PAGE_TYPE requestedModePage, IMAPI_MODE_PAGE_REQUEST_TYPE requestType, byte** modePageData, [NativeTypeName("ULONG_IMAPI2_MODE_PAGE *")] uint* byteSize);
        [VtblIndex(14)]
        HRESULT SetModePage(IMAPI_MODE_PAGE_REQUEST_TYPE requestType, byte* data, [NativeTypeName("ULONG_IMAPI2_MODE_PAGE")] uint byteSize);
        [VtblIndex(15)]
        HRESULT GetSupportedFeaturePages([NativeTypeName("BOOLEAN")] byte currentFeatureOnly, IMAPI_FEATURE_PAGE_TYPE** featureData, [NativeTypeName("ULONG_IMAPI2_ALL_FEATURE_PAGES *")] uint* byteSize);
        [VtblIndex(16)]
        HRESULT GetSupportedProfiles([NativeTypeName("BOOLEAN")] byte currentOnly, IMAPI_PROFILE_TYPE** profileTypes, [NativeTypeName("ULONG_IMAPI2_ALL_PROFILES *")] uint* validProfiles);
        [VtblIndex(17)]
        HRESULT GetSupportedModePages(IMAPI_MODE_PAGE_REQUEST_TYPE requestType, IMAPI_MODE_PAGE_TYPE** modePageTypes, [NativeTypeName("ULONG_IMAPI2_ALL_MODE_PAGES *")] uint* validPages);
        [VtblIndex(18)]
        HRESULT GetByteAlignmentMask([NativeTypeName("ULONG *")] uint* value);
        [VtblIndex(19)]
        HRESULT GetMaximumNonPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value);
        [VtblIndex(20)]
        HRESULT GetMaximumPageAlignedTransferSize([NativeTypeName("ULONG *")] uint* value);
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
        [NativeTypeName("HRESULT (BYTE *, ULONG, BYTE *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, byte*, uint, int> SendCommandNoData;
        [NativeTypeName("HRESULT (BYTE *, ULONG, BYTE *, ULONG, BYTE *, ULONG_IMAPI2_NONZERO) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, byte*, uint, byte*, uint, int> SendCommandSendDataToDevice;
        [NativeTypeName("HRESULT (BYTE *, ULONG, BYTE *, ULONG, BYTE *, ULONG_IMAPI2_NONZERO, ULONG_IMAPI2_NOT_NEGATIVE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, byte*, uint, byte*, uint, uint*, int> SendCommandGetDataFromDevice;
        [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, ULONG, BYTE **, ULONG_IMAPI2_DVD_STRUCTURE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint, byte**, uint*, int> ReadDvdStructure;
        [NativeTypeName("HRESULT (ULONG, BYTE *, ULONG_IMAPI2_DVD_STRUCTURE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, uint, int> SendDvdStructure;
        [NativeTypeName("HRESULT (BYTE **, ULONG_IMAPI2_ADAPTER_DESCRIPTOR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetAdapterDescriptor;
        [NativeTypeName("HRESULT (BYTE **, ULONG_IMAPI2_DEVICE_DESCRIPTOR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetDeviceDescriptor;
        [NativeTypeName("HRESULT (BYTE **, ULONG_IMAPI2_DISC_INFORMATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetDiscInformation;
        [NativeTypeName("HRESULT (ULONG, IMAPI_READ_TRACK_ADDRESS_TYPE, BYTE **, ULONG_IMAPI2_TRACK_INFORMATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMAPI_READ_TRACK_ADDRESS_TYPE, byte**, uint*, int> GetTrackInformation;
        [NativeTypeName("HRESULT (IMAPI_FEATURE_PAGE_TYPE, BOOLEAN, BYTE **, ULONG_IMAPI2_FEATURE_PAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_FEATURE_PAGE_TYPE, byte, byte**, uint*, int> GetFeaturePage;
        [NativeTypeName("HRESULT (IMAPI_MODE_PAGE_TYPE, IMAPI_MODE_PAGE_REQUEST_TYPE, BYTE **, ULONG_IMAPI2_MODE_PAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_MODE_PAGE_TYPE, IMAPI_MODE_PAGE_REQUEST_TYPE, byte**, uint*, int> GetModePage;
        [NativeTypeName("HRESULT (IMAPI_MODE_PAGE_REQUEST_TYPE, BYTE *, ULONG_IMAPI2_MODE_PAGE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_MODE_PAGE_REQUEST_TYPE, byte*, uint, int> SetModePage;
        [NativeTypeName("HRESULT (BOOLEAN, IMAPI_FEATURE_PAGE_TYPE **, ULONG_IMAPI2_ALL_FEATURE_PAGES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, IMAPI_FEATURE_PAGE_TYPE**, uint*, int> GetSupportedFeaturePages;
        [NativeTypeName("HRESULT (BOOLEAN, IMAPI_PROFILE_TYPE **, ULONG_IMAPI2_ALL_PROFILES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, IMAPI_PROFILE_TYPE**, uint*, int> GetSupportedProfiles;
        [NativeTypeName("HRESULT (IMAPI_MODE_PAGE_REQUEST_TYPE, IMAPI_MODE_PAGE_TYPE **, ULONG_IMAPI2_ALL_MODE_PAGES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAPI_MODE_PAGE_REQUEST_TYPE, IMAPI_MODE_PAGE_TYPE**, uint*, int> GetSupportedModePages;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetByteAlignmentMask;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaximumNonPageAlignedTransferSize;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaximumPageAlignedTransferSize;
    }
}