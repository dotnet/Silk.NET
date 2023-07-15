// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PKU2U_CREDUI_CONTEXT.xml' path='doc/member[@name="PKU2U_CREDUI_CONTEXT"]/*'/>
public partial struct PKU2U_CREDUI_CONTEXT
{
    /// <include file='PKU2U_CREDUI_CONTEXT.xml' path='doc/member[@name="PKU2U_CREDUI_CONTEXT.Version"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong Version;
    /// <include file='PKU2U_CREDUI_CONTEXT.xml' path='doc/member[@name="PKU2U_CREDUI_CONTEXT.cbHeaderLength"]/*'/>
    public ushort cbHeaderLength;
    /// <include file='PKU2U_CREDUI_CONTEXT.xml' path='doc/member[@name="PKU2U_CREDUI_CONTEXT.cbStructureLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbStructureLength;
    /// <include file='PKU2U_CREDUI_CONTEXT.xml' path='doc/member[@name="PKU2U_CREDUI_CONTEXT.CertArrayCount"]/*'/>
    public ushort CertArrayCount;
    /// <include file='PKU2U_CREDUI_CONTEXT.xml' path='doc/member[@name="PKU2U_CREDUI_CONTEXT.CertArrayOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CertArrayOffset;
}