// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DML_IS_INFINITY_MODE.xml' path='doc/member[@name="DML_IS_INFINITY_MODE"]/*'/>
public enum DML_IS_INFINITY_MODE
{
    /// <include file='DML_IS_INFINITY_MODE.xml' path='doc/member[@name="DML_IS_INFINITY_MODE.DML_IS_INFINITY_MODE_EITHER"]/*'/>
    DML_IS_INFINITY_MODE_EITHER = 0,
    /// <include file='DML_IS_INFINITY_MODE.xml' path='doc/member[@name="DML_IS_INFINITY_MODE.DML_IS_INFINITY_MODE_POSITIVE"]/*'/>
    DML_IS_INFINITY_MODE_POSITIVE = 1,
    /// <include file='DML_IS_INFINITY_MODE.xml' path='doc/member[@name="DML_IS_INFINITY_MODE.DML_IS_INFINITY_MODE_NEGATIVE"]/*'/>
    DML_IS_INFINITY_MODE_NEGATIVE = 2,
}