// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5CADDC63-01D3-4C97-986F-0533483FEE14")]
[NativeTypeName("struct IToastNotificationHistory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationHistory
    : IToastNotificationHistory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotificationHistory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IToastNotificationHistory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IToastNotificationHistory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IToastNotificationHistory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IToastNotificationHistory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IToastNotificationHistory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IToastNotificationHistory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveGroup(HSTRING group)
    {
        return ((delegate* unmanaged<IToastNotificationHistory, HSTRING, int>)((*lpVtbl)[6]))(
            this,
            group
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveGroupWithId(HSTRING group, HSTRING applicationId)
    {
        return (
            (delegate* unmanaged<IToastNotificationHistory, HSTRING, HSTRING, int>)((*lpVtbl)[7])
        )(this, group, applicationId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveGroupedTagWithId(HSTRING tag, HSTRING group, HSTRING applicationId)
    {
        return (
            (delegate* unmanaged<IToastNotificationHistory, HSTRING, HSTRING, HSTRING, int>)(
                (*lpVtbl)[8]
            )
        )(this, tag, group, applicationId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveGroupedTag(HSTRING tag, HSTRING group)
    {
        return (
            (delegate* unmanaged<IToastNotificationHistory, HSTRING, HSTRING, int>)((*lpVtbl)[9])
        )(this, tag, group);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Remove(HSTRING tag)
    {
        return ((delegate* unmanaged<IToastNotificationHistory, HSTRING, int>)((*lpVtbl)[10]))(
            this,
            tag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IToastNotificationHistory, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ClearWithId(HSTRING applicationId)
    {
        return ((delegate* unmanaged<IToastNotificationHistory, HSTRING, int>)((*lpVtbl)[12]))(
            this,
            applicationId
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RemoveGroup(HSTRING group);

        [VtblIndex(7)]
        HRESULT RemoveGroupWithId(HSTRING group, HSTRING applicationId);

        [VtblIndex(8)]
        HRESULT RemoveGroupedTagWithId(HSTRING tag, HSTRING group, HSTRING applicationId);

        [VtblIndex(9)]
        HRESULT RemoveGroupedTag(HSTRING tag, HSTRING group);

        [VtblIndex(10)]
        HRESULT Remove(HSTRING tag);

        [VtblIndex(11)]
        HRESULT Clear();

        [VtblIndex(12)]
        HRESULT ClearWithId(HSTRING applicationId);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> RemoveGroup;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> RemoveGroupWithId;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, HSTRING, int> RemoveGroupedTagWithId;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> RemoveGroupedTag;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> ClearWithId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IToastNotificationHistory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IToastNotificationHistory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IToastNotificationHistory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IToastNotificationHistory(Silk.NET.WinRT.IInspectable value)
    {
        return new IToastNotificationHistory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotificationHistory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotificationHistory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IToastNotificationHistory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IToastNotificationHistory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IToastNotificationHistory(Silk.NET.Windows.IUnknown value)
    {
        return new IToastNotificationHistory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IToastNotificationHistory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IToastNotificationHistory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IToastNotificationHistory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
