// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("12B81347-1B3A-4A04-AA61-3F768B67FD7E")]
[NativeTypeName("struct IPublishedApp2 : IPublishedApp")]
[NativeInheritance("IPublishedApp")]
public unsafe partial struct IPublishedApp2 : IPublishedApp2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPublishedApp2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPublishedApp2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPublishedApp2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPublishedApp2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAppInfo([NativeTypeName("PAPPINFODATA")] APPINFODATA* pai)
    {
        return ((delegate* unmanaged<IPublishedApp2, APPINFODATA*, int>)((*lpVtbl)[3]))(this, pai);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPossibleActions([NativeTypeName("DWORD *")] uint* pdwActions)
    {
        return ((delegate* unmanaged<IPublishedApp2, uint*, int>)((*lpVtbl)[4]))(this, pdwActions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
    {
        return ((delegate* unmanaged<IPublishedApp2, SLOWAPPINFO*, int>)((*lpVtbl)[5]))(
            this,
            psaid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCachedSlowAppInfo([NativeTypeName("PSLOWAPPINFO")] SLOWAPPINFO* psaid)
    {
        return ((delegate* unmanaged<IPublishedApp2, SLOWAPPINFO*, int>)((*lpVtbl)[6]))(
            this,
            psaid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsInstalled()
    {
        return ((delegate* unmanaged<IPublishedApp2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Install([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall)
    {
        return ((delegate* unmanaged<IPublishedApp2, SYSTEMTIME*, int>)((*lpVtbl)[8]))(
            this,
            pstInstall
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPublishedAppInfo([NativeTypeName("PPUBAPPINFO")] PUBAPPINFO* ppai)
    {
        return ((delegate* unmanaged<IPublishedApp2, PUBAPPINFO*, int>)((*lpVtbl)[9]))(this, ppai);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Unschedule()
    {
        return ((delegate* unmanaged<IPublishedApp2, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Install2(
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall,
        HWND hwndParent
    )
    {
        return ((delegate* unmanaged<IPublishedApp2, SYSTEMTIME*, HWND, int>)((*lpVtbl)[11]))(
            this,
            pstInstall,
            hwndParent
        );
    }

    public interface Interface : IPublishedApp.Interface
    {
        [VtblIndex(11)]
        HRESULT Install2([NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* pstInstall, HWND hwndParent);
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

        [NativeTypeName("HRESULT (PAPPINFODATA) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPINFODATA*, int> GetAppInfo;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPossibleActions;

        [NativeTypeName("HRESULT (PSLOWAPPINFO) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SLOWAPPINFO*, int> GetSlowAppInfo;

        [NativeTypeName("HRESULT (PSLOWAPPINFO) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SLOWAPPINFO*, int> GetCachedSlowAppInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsInstalled;

        [NativeTypeName("HRESULT (LPSYSTEMTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYSTEMTIME*, int> Install;

        [NativeTypeName("HRESULT (PPUBAPPINFO) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PUBAPPINFO*, int> GetPublishedAppInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unschedule;

        [NativeTypeName("HRESULT (LPSYSTEMTIME, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYSTEMTIME*, HWND, int> Install2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPublishedApp2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPublishedApp2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPublishedApp"/> to <see cref = "IPublishedApp2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPublishedApp"/> instance to be converted </param>
    public static explicit operator IPublishedApp2(Silk.NET.Windows.IPublishedApp value)
    {
        return new IPublishedApp2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPublishedApp2"/> to <see cref = "Silk.NET.Windows.IPublishedApp"/>.</summary>
    /// <param name = "value">The <see cref = "IPublishedApp2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPublishedApp(IPublishedApp2 value)
    {
        return new Silk.NET.Windows.IPublishedApp(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IShellApp"/> to <see cref = "IPublishedApp2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IShellApp"/> instance to be converted </param>
    public static explicit operator IPublishedApp2(Silk.NET.Windows.IShellApp value)
    {
        return new IPublishedApp2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPublishedApp2"/> to <see cref = "Silk.NET.Windows.IShellApp"/>.</summary>
    /// <param name = "value">The <see cref = "IPublishedApp2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IShellApp(IPublishedApp2 value)
    {
        return new Silk.NET.Windows.IShellApp(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPublishedApp2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPublishedApp2(Silk.NET.Windows.IUnknown value)
    {
        return new IPublishedApp2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPublishedApp2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPublishedApp2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPublishedApp2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
