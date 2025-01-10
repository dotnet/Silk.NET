// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1E560447-9A2B-43E1-A94C-B0AAABFBFBC9")]
[NativeTypeName("struct IMFTimedTextCue : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextCue : IMFTimedTextCue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextCue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextCue, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextCue, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextCue, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetId()
    {
        return ((delegate* unmanaged<IMFTimedTextCue, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOriginalId([NativeTypeName("LPWSTR *")] ushort** originalId)
    {
        return ((delegate* unmanaged<IMFTimedTextCue, ushort**, int>)((*lpVtbl)[4]))(
            this,
            originalId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public MF_TIMED_TEXT_TRACK_KIND GetCueKind()
    {
        return ((delegate* unmanaged<IMFTimedTextCue, MF_TIMED_TEXT_TRACK_KIND>)((*lpVtbl)[5]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public double GetStartTime()
    {
        return ((delegate* unmanaged<IMFTimedTextCue, double>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public double GetDuration()
    {
        return ((delegate* unmanaged<IMFTimedTextCue, double>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("DWORD")]
    public uint GetTrackId()
    {
        return ((delegate* unmanaged<IMFTimedTextCue, uint>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetData(IMFTimedTextBinary* data)
    {
        return ((delegate* unmanaged<IMFTimedTextCue, IMFTimedTextBinary*, int>)((*lpVtbl)[9]))(
            this,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetRegion(IMFTimedTextRegion* region)
    {
        return ((delegate* unmanaged<IMFTimedTextCue, IMFTimedTextRegion*, int>)((*lpVtbl)[10]))(
            this,
            region
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStyle(IMFTimedTextStyle* style)
    {
        return ((delegate* unmanaged<IMFTimedTextCue, IMFTimedTextStyle*, int>)((*lpVtbl)[11]))(
            this,
            style
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("DWORD")]
    public uint GetLineCount()
    {
        return ((delegate* unmanaged<IMFTimedTextCue, uint>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetLine([NativeTypeName("DWORD")] uint index, IMFTimedTextFormattedText* line)
    {
        return (
            (delegate* unmanaged<IMFTimedTextCue, uint, IMFTimedTextFormattedText*, int>)(
                (*lpVtbl)[13]
            )
        )(this, index, line);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetId();

        [VtblIndex(4)]
        HRESULT GetOriginalId([NativeTypeName("LPWSTR *")] ushort** originalId);

        [VtblIndex(5)]
        MF_TIMED_TEXT_TRACK_KIND GetCueKind();

        [VtblIndex(6)]
        double GetStartTime();

        [VtblIndex(7)]
        double GetDuration();

        [VtblIndex(8)]
        [return: NativeTypeName("DWORD")]
        uint GetTrackId();

        [VtblIndex(9)]
        HRESULT GetData(IMFTimedTextBinary* data);

        [VtblIndex(10)]
        HRESULT GetRegion(IMFTimedTextRegion* region);

        [VtblIndex(11)]
        HRESULT GetStyle(IMFTimedTextStyle* style);

        [VtblIndex(12)]
        [return: NativeTypeName("DWORD")]
        uint GetLineCount();

        [VtblIndex(13)]
        HRESULT GetLine([NativeTypeName("DWORD")] uint index, IMFTimedTextFormattedText* line);
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

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetOriginalId;

        [NativeTypeName("MF_TIMED_TEXT_TRACK_KIND () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_TRACK_KIND> GetCueKind;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetStartTime;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetDuration;

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetTrackId;

        [NativeTypeName("HRESULT (IMFTimedTextBinary **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextBinary*, int> GetData;

        [NativeTypeName("HRESULT (IMFTimedTextRegion **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextRegion*, int> GetRegion;

        [NativeTypeName("HRESULT (IMFTimedTextStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextStyle*, int> GetStyle;

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLineCount;

        [NativeTypeName("HRESULT (DWORD, IMFTimedTextFormattedText **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFTimedTextFormattedText*, int> GetLine;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimedTextCue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimedTextCue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimedTextCue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimedTextCue(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimedTextCue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimedTextCue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimedTextCue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimedTextCue value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
