// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_CHANGE_TYPE.xml' path='doc/member[@name="D2D1_CHANGE_TYPE"]/*'/>
[Flags]
public enum D2D1_CHANGE_TYPE
{
    /// <include file='D2D1_CHANGE_TYPE.xml' path='doc/member[@name="D2D1_CHANGE_TYPE.D2D1_CHANGE_TYPE_NONE"]/*'/>
    D2D1_CHANGE_TYPE_NONE = 0,
    /// <include file='D2D1_CHANGE_TYPE.xml' path='doc/member[@name="D2D1_CHANGE_TYPE.D2D1_CHANGE_TYPE_PROPERTIES"]/*'/>
    D2D1_CHANGE_TYPE_PROPERTIES = 1,
    /// <include file='D2D1_CHANGE_TYPE.xml' path='doc/member[@name="D2D1_CHANGE_TYPE.D2D1_CHANGE_TYPE_CONTEXT"]/*'/>
    D2D1_CHANGE_TYPE_CONTEXT = 2,
    /// <include file='D2D1_CHANGE_TYPE.xml' path='doc/member[@name="D2D1_CHANGE_TYPE.D2D1_CHANGE_TYPE_GRAPH"]/*'/>
    D2D1_CHANGE_TYPE_GRAPH = 3,
    /// <include file='D2D1_CHANGE_TYPE.xml' path='doc/member[@name="D2D1_CHANGE_TYPE.D2D1_CHANGE_TYPE_FORCE_DWORD"]/*'/>
    D2D1_CHANGE_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}