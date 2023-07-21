// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFTimedTextCueList.xml' path='doc/member[@name="IMFTimedTextCueList"]/*' />
[Guid("AD128745-211B-40A0-9981-FE65F166D0FD")]
[NativeTypeName("struct IMFTimedTextCueList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimedTextCueList : IMFTimedTextCueList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextCueList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, uint>)(lpVtbl[1]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, uint>)(lpVtbl[2]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextCueList.xml' path='doc/member[@name="IMFTimedTextCueList.GetLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetLength()
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, uint>)(lpVtbl[3]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextCueList.xml' path='doc/member[@name="IMFTimedTextCueList.GetCueByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCueByIndex([NativeTypeName("DWORD")] uint index, IMFTimedTextCue** cue)
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)(lpVtbl[4]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), index, cue);
    }

    /// <include file='IMFTimedTextCueList.xml' path='doc/member[@name="IMFTimedTextCueList.GetCueById"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCueById([NativeTypeName("DWORD")] uint id, IMFTimedTextCue** cue)
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)(lpVtbl[5]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), id, cue);
    }

    /// <include file='IMFTimedTextCueList.xml' path='doc/member[@name="IMFTimedTextCueList.GetCueByOriginalId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCueByOriginalId([NativeTypeName("LPCWSTR")] ushort* originalId, IMFTimedTextCue** cue)
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, ushort*, IMFTimedTextCue**, int>)(lpVtbl[6]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), originalId, cue);
    }

    /// <include file='IMFTimedTextCueList.xml' path='doc/member[@name="IMFTimedTextCueList.AddTextCue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddTextCue(double start, double duration, [NativeTypeName("LPCWSTR")] ushort* text, IMFTimedTextCue** cue)
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, double, double, ushort*, IMFTimedTextCue**, int>)(lpVtbl[7]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), start, duration, text, cue);
    }

    /// <include file='IMFTimedTextCueList.xml' path='doc/member[@name="IMFTimedTextCueList.AddDataCue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddDataCue(double start, double duration, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("DWORD")] uint dataSize, IMFTimedTextCue** cue)
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)(lpVtbl[8]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), start, duration, data, dataSize, cue);
    }

    /// <include file='IMFTimedTextCueList.xml' path='doc/member[@name="IMFTimedTextCueList.RemoveCue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveCue(IMFTimedTextCue* cue)
    {
        return ((delegate* unmanaged<IMFTimedTextCueList*, IMFTimedTextCue*, int>)(lpVtbl[9]))((IMFTimedTextCueList*)Unsafe.AsPointer(ref this), cue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetLength();

        [VtblIndex(4)]
        HRESULT GetCueByIndex([NativeTypeName("DWORD")] uint index, IMFTimedTextCue** cue);

        [VtblIndex(5)]
        HRESULT GetCueById([NativeTypeName("DWORD")] uint id, IMFTimedTextCue** cue);

        [VtblIndex(6)]
        HRESULT GetCueByOriginalId([NativeTypeName("LPCWSTR")] ushort* originalId, IMFTimedTextCue** cue);

        [VtblIndex(7)]
        HRESULT AddTextCue(double start, double duration, [NativeTypeName("LPCWSTR")] ushort* text, IMFTimedTextCue** cue);

        [VtblIndex(8)]
        HRESULT AddDataCue(double start, double duration, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("DWORD")] uint dataSize, IMFTimedTextCue** cue);

        [VtblIndex(9)]
        HRESULT RemoveCue(IMFTimedTextCue* cue);
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
        public delegate* unmanaged<TSelf*, uint> GetLength;

        [NativeTypeName("HRESULT (DWORD, IMFTimedTextCue **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFTimedTextCue**, int> GetCueByIndex;

        [NativeTypeName("HRESULT (DWORD, IMFTimedTextCue **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFTimedTextCue**, int> GetCueById;

        [NativeTypeName("HRESULT (LPCWSTR, IMFTimedTextCue **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IMFTimedTextCue**, int> GetCueByOriginalId;

        [NativeTypeName("HRESULT (double, double, LPCWSTR, IMFTimedTextCue **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, ushort*, IMFTimedTextCue**, int> AddTextCue;

        [NativeTypeName("HRESULT (double, double, const BYTE *, DWORD, IMFTimedTextCue **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, byte*, uint, IMFTimedTextCue**, int> AddDataCue;

        [NativeTypeName("HRESULT (IMFTimedTextCue *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextCue*, int> RemoveCue;
    }
}
