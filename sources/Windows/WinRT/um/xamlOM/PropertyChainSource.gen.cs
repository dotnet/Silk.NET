// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.WinRT;

/// <include file='PropertyChainSource.xml' path='doc/member[@name="PropertyChainSource"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct PropertyChainSource
{
    /// <include file='PropertyChainSource.xml' path='doc/member[@name="PropertyChainSource.Handle"]/*' />
    public InstanceHandle Handle;

    /// <include file='PropertyChainSource.xml' path='doc/member[@name="PropertyChainSource.TargetType"]/*' />
    [NativeTypeName("BSTR")]
    public ushort* TargetType;

    /// <include file='PropertyChainSource.xml' path='doc/member[@name="PropertyChainSource.Name"]/*' />
    [NativeTypeName("BSTR")]
    public ushort* Name;

    /// <include file='PropertyChainSource.xml' path='doc/member[@name="PropertyChainSource.Source"]/*' />
    public BaseValueSource Source;

    /// <include file='PropertyChainSource.xml' path='doc/member[@name="PropertyChainSource.SrcInfo"]/*' />
    public SourceInfo SrcInfo;
}
