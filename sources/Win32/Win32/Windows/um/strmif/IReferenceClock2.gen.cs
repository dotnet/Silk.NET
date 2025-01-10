// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("36B73885-C2C8-11CF-8B46-00805F6CEF60")]
[NativeTypeName("struct IReferenceClock2 : IReferenceClock")]
[NativeInheritance("IReferenceClock")]
public unsafe partial struct IReferenceClock2 : IReferenceClock2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReferenceClock2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IReferenceClock2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IReferenceClock2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IReferenceClock2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTime)
    {
        return ((delegate* unmanaged<IReferenceClock2, long*, int>)((*lpVtbl)[3]))(this, pTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AdviseTime(
        [NativeTypeName("REFERENCE_TIME")] long baseTime,
        [NativeTypeName("REFERENCE_TIME")] long streamTime,
        HEVENT hEvent,
        [NativeTypeName("DWORD_PTR *")] nuint* pdwAdviseCookie
    )
    {
        return (
            (delegate* unmanaged<IReferenceClock2, long, long, HEVENT, nuint*, int>)((*lpVtbl)[4])
        )(this, baseTime, streamTime, hEvent, pdwAdviseCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AdvisePeriodic(
        [NativeTypeName("REFERENCE_TIME")] long startTime,
        [NativeTypeName("REFERENCE_TIME")] long periodTime,
        HSEMAPHORE hSemaphore,
        [NativeTypeName("DWORD_PTR *")] nuint* pdwAdviseCookie
    )
    {
        return (
            (delegate* unmanaged<IReferenceClock2, long, long, HSEMAPHORE, nuint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, startTime, periodTime, hSemaphore, pdwAdviseCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unadvise([NativeTypeName("DWORD_PTR")] nuint dwAdviseCookie)
    {
        return ((delegate* unmanaged<IReferenceClock2, nuint, int>)((*lpVtbl)[6]))(
            this,
            dwAdviseCookie
        );
    }

    public interface Interface : IReferenceClock.Interface { }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetTime;

        [NativeTypeName(
            "HRESULT (REFERENCE_TIME, REFERENCE_TIME, HEVENT, DWORD_PTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, long, long, HEVENT, nuint*, int> AdviseTime;

        [NativeTypeName(
            "HRESULT (REFERENCE_TIME, REFERENCE_TIME, HSEMAPHORE, DWORD_PTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, long, long, HSEMAPHORE, nuint*, int> AdvisePeriodic;

        [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> Unadvise;
    }

    /// <summary>Initializes a new instance of the <see cref = "IReferenceClock2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IReferenceClock2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IReferenceClock"/> to <see cref = "IReferenceClock2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IReferenceClock"/> instance to be converted </param>
    public static explicit operator IReferenceClock2(Silk.NET.Windows.IReferenceClock value)
    {
        return new IReferenceClock2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IReferenceClock2"/> to <see cref = "Silk.NET.Windows.IReferenceClock"/>.</summary>
    /// <param name = "value">The <see cref = "IReferenceClock2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IReferenceClock(IReferenceClock2 value)
    {
        return new Silk.NET.Windows.IReferenceClock(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IReferenceClock2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IReferenceClock2(Silk.NET.Windows.IUnknown value)
    {
        return new IReferenceClock2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IReferenceClock2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IReferenceClock2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IReferenceClock2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
