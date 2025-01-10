// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E32ABF70-D8FA-45EC-A942-D2E26FB60BA5")]
[NativeTypeName("struct ISystemDataPaths : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemDataPaths : ISystemDataPaths.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemDataPaths));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISystemDataPaths, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISystemDataPaths, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISystemDataPaths, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISystemDataPaths, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISystemDataPaths, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Fonts(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProgramData(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Public(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PublicDesktop(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PublicDocuments(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PublicDownloads(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PublicMusic(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PublicPictures(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PublicVideos(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_System(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SystemHost(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SystemX86(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SystemX64(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_SystemArm(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_UserProfiles(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Windows(HSTRING* value)
    {
        return ((delegate* unmanaged<ISystemDataPaths, HSTRING*, int>)((*lpVtbl)[21]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Fonts(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ProgramData(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Public(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_PublicDesktop(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_PublicDocuments(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_PublicDownloads(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_PublicMusic(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_PublicPictures(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_PublicVideos(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_System(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_SystemHost(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_SystemX86(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_SystemX64(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_SystemArm(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_UserProfiles(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_Windows(HSTRING* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Fonts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ProgramData;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Public;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PublicDesktop;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PublicDocuments;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PublicDownloads;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PublicMusic;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PublicPictures;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PublicVideos;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_System;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SystemHost;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SystemX86;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SystemX64;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SystemArm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserProfiles;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Windows;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISystemDataPaths"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISystemDataPaths(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISystemDataPaths"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISystemDataPaths(Silk.NET.WinRT.IInspectable value)
    {
        return new ISystemDataPaths(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISystemDataPaths"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISystemDataPaths"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISystemDataPaths value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISystemDataPaths"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISystemDataPaths(Silk.NET.Windows.IUnknown value)
    {
        return new ISystemDataPaths(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISystemDataPaths"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISystemDataPaths"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISystemDataPaths value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
