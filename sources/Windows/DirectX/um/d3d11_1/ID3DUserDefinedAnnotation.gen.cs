// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3DUserDefinedAnnotation.xml' path='doc/member[@name="ID3DUserDefinedAnnotation"]/*' />
[Guid("B2DAAD8B-03D4-4DBF-95EB-32AB4B63D0AB")]
[NativeTypeName("struct ID3DUserDefinedAnnotation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DUserDefinedAnnotation : ID3DUserDefinedAnnotation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3DUserDefinedAnnotation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, Guid*, void**, int>)(lpVtbl[0]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, uint>)(lpVtbl[1]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, uint>)(lpVtbl[2]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DUserDefinedAnnotation.xml' path='doc/member[@name="ID3DUserDefinedAnnotation.BeginEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public int BeginEvent([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, ushort*, int>)(lpVtbl[3]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3DUserDefinedAnnotation.xml' path='doc/member[@name="ID3DUserDefinedAnnotation.EndEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public int EndEvent()
    {
        return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, int>)(lpVtbl[4]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DUserDefinedAnnotation.xml' path='doc/member[@name="ID3DUserDefinedAnnotation.SetMarker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetMarker([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        ((delegate* unmanaged<ID3DUserDefinedAnnotation*, ushort*, void>)(lpVtbl[5]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3DUserDefinedAnnotation.xml' path='doc/member[@name="ID3DUserDefinedAnnotation.GetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL GetStatus()
    {
        return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, int>)(lpVtbl[6]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        int BeginEvent([NativeTypeName("LPCWSTR")] ushort* Name);

        [VtblIndex(4)]
        int EndEvent();

        [VtblIndex(5)]
        void SetMarker([NativeTypeName("LPCWSTR")] ushort* Name);

        [VtblIndex(6)]
        BOOL GetStatus();
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

        [NativeTypeName("INT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> BeginEvent;

        [NativeTypeName("INT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndEvent;

        [NativeTypeName("void (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, void> SetMarker;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetStatus;
    }
}
