// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9C4-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IHlinkTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHlinkTarget : IHlinkTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHlinkTarget));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHlinkTarget, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHlinkTarget, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHlinkTarget, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBrowseContext(IHlinkBrowseContext pihlbc)
    {
        return ((delegate* unmanaged<IHlinkTarget, IHlinkBrowseContext, int>)((*lpVtbl)[3]))(
            this,
            pihlbc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBrowseContext(IHlinkBrowseContext* ppihlbc)
    {
        return ((delegate* unmanaged<IHlinkTarget, IHlinkBrowseContext*, int>)((*lpVtbl)[4]))(
            this,
            ppihlbc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Navigate(
        [NativeTypeName("DWORD")] uint grfHLNF,
        [NativeTypeName("LPCWSTR")] ushort* pwzJumpLocation
    )
    {
        return ((delegate* unmanaged<IHlinkTarget, uint, ushort*, int>)((*lpVtbl)[5]))(
            this,
            grfHLNF,
            pwzJumpLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMoniker(
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("DWORD")] uint dwAssign,
        IMoniker* ppimkLocation
    )
    {
        return ((delegate* unmanaged<IHlinkTarget, ushort*, uint, IMoniker*, int>)((*lpVtbl)[6]))(
            this,
            pwzLocation,
            dwAssign,
            ppimkLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFriendlyName(
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPWSTR *")] ushort** ppwzFriendlyName
    )
    {
        return ((delegate* unmanaged<IHlinkTarget, ushort*, ushort**, int>)((*lpVtbl)[7]))(
            this,
            pwzLocation,
            ppwzFriendlyName
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBrowseContext(IHlinkBrowseContext pihlbc);

        [VtblIndex(4)]
        HRESULT GetBrowseContext(IHlinkBrowseContext* ppihlbc);

        [VtblIndex(5)]
        HRESULT Navigate(
            [NativeTypeName("DWORD")] uint grfHLNF,
            [NativeTypeName("LPCWSTR")] ushort* pwzJumpLocation
        );

        [VtblIndex(6)]
        HRESULT GetMoniker(
            [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
            [NativeTypeName("DWORD")] uint dwAssign,
            IMoniker* ppimkLocation
        );

        [VtblIndex(7)]
        HRESULT GetFriendlyName(
            [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
            [NativeTypeName("LPWSTR *")] ushort** ppwzFriendlyName
        );
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

        [NativeTypeName("HRESULT (IHlinkBrowseContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHlinkBrowseContext, int> SetBrowseContext;

        [NativeTypeName("HRESULT (IHlinkBrowseContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHlinkBrowseContext*, int> GetBrowseContext;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> Navigate;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IMoniker*, int> GetMoniker;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetFriendlyName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHlinkTarget"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHlinkTarget(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHlinkTarget"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHlinkTarget(Silk.NET.Windows.IUnknown value)
    {
        return new IHlinkTarget(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHlinkTarget"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHlinkTarget"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHlinkTarget value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
