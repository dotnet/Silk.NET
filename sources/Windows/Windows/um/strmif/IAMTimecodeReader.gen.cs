// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAMTimecodeReader.xml' path='doc/member[@name="IAMTimecodeReader"]/*'/>
[Guid("9B496CE1-811B-11CF-8C77-00AA006B6814")]
[NativeTypeName("struct IAMTimecodeReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMTimecodeReader : IAMTimecodeReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMTimecodeReader));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMTimecodeReader*, Guid*, void**, int> )(lpVtbl[0]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMTimecodeReader*, uint> )(lpVtbl[1]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMTimecodeReader*, uint> )(lpVtbl[2]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMTimecodeReader.xml' path='doc/member[@name="IAMTimecodeReader.GetTCRMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTCRMode([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue)
    {
        return ((delegate* unmanaged<IAMTimecodeReader*, int, int*, int> )(lpVtbl[3]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), Param, pValue);
    }

    /// <include file='IAMTimecodeReader.xml' path='doc/member[@name="IAMTimecodeReader.SetTCRMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTCRMode([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value)
    {
        return ((delegate* unmanaged<IAMTimecodeReader*, int, int, int> )(lpVtbl[4]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), Param, Value);
    }

    /// <include file='IAMTimecodeReader.xml' path='doc/member[@name="IAMTimecodeReader.put_VITCLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_VITCLine([NativeTypeName("long")] int Line)
    {
        return ((delegate* unmanaged<IAMTimecodeReader*, int, int> )(lpVtbl[5]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), Line);
    }

    /// <include file='IAMTimecodeReader.xml' path='doc/member[@name="IAMTimecodeReader.get_VITCLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VITCLine([NativeTypeName("long *")] int* pLine)
    {
        return ((delegate* unmanaged<IAMTimecodeReader*, int*, int> )(lpVtbl[6]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), pLine);
    }

    /// <include file='IAMTimecodeReader.xml' path='doc/member[@name="IAMTimecodeReader.GetTimecode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTimecode([NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample)
    {
        return ((delegate* unmanaged<IAMTimecodeReader*, TIMECODE_SAMPLE*, int> )(lpVtbl[7]))((IAMTimecodeReader*)Unsafe.AsPointer(ref this), pTimecodeSample);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTCRMode([NativeTypeName("long")] int Param, [NativeTypeName("long *")] int* pValue);
        [VtblIndex(4)]
        HRESULT SetTCRMode([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value);
        [VtblIndex(5)]
        HRESULT put_VITCLine([NativeTypeName("long")] int Line);
        [VtblIndex(6)]
        HRESULT get_VITCLine([NativeTypeName("long *")] int* pLine);
        [VtblIndex(7)]
        HRESULT GetTimecode([NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample);
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
        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetTCRMode;
        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetTCRMode;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_VITCLine;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_VITCLine;
        [NativeTypeName("HRESULT (PTIMECODE_SAMPLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TIMECODE_SAMPLE*, int> GetTimecode;
    }
}