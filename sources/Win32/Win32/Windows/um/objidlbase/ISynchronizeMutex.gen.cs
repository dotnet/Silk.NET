// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000025-0000-0000-C000-000000000046")]
[NativeTypeName("struct ISynchronizeMutex : ISynchronize")]
[NativeInheritance("ISynchronize")]
public unsafe partial struct ISynchronizeMutex : ISynchronizeMutex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISynchronizeMutex));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISynchronizeMutex, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISynchronizeMutex, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISynchronizeMutex, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Wait(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwMilliseconds
    )
    {
        return ((delegate* unmanaged<ISynchronizeMutex, uint, uint, int>)((*lpVtbl)[3]))(
            this,
            dwFlags,
            dwMilliseconds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Signal()
    {
        return ((delegate* unmanaged<ISynchronizeMutex, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ISynchronizeMutex, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReleaseMutex()
    {
        return ((delegate* unmanaged<ISynchronizeMutex, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : ISynchronize.Interface
    {
        [VtblIndex(6)]
        HRESULT ReleaseMutex();
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

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Wait;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Signal;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseMutex;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISynchronizeMutex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISynchronizeMutex(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISynchronize"/> to <see cref = "ISynchronizeMutex"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISynchronize"/> instance to be converted </param>
    public static explicit operator ISynchronizeMutex(Silk.NET.Windows.ISynchronize value)
    {
        return new ISynchronizeMutex(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISynchronizeMutex"/> to <see cref = "Silk.NET.Windows.ISynchronize"/>.</summary>
    /// <param name = "value">The <see cref = "ISynchronizeMutex"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISynchronize(ISynchronizeMutex value)
    {
        return new Silk.NET.Windows.ISynchronize(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISynchronizeMutex"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISynchronizeMutex(Silk.NET.Windows.IUnknown value)
    {
        return new ISynchronizeMutex(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISynchronizeMutex"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISynchronizeMutex"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISynchronizeMutex value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
