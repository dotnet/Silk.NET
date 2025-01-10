// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510841-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IScriptEventHandlerSourceInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IScriptEventHandlerSourceInfo
    : IScriptEventHandlerSourceInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScriptEventHandlerSourceInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IScriptEventHandlerSourceInfo, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IScriptEventHandlerSourceInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IScriptEventHandlerSourceInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSourceInfo(
        [NativeTypeName("BSTR *")] ushort** pbstrFunctionName,
        [NativeTypeName("UINT32 *")] uint* line,
        [NativeTypeName("UINT32 *")] uint* column,
        [NativeTypeName("UINT32 *")] uint* cchLength
    )
    {
        return (
            (delegate* unmanaged<
                IScriptEventHandlerSourceInfo,
                ushort**,
                uint*,
                uint*,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, pbstrFunctionName, line, column, cchLength);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSourceInfo(
            [NativeTypeName("BSTR *")] ushort** pbstrFunctionName,
            [NativeTypeName("UINT32 *")] uint* line,
            [NativeTypeName("UINT32 *")] uint* column,
            [NativeTypeName("UINT32 *")] uint* cchLength
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

        [NativeTypeName("HRESULT (BSTR *, UINT32 *, UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, uint*, uint*, int> GetSourceInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IScriptEventHandlerSourceInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IScriptEventHandlerSourceInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IScriptEventHandlerSourceInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IScriptEventHandlerSourceInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IScriptEventHandlerSourceInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IScriptEventHandlerSourceInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IScriptEventHandlerSourceInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IScriptEventHandlerSourceInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
