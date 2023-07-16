// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;

namespace Silk.NET.WinRT;
/// <include file='MLOperatorExecutionType.xml' path='doc/member[@name="MLOperatorExecutionType"]/*'/>
[NativeTypeName("uint32_t")]
public enum MLOperatorExecutionType : uint
{
    /// <include file='MLOperatorExecutionType.xml' path='doc/member[@name="MLOperatorExecutionType.Undefined"]/*'/>
    Undefined = 0,
    /// <include file='MLOperatorExecutionType.xml' path='doc/member[@name="MLOperatorExecutionType.Cpu"]/*'/>
    Cpu = 1,
    /// <include file='MLOperatorExecutionType.xml' path='doc/member[@name="MLOperatorExecutionType.D3D12"]/*'/>
    D3D12 = 2,
}