// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/knownfolderpathscom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F12EF0B5-BEFB-46C9-9EE5-8A0681F13F8C")]
[NativeTypeName("struct IUserDataPathsInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUserDataPathsInterop : IUserDataPathsInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataPathsInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUserDataPathsInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_AdminTools([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, ushort**, int>)((*lpVtbl)[3]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_CDBurning([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, ushort**, int>)((*lpVtbl)[4]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_NetworkShortcuts([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, ushort**, int>)((*lpVtbl)[5]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Programs([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, ushort**, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SendTo([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, ushort**, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_StartMenu([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, ushort**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Startup([NativeTypeName("LPWSTR *")] ushort** value)
    {
        return ((delegate* unmanaged<IUserDataPathsInterop, ushort**, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_AdminTools([NativeTypeName("LPWSTR *")] ushort** value);

        [VtblIndex(4)]
        HRESULT get_CDBurning([NativeTypeName("LPWSTR *")] ushort** value);

        [VtblIndex(5)]
        HRESULT get_NetworkShortcuts([NativeTypeName("LPWSTR *")] ushort** value);

        [VtblIndex(6)]
        HRESULT get_Programs([NativeTypeName("LPWSTR *")] ushort** value);

        [VtblIndex(7)]
        HRESULT get_SendTo([NativeTypeName("LPWSTR *")] ushort** value);

        [VtblIndex(8)]
        HRESULT get_StartMenu([NativeTypeName("LPWSTR *")] ushort** value);

        [VtblIndex(9)]
        HRESULT get_Startup([NativeTypeName("LPWSTR *")] ushort** value);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_AdminTools;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_CDBurning;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_NetworkShortcuts;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Programs;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_SendTo;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_StartMenu;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Startup;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserDataPathsInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserDataPathsInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserDataPathsInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserDataPathsInterop(Silk.NET.Windows.IUnknown value)
    {
        return new IUserDataPathsInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataPathsInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataPathsInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUserDataPathsInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
