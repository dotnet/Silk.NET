// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo"]/*' />
[Guid("56A868B5-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IBasicVideo : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IBasicVideo : IBasicVideo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBasicVideo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBasicVideo*, Guid*, void**, int>)(lpVtbl[0]))((IBasicVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBasicVideo*, uint>)(lpVtbl[1]))((IBasicVideo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBasicVideo*, uint>)(lpVtbl[2]))((IBasicVideo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IBasicVideo*, uint*, int>)(lpVtbl[3]))((IBasicVideo*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IBasicVideo*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IBasicVideo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IBasicVideo*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IBasicVideo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IBasicVideo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_AvgTimePerFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AvgTimePerFrame([NativeTypeName("REFTIME *")] double* pAvgTimePerFrame)
    {
        return ((delegate* unmanaged<IBasicVideo*, double*, int>)(lpVtbl[7]))((IBasicVideo*)Unsafe.AsPointer(ref this), pAvgTimePerFrame);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_BitRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BitRate([NativeTypeName("long *")] int* pBitRate)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[8]))((IBasicVideo*)Unsafe.AsPointer(ref this), pBitRate);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_BitErrorRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BitErrorRate([NativeTypeName("long *")] int* pBitErrorRate)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[9]))((IBasicVideo*)Unsafe.AsPointer(ref this), pBitErrorRate);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_VideoWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoWidth([NativeTypeName("long *")] int* pVideoWidth)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[10]))((IBasicVideo*)Unsafe.AsPointer(ref this), pVideoWidth);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_VideoHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_VideoHeight([NativeTypeName("long *")] int* pVideoHeight)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[11]))((IBasicVideo*)Unsafe.AsPointer(ref this), pVideoHeight);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.put_SourceLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SourceLeft([NativeTypeName("long")] int SourceLeft)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[12]))((IBasicVideo*)Unsafe.AsPointer(ref this), SourceLeft);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_SourceLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SourceLeft([NativeTypeName("long *")] int* pSourceLeft)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[13]))((IBasicVideo*)Unsafe.AsPointer(ref this), pSourceLeft);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.put_SourceWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_SourceWidth([NativeTypeName("long")] int SourceWidth)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[14]))((IBasicVideo*)Unsafe.AsPointer(ref this), SourceWidth);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_SourceWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SourceWidth([NativeTypeName("long *")] int* pSourceWidth)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[15]))((IBasicVideo*)Unsafe.AsPointer(ref this), pSourceWidth);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.put_SourceTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_SourceTop([NativeTypeName("long")] int SourceTop)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[16]))((IBasicVideo*)Unsafe.AsPointer(ref this), SourceTop);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_SourceTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SourceTop([NativeTypeName("long *")] int* pSourceTop)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[17]))((IBasicVideo*)Unsafe.AsPointer(ref this), pSourceTop);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.put_SourceHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_SourceHeight([NativeTypeName("long")] int SourceHeight)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[18]))((IBasicVideo*)Unsafe.AsPointer(ref this), SourceHeight);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_SourceHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_SourceHeight([NativeTypeName("long *")] int* pSourceHeight)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[19]))((IBasicVideo*)Unsafe.AsPointer(ref this), pSourceHeight);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.put_DestinationLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_DestinationLeft([NativeTypeName("long")] int DestinationLeft)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[20]))((IBasicVideo*)Unsafe.AsPointer(ref this), DestinationLeft);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_DestinationLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_DestinationLeft([NativeTypeName("long *")] int* pDestinationLeft)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[21]))((IBasicVideo*)Unsafe.AsPointer(ref this), pDestinationLeft);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.put_DestinationWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_DestinationWidth([NativeTypeName("long")] int DestinationWidth)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[22]))((IBasicVideo*)Unsafe.AsPointer(ref this), DestinationWidth);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_DestinationWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_DestinationWidth([NativeTypeName("long *")] int* pDestinationWidth)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[23]))((IBasicVideo*)Unsafe.AsPointer(ref this), pDestinationWidth);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.put_DestinationTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_DestinationTop([NativeTypeName("long")] int DestinationTop)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[24]))((IBasicVideo*)Unsafe.AsPointer(ref this), DestinationTop);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_DestinationTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_DestinationTop([NativeTypeName("long *")] int* pDestinationTop)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[25]))((IBasicVideo*)Unsafe.AsPointer(ref this), pDestinationTop);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.put_DestinationHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_DestinationHeight([NativeTypeName("long")] int DestinationHeight)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[26]))((IBasicVideo*)Unsafe.AsPointer(ref this), DestinationHeight);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.get_DestinationHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_DestinationHeight([NativeTypeName("long *")] int* pDestinationHeight)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[27]))((IBasicVideo*)Unsafe.AsPointer(ref this), pDestinationHeight);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.SetSourcePosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetSourcePosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int, int, int, int>)(lpVtbl[28]))((IBasicVideo*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.GetSourcePosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetSourcePosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int*, int*, int*, int>)(lpVtbl[29]))((IBasicVideo*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.SetDefaultSourcePosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetDefaultSourcePosition()
    {
        return ((delegate* unmanaged<IBasicVideo*, int>)(lpVtbl[30]))((IBasicVideo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.SetDestinationPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetDestinationPosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int, int, int, int>)(lpVtbl[31]))((IBasicVideo*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.GetDestinationPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetDestinationPosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int*, int*, int*, int>)(lpVtbl[32]))((IBasicVideo*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.SetDefaultDestinationPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetDefaultDestinationPosition()
    {
        return ((delegate* unmanaged<IBasicVideo*, int>)(lpVtbl[33]))((IBasicVideo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.GetVideoSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetVideoSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int*, int>)(lpVtbl[34]))((IBasicVideo*)Unsafe.AsPointer(ref this), pWidth, pHeight);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.GetVideoPaletteEntries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetVideoPaletteEntries([NativeTypeName("long")] int StartIndex, [NativeTypeName("long")] int Entries, [NativeTypeName("long *")] int* pRetrieved, [NativeTypeName("long *")] int* pPalette)
    {
        return ((delegate* unmanaged<IBasicVideo*, int, int, int*, int*, int>)(lpVtbl[35]))((IBasicVideo*)Unsafe.AsPointer(ref this), StartIndex, Entries, pRetrieved, pPalette);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.GetCurrentImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetCurrentImage([NativeTypeName("long *")] int* pBufferSize, [NativeTypeName("long *")] int* pDIBImage)
    {
        return ((delegate* unmanaged<IBasicVideo*, int*, int*, int>)(lpVtbl[36]))((IBasicVideo*)Unsafe.AsPointer(ref this), pBufferSize, pDIBImage);
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.IsUsingDefaultSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT IsUsingDefaultSource()
    {
        return ((delegate* unmanaged<IBasicVideo*, int>)(lpVtbl[37]))((IBasicVideo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBasicVideo.xml' path='doc/member[@name="IBasicVideo.IsUsingDefaultDestination"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT IsUsingDefaultDestination()
    {
        return ((delegate* unmanaged<IBasicVideo*, int>)(lpVtbl[38]))((IBasicVideo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_AvgTimePerFrame([NativeTypeName("REFTIME *")] double* pAvgTimePerFrame);

        [VtblIndex(8)]
        HRESULT get_BitRate([NativeTypeName("long *")] int* pBitRate);

        [VtblIndex(9)]
        HRESULT get_BitErrorRate([NativeTypeName("long *")] int* pBitErrorRate);

        [VtblIndex(10)]
        HRESULT get_VideoWidth([NativeTypeName("long *")] int* pVideoWidth);

        [VtblIndex(11)]
        HRESULT get_VideoHeight([NativeTypeName("long *")] int* pVideoHeight);

        [VtblIndex(12)]
        HRESULT put_SourceLeft([NativeTypeName("long")] int SourceLeft);

        [VtblIndex(13)]
        HRESULT get_SourceLeft([NativeTypeName("long *")] int* pSourceLeft);

        [VtblIndex(14)]
        HRESULT put_SourceWidth([NativeTypeName("long")] int SourceWidth);

        [VtblIndex(15)]
        HRESULT get_SourceWidth([NativeTypeName("long *")] int* pSourceWidth);

        [VtblIndex(16)]
        HRESULT put_SourceTop([NativeTypeName("long")] int SourceTop);

        [VtblIndex(17)]
        HRESULT get_SourceTop([NativeTypeName("long *")] int* pSourceTop);

        [VtblIndex(18)]
        HRESULT put_SourceHeight([NativeTypeName("long")] int SourceHeight);

        [VtblIndex(19)]
        HRESULT get_SourceHeight([NativeTypeName("long *")] int* pSourceHeight);

        [VtblIndex(20)]
        HRESULT put_DestinationLeft([NativeTypeName("long")] int DestinationLeft);

        [VtblIndex(21)]
        HRESULT get_DestinationLeft([NativeTypeName("long *")] int* pDestinationLeft);

        [VtblIndex(22)]
        HRESULT put_DestinationWidth([NativeTypeName("long")] int DestinationWidth);

        [VtblIndex(23)]
        HRESULT get_DestinationWidth([NativeTypeName("long *")] int* pDestinationWidth);

        [VtblIndex(24)]
        HRESULT put_DestinationTop([NativeTypeName("long")] int DestinationTop);

        [VtblIndex(25)]
        HRESULT get_DestinationTop([NativeTypeName("long *")] int* pDestinationTop);

        [VtblIndex(26)]
        HRESULT put_DestinationHeight([NativeTypeName("long")] int DestinationHeight);

        [VtblIndex(27)]
        HRESULT get_DestinationHeight([NativeTypeName("long *")] int* pDestinationHeight);

        [VtblIndex(28)]
        HRESULT SetSourcePosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height);

        [VtblIndex(29)]
        HRESULT GetSourcePosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight);

        [VtblIndex(30)]
        HRESULT SetDefaultSourcePosition();

        [VtblIndex(31)]
        HRESULT SetDestinationPosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height);

        [VtblIndex(32)]
        HRESULT GetDestinationPosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight);

        [VtblIndex(33)]
        HRESULT SetDefaultDestinationPosition();

        [VtblIndex(34)]
        HRESULT GetVideoSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight);

        [VtblIndex(35)]
        HRESULT GetVideoPaletteEntries([NativeTypeName("long")] int StartIndex, [NativeTypeName("long")] int Entries, [NativeTypeName("long *")] int* pRetrieved, [NativeTypeName("long *")] int* pPalette);

        [VtblIndex(36)]
        HRESULT GetCurrentImage([NativeTypeName("long *")] int* pBufferSize, [NativeTypeName("long *")] int* pDIBImage);

        [VtblIndex(37)]
        HRESULT IsUsingDefaultSource();

        [VtblIndex(38)]
        HRESULT IsUsingDefaultDestination();
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
        public delegate* unmanaged<TSelf*, double*, int> get_AvgTimePerFrame;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BitRate;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BitErrorRate;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_VideoWidth;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_VideoHeight;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SourceLeft;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SourceLeft;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SourceWidth;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SourceWidth;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SourceTop;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SourceTop;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SourceHeight;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SourceHeight;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DestinationLeft;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DestinationLeft;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DestinationWidth;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DestinationWidth;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DestinationTop;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DestinationTop;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DestinationHeight;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DestinationHeight;

        [NativeTypeName("HRESULT (long, long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int, int> SetSourcePosition;

        [NativeTypeName("HRESULT (long *, long *, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int*, int> GetSourcePosition;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefaultSourcePosition;

        [NativeTypeName("HRESULT (long, long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int, int> SetDestinationPosition;

        [NativeTypeName("HRESULT (long *, long *, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int*, int> GetDestinationPosition;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefaultDestinationPosition;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetVideoSize;

        [NativeTypeName("HRESULT (long, long, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int*, int*, int> GetVideoPaletteEntries;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetCurrentImage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsUsingDefaultSource;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsUsingDefaultDestination;
    }
}
