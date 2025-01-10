// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[SupportedOSPlatform("windows10.0")]
public unsafe partial struct VisualElement
{
    public InstanceHandle Handle;
    public SourceInfo SrcInfo;

    [NativeTypeName("BSTR")]
    public ushort* Type;

    [NativeTypeName("BSTR")]
    public ushort* Name;

    [NativeTypeName("unsigned int")]
    public uint NumChildren;
}
