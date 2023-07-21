// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ILineInfo.xml' path='doc/member[@name="ILineInfo"]/*' />
[Guid("3050F7E2-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ILineInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILineInfo : ILineInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILineInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILineInfo*, Guid*, void**, int>)(lpVtbl[0]))((ILineInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILineInfo*, uint>)(lpVtbl[1]))((ILineInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILineInfo*, uint>)(lpVtbl[2]))((ILineInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILineInfo.xml' path='doc/member[@name="ILineInfo.get_x"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_x([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[3]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ILineInfo.xml' path='doc/member[@name="ILineInfo.get_baseLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_baseLine([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[4]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ILineInfo.xml' path='doc/member[@name="ILineInfo.get_textDescent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_textDescent([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[5]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ILineInfo.xml' path='doc/member[@name="ILineInfo.get_textHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_textHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[6]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ILineInfo.xml' path='doc/member[@name="ILineInfo.get_lineDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_lineDirection([NativeTypeName("LONG *")] int* p)
    {
        return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[7]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_x([NativeTypeName("long *")] int* p);

        [VtblIndex(4)]
        HRESULT get_baseLine([NativeTypeName("long *")] int* p);

        [VtblIndex(5)]
        HRESULT get_textDescent([NativeTypeName("long *")] int* p);

        [VtblIndex(6)]
        HRESULT get_textHeight([NativeTypeName("long *")] int* p);

        [VtblIndex(7)]
        HRESULT get_lineDirection([NativeTypeName("LONG *")] int* p);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_x;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_baseLine;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_textDescent;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_textHeight;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_lineDirection;
    }
}
