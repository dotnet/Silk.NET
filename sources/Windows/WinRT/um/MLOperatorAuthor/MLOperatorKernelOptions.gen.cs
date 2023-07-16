// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.WinRT;
/// <include file='MLOperatorKernelOptions.xml' path='doc/member[@name="MLOperatorKernelOptions"]/*'/>
[NativeTypeName("uint32_t")]
[Flags]
public enum MLOperatorKernelOptions : uint
{
    /// <include file='MLOperatorKernelOptions.xml' path='doc/member[@name="MLOperatorKernelOptions.None"]/*'/>
    None = 0,
    /// <include file='MLOperatorKernelOptions.xml' path='doc/member[@name="MLOperatorKernelOptions.AllowDynamicInputShapes"]/*'/>
    AllowDynamicInputShapes = 1,
}