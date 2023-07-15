// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT"]/*'/>
public unsafe partial struct SCRUB_DATA_INPUT
{
    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.MaximumIos"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumIos;
    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.ObjectId"]/*'/>
    [NativeTypeName("DWORD[4]")]
    public fixed uint ObjectId[4];
    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.Reserved"]/*'/>
    [NativeTypeName("DWORD[41]")]
    public fixed uint Reserved[41];
    /// <include file='SCRUB_DATA_INPUT.xml' path='doc/member[@name="SCRUB_DATA_INPUT.ResumeContext"]/*'/>
    [NativeTypeName("BYTE[1040]")]
    public fixed byte ResumeContext[1040];
}