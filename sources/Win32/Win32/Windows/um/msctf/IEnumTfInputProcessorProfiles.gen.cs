// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("71C6E74D-0F28-11D8-A82A-00065B84435C")]
[NativeTypeName("struct IEnumTfInputProcessorProfiles : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTfInputProcessorProfiles
    : IEnumTfInputProcessorProfiles.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTfInputProcessorProfiles));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IEnumTfInputProcessorProfiles, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumTfInputProcessorProfiles, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTfInputProcessorProfiles, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumTfInputProcessorProfiles* ppEnum)
    {
        return (
            (delegate* unmanaged<
                IEnumTfInputProcessorProfiles,
                IEnumTfInputProcessorProfiles*,
                int>)((*lpVtbl)[3])
        )(this, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint ulCount,
        TF_INPUTPROCESSORPROFILE* pProfile,
        [NativeTypeName("ULONG *")] uint* pcFetch
    )
    {
        return (
            (delegate* unmanaged<
                IEnumTfInputProcessorProfiles,
                uint,
                TF_INPUTPROCESSORPROFILE*,
                uint*,
                int>)((*lpVtbl)[4])
        )(this, ulCount, pProfile, pcFetch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTfInputProcessorProfiles, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumTfInputProcessorProfiles, uint, int>)((*lpVtbl)[6]))(
            this,
            ulCount
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumTfInputProcessorProfiles* ppEnum);

        [VtblIndex(4)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint ulCount,
            TF_INPUTPROCESSORPROFILE* pProfile,
            [NativeTypeName("ULONG *")] uint* pcFetch
        );

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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

        [NativeTypeName("HRESULT (IEnumTfInputProcessorProfiles **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfInputProcessorProfiles*, int> Clone;

        [NativeTypeName(
            "HRESULT (ULONG, TF_INPUTPROCESSORPROFILE *, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, TF_INPUTPROCESSORPROFILE*, uint*, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEnumTfInputProcessorProfiles"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEnumTfInputProcessorProfiles(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEnumTfInputProcessorProfiles"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEnumTfInputProcessorProfiles(Silk.NET.Windows.IUnknown value)
    {
        return new IEnumTfInputProcessorProfiles(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEnumTfInputProcessorProfiles"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEnumTfInputProcessorProfiles"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEnumTfInputProcessorProfiles value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
