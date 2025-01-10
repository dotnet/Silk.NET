// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_DURATION_DESCRIPTION
{
    public WS_DURATION minValue;
    public WS_DURATION maxValue;

    [NativeTypeName("WS_DURATION_COMPARISON_CALLBACK")]
    public delegate* unmanaged<WS_DURATION*, WS_DURATION*, int*, void*, HRESULT> comparer;
}
