// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DML_BUFFER_ARRAY_BINDING.xml' path='doc/member[@name="DML_BUFFER_ARRAY_BINDING"]/*'/>
public unsafe partial struct DML_BUFFER_ARRAY_BINDING
{
    /// <include file='DML_BUFFER_ARRAY_BINDING.xml' path='doc/member[@name="DML_BUFFER_ARRAY_BINDING.BindingCount"]/*'/>
    public uint BindingCount;
    /// <include file='DML_BUFFER_ARRAY_BINDING.xml' path='doc/member[@name="DML_BUFFER_ARRAY_BINDING.Bindings"]/*'/>
    [NativeTypeName("const DML_BUFFER_BINDING *")]
    public DML_BUFFER_BINDING* Bindings;
}