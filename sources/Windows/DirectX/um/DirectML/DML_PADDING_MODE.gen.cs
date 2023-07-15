// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE"]/*'/>
public enum DML_PADDING_MODE
{
    /// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE.DML_PADDING_MODE_CONSTANT"]/*'/>
    DML_PADDING_MODE_CONSTANT,
    /// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE.DML_PADDING_MODE_EDGE"]/*'/>
    DML_PADDING_MODE_EDGE,
    /// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE.DML_PADDING_MODE_REFLECTION"]/*'/>
    DML_PADDING_MODE_REFLECTION,
    /// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE.DML_PADDING_MODE_SYMMETRIC"]/*'/>
    DML_PADDING_MODE_SYMMETRIC,
}