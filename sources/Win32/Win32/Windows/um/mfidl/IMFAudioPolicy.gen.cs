// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A0638C2B-6465-4395-9AE7-A321A9FD2856")]
[NativeTypeName("struct IMFAudioPolicy : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFAudioPolicy : IMFAudioPolicy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFAudioPolicy));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFAudioPolicy, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFAudioPolicy, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFAudioPolicy, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGroupingParam([NativeTypeName("const GUID &")] Guid* rguidClass)
    {
        return ((delegate* unmanaged<IMFAudioPolicy, Guid*, int>)((*lpVtbl)[3]))(this, rguidClass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGroupingParam(Guid* pguidClass)
    {
        return ((delegate* unmanaged<IMFAudioPolicy, Guid*, int>)((*lpVtbl)[4]))(this, pguidClass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszName)
    {
        return ((delegate* unmanaged<IMFAudioPolicy, ushort*, int>)((*lpVtbl)[5]))(this, pszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pszName)
    {
        return ((delegate* unmanaged<IMFAudioPolicy, ushort**, int>)((*lpVtbl)[6]))(this, pszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* pszPath)
    {
        return ((delegate* unmanaged<IMFAudioPolicy, ushort*, int>)((*lpVtbl)[7]))(this, pszPath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pszPath)
    {
        return ((delegate* unmanaged<IMFAudioPolicy, ushort**, int>)((*lpVtbl)[8]))(this, pszPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetGroupingParam([NativeTypeName("const GUID &")] Guid* rguidClass);

        [VtblIndex(4)]
        HRESULT GetGroupingParam(Guid* pguidClass);

        [VtblIndex(5)]
        HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszName);

        [VtblIndex(6)]
        HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pszName);

        [VtblIndex(7)]
        HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [VtblIndex(8)]
        HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pszPath);
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

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetGroupingParam;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGroupingParam;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDisplayName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetIconPath;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetIconPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFAudioPolicy"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFAudioPolicy(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFAudioPolicy"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFAudioPolicy(Silk.NET.Windows.IUnknown value)
    {
        return new IMFAudioPolicy(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFAudioPolicy"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFAudioPolicy"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFAudioPolicy value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
