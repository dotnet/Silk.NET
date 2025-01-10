// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.sharetarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2246BAB8-D0F8-41C1-A82A-4137DB6504FB")]
[NativeTypeName("struct IShareOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShareOperation : IShareOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShareOperation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShareOperation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShareOperation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShareOperation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IShareOperation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IShareOperation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IShareOperation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Data(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")]
            IDataPackageView* value
    )
    {
        return ((delegate* unmanaged<IShareOperation, IDataPackageView*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_QuickLinkId(HSTRING* value)
    {
        return ((delegate* unmanaged<IShareOperation, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveThisQuickLink()
    {
        return ((delegate* unmanaged<IShareOperation, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReportStarted()
    {
        return ((delegate* unmanaged<IShareOperation, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReportDataRetrieved()
    {
        return ((delegate* unmanaged<IShareOperation, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReportSubmittedBackgroundTask()
    {
        return ((delegate* unmanaged<IShareOperation, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReportCompletedWithQuickLink(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::ShareTarget::IQuickLink *")]
            IQuickLink quicklink
    )
    {
        return ((delegate* unmanaged<IShareOperation, IQuickLink, int>)((*lpVtbl)[12]))(
            this,
            quicklink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReportCompleted()
    {
        return ((delegate* unmanaged<IShareOperation, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReportError(HSTRING value)
    {
        return ((delegate* unmanaged<IShareOperation, HSTRING, int>)((*lpVtbl)[14]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Data(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")]
                IDataPackageView* value
        );

        [VtblIndex(7)]
        HRESULT get_QuickLinkId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT RemoveThisQuickLink();

        [VtblIndex(9)]
        HRESULT ReportStarted();

        [VtblIndex(10)]
        HRESULT ReportDataRetrieved();

        [VtblIndex(11)]
        HRESULT ReportSubmittedBackgroundTask();

        [VtblIndex(12)]
        HRESULT ReportCompletedWithQuickLink(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::ShareTarget::IQuickLink *"
            )]
                IQuickLink quicklink
        );

        [VtblIndex(13)]
        HRESULT ReportCompleted();

        [VtblIndex(14)]
        HRESULT ReportError(HSTRING value);
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataPackageView*, int> get_Data;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_QuickLinkId;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveThisQuickLink;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReportStarted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReportDataRetrieved;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReportSubmittedBackgroundTask;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::ShareTarget::IQuickLink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IQuickLink, int> ReportCompletedWithQuickLink;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReportCompleted;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> ReportError;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShareOperation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShareOperation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IShareOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IShareOperation(Silk.NET.WinRT.IInspectable value)
    {
        return new IShareOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShareOperation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IShareOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IShareOperation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShareOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShareOperation(Silk.NET.Windows.IUnknown value)
    {
        return new IShareOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShareOperation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShareOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShareOperation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
