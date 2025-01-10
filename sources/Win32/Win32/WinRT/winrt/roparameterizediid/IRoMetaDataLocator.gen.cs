// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public unsafe partial struct IRoMetaDataLocator : IRoMetaDataLocator.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT Locate(
        [NativeTypeName("PCWSTR")] ushort* nameElement,
        [NativeTypeName("IRoSimpleMetaDataBuilder &")] IRoSimpleMetaDataBuilder* metaDataDestination
    )
    {
        return (
            (delegate* unmanaged<IRoMetaDataLocator*, ushort*, IRoSimpleMetaDataBuilder*, int>)(
                (*lpVtbl)[0]
            )
        )((IRoMetaDataLocator*)Unsafe.AsPointer(ref this), nameElement, metaDataDestination);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT Locate(
            [NativeTypeName("PCWSTR")] ushort* nameElement,
            [NativeTypeName("IRoSimpleMetaDataBuilder &")]
                IRoSimpleMetaDataBuilder* metaDataDestination
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName(
            "HRESULT (PCWSTR, IRoSimpleMetaDataBuilder &) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, IRoSimpleMetaDataBuilder*, int> Locate;
    }
}
