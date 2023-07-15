// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/coml2api.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STGOPTIONS.xml' path='doc/member[@name="STGOPTIONS"]/*'/>
public unsafe partial struct STGOPTIONS
{
    /// <include file='STGOPTIONS.xml' path='doc/member[@name="STGOPTIONS.usVersion"]/*'/>
    public ushort usVersion;
    /// <include file='STGOPTIONS.xml' path='doc/member[@name="STGOPTIONS.reserved"]/*'/>
    public ushort reserved;
    /// <include file='STGOPTIONS.xml' path='doc/member[@name="STGOPTIONS.ulSectorSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSectorSize;
    /// <include file='STGOPTIONS.xml' path='doc/member[@name="STGOPTIONS.pwcsTemplateFile"]/*'/>
    [NativeTypeName("const WCHAR *")]
    public ushort* pwcsTemplateFile;
}