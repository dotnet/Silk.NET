// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE"]/*'/>
public unsafe partial struct SI_COPYFILE
{
    /// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE.SourceFileNameLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SourceFileNameLength;
    /// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE.DestinationFileNameLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DestinationFileNameLength;
    /// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='SI_COPYFILE.xml' path='doc/member[@name="SI_COPYFILE.FileNameBuffer"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort FileNameBuffer[1];
}