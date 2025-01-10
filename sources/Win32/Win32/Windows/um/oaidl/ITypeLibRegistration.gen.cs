// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("76A3E735-02DF-4A12-98EB-043AD3600AF3")]
[NativeTypeName("struct ITypeLibRegistration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITypeLibRegistration : ITypeLibRegistration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITypeLibRegistration));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITypeLibRegistration, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITypeLibRegistration, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGuid(Guid* pGuid)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, Guid*, int>)((*lpVtbl)[3]))(this, pGuid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetVersion([NativeTypeName("BSTR *")] ushort** pVersion)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, ushort**, int>)((*lpVtbl)[4]))(
            this,
            pVersion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLcid([NativeTypeName("LCID *")] uint* pLcid)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, uint*, int>)((*lpVtbl)[5]))(this, pLcid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetWin32Path([NativeTypeName("BSTR *")] ushort** pWin32Path)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pWin32Path
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetWin64Path([NativeTypeName("BSTR *")] ushort** pWin64Path)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, ushort**, int>)((*lpVtbl)[7]))(
            this,
            pWin64Path
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pDisplayName)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, ushort**, int>)((*lpVtbl)[8]))(
            this,
            pDisplayName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pFlags)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, uint*, int>)((*lpVtbl)[9]))(
            this,
            pFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetHelpDir([NativeTypeName("BSTR *")] ushort** pHelpDir)
    {
        return ((delegate* unmanaged<ITypeLibRegistration, ushort**, int>)((*lpVtbl)[10]))(
            this,
            pHelpDir
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetGuid(Guid* pGuid);

        [VtblIndex(4)]
        HRESULT GetVersion([NativeTypeName("BSTR *")] ushort** pVersion);

        [VtblIndex(5)]
        HRESULT GetLcid([NativeTypeName("LCID *")] uint* pLcid);

        [VtblIndex(6)]
        HRESULT GetWin32Path([NativeTypeName("BSTR *")] ushort** pWin32Path);

        [VtblIndex(7)]
        HRESULT GetWin64Path([NativeTypeName("BSTR *")] ushort** pWin64Path);

        [VtblIndex(8)]
        HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pDisplayName);

        [VtblIndex(9)]
        HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pFlags);

        [VtblIndex(10)]
        HRESULT GetHelpDir([NativeTypeName("BSTR *")] ushort** pHelpDir);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGuid;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetVersion;

        [NativeTypeName("HRESULT (LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLcid;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetWin32Path;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetWin64Path;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFlags;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetHelpDir;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITypeLibRegistration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITypeLibRegistration(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITypeLibRegistration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITypeLibRegistration(Silk.NET.Windows.IUnknown value)
    {
        return new ITypeLibRegistration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITypeLibRegistration"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITypeLibRegistration"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITypeLibRegistration value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
