// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.WinRT;
/// <include file='ParentChildRelation.xml' path='doc/member[@name="ParentChildRelation"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct ParentChildRelation
{
    /// <include file='ParentChildRelation.xml' path='doc/member[@name="ParentChildRelation.Parent"]/*'/>
    public InstanceHandle Parent;
    /// <include file='ParentChildRelation.xml' path='doc/member[@name="ParentChildRelation.Child"]/*'/>
    public InstanceHandle Child;
    /// <include file='ParentChildRelation.xml' path='doc/member[@name="ParentChildRelation.ChildIndex"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint ChildIndex;
}