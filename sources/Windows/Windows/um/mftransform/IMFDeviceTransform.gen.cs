// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform"]/*'/>
[Guid("D818FBD8-FC46-42F2-87AC-1EA2D1F9BF32")]
[NativeTypeName("struct IMFDeviceTransform : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFDeviceTransform : IMFDeviceTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFDeviceTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, Guid*, void**, int> )(lpVtbl[0]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint> )(lpVtbl[1]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint> )(lpVtbl[2]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.InitializeTransform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeTransform(IMFAttributes* pAttributes)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, IMFAttributes*, int> )(lpVtbl[3]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), pAttributes);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetInputAvailableType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetInputAvailableType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** pMediaType)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, IMFMediaType**, int> )(lpVtbl[4]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, dwTypeIndex, pMediaType);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetInputCurrentType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetInputCurrentType([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaType** pMediaType)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaType**, int> )(lpVtbl[5]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pMediaType);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetInputStreamAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetInputStreamAttributes([NativeTypeName("DWORD")] uint dwInputStreamID, IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFAttributes**, int> )(lpVtbl[6]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, ppAttributes);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetOutputAvailableType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutputAvailableType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** pMediaType)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, IMFMediaType**, int> )(lpVtbl[7]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, dwTypeIndex, pMediaType);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetOutputCurrentType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputCurrentType([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFMediaType** pMediaType)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaType**, int> )(lpVtbl[8]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pMediaType);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetOutputStreamAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetOutputStreamAttributes([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFAttributes**, int> )(lpVtbl[9]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, ppAttributes);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetStreamCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pcInputStreams, [NativeTypeName("DWORD *")] uint* pcOutputStreams)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint*, uint*, int> )(lpVtbl[10]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), pcInputStreams, pcOutputStreams);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetStreamIDs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStreamIDs([NativeTypeName("DWORD")] uint dwInputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwInputStreamIds, [NativeTypeName("DWORD")] uint dwOutputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwOutputStreamIds)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint*, uint, uint*, int> )(lpVtbl[11]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputIDArraySize, pdwInputStreamIds, dwOutputIDArraySize, pdwOutputStreamIds);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.ProcessEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ProcessEvent([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaEvent* pEvent)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaEvent*, int> )(lpVtbl[12]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pEvent);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.ProcessInput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ProcessInput([NativeTypeName("DWORD")] uint dwInputStreamID, IMFSample* pSample, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFSample*, uint, int> )(lpVtbl[13]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pSample, dwFlags);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.ProcessMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ProcessMessage(MFT_MESSAGE_TYPE eMessage, [NativeTypeName("ULONG_PTR")] nuint ulParam)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, MFT_MESSAGE_TYPE, nuint, int> )(lpVtbl[14]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), eMessage, ulParam);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.ProcessOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ProcessOutput([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint cOutputBufferCount, MFT_OUTPUT_DATA_BUFFER* pOutputSample, [NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int> )(lpVtbl[15]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwFlags, cOutputBufferCount, pOutputSample, pdwStatus);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.SetInputStreamState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaType*, DeviceStreamState, uint, int> )(lpVtbl[16]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType, value, dwFlags);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetInputStreamState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, DeviceStreamState*, int> )(lpVtbl[17]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.SetOutputStreamState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, IMFMediaType*, DeviceStreamState, uint, int> )(lpVtbl[18]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType, value, dwFlags);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetOutputStreamState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, DeviceStreamState*, int> )(lpVtbl[19]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.GetInputStreamPreferredState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetInputStreamPreferredState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, DeviceStreamState*, IMFMediaType**, int> )(lpVtbl[20]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamID, value, ppMediaType);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.FlushInputStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT FlushInputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, int> )(lpVtbl[21]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamIndex, dwFlags);
    }

    /// <include file='IMFDeviceTransform.xml' path='doc/member[@name="IMFDeviceTransform.FlushOutputStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FlushOutputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IMFDeviceTransform*, uint, uint, int> )(lpVtbl[22]))((IMFDeviceTransform*)Unsafe.AsPointer(ref this), dwStreamIndex, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeTransform(IMFAttributes* pAttributes);
        [VtblIndex(4)]
        HRESULT GetInputAvailableType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** pMediaType);
        [VtblIndex(5)]
        HRESULT GetInputCurrentType([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaType** pMediaType);
        [VtblIndex(6)]
        HRESULT GetInputStreamAttributes([NativeTypeName("DWORD")] uint dwInputStreamID, IMFAttributes** ppAttributes);
        [VtblIndex(7)]
        HRESULT GetOutputAvailableType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** pMediaType);
        [VtblIndex(8)]
        HRESULT GetOutputCurrentType([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFMediaType** pMediaType);
        [VtblIndex(9)]
        HRESULT GetOutputStreamAttributes([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFAttributes** ppAttributes);
        [VtblIndex(10)]
        HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pcInputStreams, [NativeTypeName("DWORD *")] uint* pcOutputStreams);
        [VtblIndex(11)]
        HRESULT GetStreamIDs([NativeTypeName("DWORD")] uint dwInputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwInputStreamIds, [NativeTypeName("DWORD")] uint dwOutputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwOutputStreamIds);
        [VtblIndex(12)]
        HRESULT ProcessEvent([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaEvent* pEvent);
        [VtblIndex(13)]
        HRESULT ProcessInput([NativeTypeName("DWORD")] uint dwInputStreamID, IMFSample* pSample, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(14)]
        HRESULT ProcessMessage(MFT_MESSAGE_TYPE eMessage, [NativeTypeName("ULONG_PTR")] nuint ulParam);
        [VtblIndex(15)]
        HRESULT ProcessOutput([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint cOutputBufferCount, MFT_OUTPUT_DATA_BUFFER* pOutputSample, [NativeTypeName("DWORD *")] uint* pdwStatus);
        [VtblIndex(16)]
        HRESULT SetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(17)]
        HRESULT GetInputStreamState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value);
        [VtblIndex(18)]
        HRESULT SetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType, DeviceStreamState value, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(19)]
        HRESULT GetOutputStreamState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value);
        [VtblIndex(20)]
        HRESULT GetInputStreamPreferredState([NativeTypeName("DWORD")] uint dwStreamID, DeviceStreamState* value, IMFMediaType** ppMediaType);
        [VtblIndex(21)]
        HRESULT FlushInputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(22)]
        HRESULT FlushOutputStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwFlags);
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
        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> InitializeTransform;
        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFMediaType**, int> GetInputAvailableType;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetInputCurrentType;
        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes**, int> GetInputStreamAttributes;
        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFMediaType**, int> GetOutputAvailableType;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetOutputCurrentType;
        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes**, int> GetOutputStreamAttributes;
        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetStreamCount;
        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint, uint*, int> GetStreamIDs;
        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent*, int> ProcessEvent;
        [NativeTypeName("HRESULT (DWORD, IMFSample *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSample*, uint, int> ProcessInput;
        [NativeTypeName("HRESULT (MFT_MESSAGE_TYPE, ULONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFT_MESSAGE_TYPE, nuint, int> ProcessMessage;
        [NativeTypeName("HRESULT (DWORD, DWORD, MFT_OUTPUT_DATA_BUFFER *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int> ProcessOutput;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, DeviceStreamState, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, DeviceStreamState, uint, int> SetInputStreamState;
        [NativeTypeName("HRESULT (DWORD, DeviceStreamState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DeviceStreamState*, int> GetInputStreamState;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, DeviceStreamState, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, DeviceStreamState, uint, int> SetOutputStreamState;
        [NativeTypeName("HRESULT (DWORD, DeviceStreamState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DeviceStreamState*, int> GetOutputStreamState;
        [NativeTypeName("HRESULT (DWORD, DeviceStreamState *, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DeviceStreamState*, IMFMediaType**, int> GetInputStreamPreferredState;
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> FlushInputStream;
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> FlushOutputStream;
    }
}