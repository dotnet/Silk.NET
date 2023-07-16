// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.WinRT;
/// <include file='MLOperatorParameterOptions.xml' path='doc/member[@name="MLOperatorParameterOptions"]/*'/>
[NativeTypeName("uint32_t")]
[Flags]
public enum MLOperatorParameterOptions : uint
{
    /// <include file='MLOperatorParameterOptions.xml' path='doc/member[@name="MLOperatorParameterOptions.Single"]/*'/>
    Single = 0,
    /// <include file='MLOperatorParameterOptions.xml' path='doc/member[@name="MLOperatorParameterOptions.Optional"]/*'/>
    Optional = 1,
    /// <include file='MLOperatorParameterOptions.xml' path='doc/member[@name="MLOperatorParameterOptions.Variadic"]/*'/>
    Variadic = 2,
}