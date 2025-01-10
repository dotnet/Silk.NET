// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8")]
[NativeTypeName("struct IAudioSessionEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSessionEnumerator
    : IAudioSessionEnumerator.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionEnumerator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionEnumerator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioSessionEnumerator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionEnumerator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(int* SessionCount)
    {
        return ((delegate* unmanaged<IAudioSessionEnumerator, int*, int>)((*lpVtbl)[3]))(
            this,
            SessionCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSession(int SessionCount, IAudioSessionControl* Session)
    {
        return (
            (delegate* unmanaged<IAudioSessionEnumerator, int, IAudioSessionControl*, int>)(
                (*lpVtbl)[4]
            )
        )(this, SessionCount, Session);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(int* SessionCount);

        [VtblIndex(4)]
        HRESULT GetSession(int SessionCount, IAudioSessionControl* Session);
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

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetCount;

        [NativeTypeName("HRESULT (int, IAudioSessionControl **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IAudioSessionControl*, int> GetSession;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioSessionEnumerator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioSessionEnumerator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioSessionEnumerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioSessionEnumerator(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioSessionEnumerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSessionEnumerator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSessionEnumerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioSessionEnumerator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
