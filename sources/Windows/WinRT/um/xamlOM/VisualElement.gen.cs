// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.WinRT;

/// <include file='VisualElement.xml' path='doc/member[@name="VisualElement"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct VisualElement
{
    /// <include file='VisualElement.xml' path='doc/member[@name="VisualElement.Handle"]/*' />
    public InstanceHandle Handle;

    /// <include file='VisualElement.xml' path='doc/member[@name="VisualElement.SrcInfo"]/*' />
    public SourceInfo SrcInfo;

    /// <include file='VisualElement.xml' path='doc/member[@name="VisualElement.Type"]/*' />
    [NativeTypeName("BSTR")]
    public ushort* Type;

    /// <include file='VisualElement.xml' path='doc/member[@name="VisualElement.Name"]/*' />
    [NativeTypeName("BSTR")]
    public ushort* Name;

    /// <include file='VisualElement.xml' path='doc/member[@name="VisualElement.NumChildren"]/*' />
    [NativeTypeName("unsigned int")]
    public uint NumChildren;
}
