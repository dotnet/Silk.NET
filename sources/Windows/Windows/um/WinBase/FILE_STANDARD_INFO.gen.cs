// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_STANDARD_INFO.xml' path='doc/member[@name="FILE_STANDARD_INFO"]/*'/>
public partial struct FILE_STANDARD_INFO
{
    /// <include file='FILE_STANDARD_INFO.xml' path='doc/member[@name="FILE_STANDARD_INFO.AllocationSize"]/*'/>
    public LARGE_INTEGER AllocationSize;
    /// <include file='FILE_STANDARD_INFO.xml' path='doc/member[@name="FILE_STANDARD_INFO.EndOfFile"]/*'/>
    public LARGE_INTEGER EndOfFile;
    /// <include file='FILE_STANDARD_INFO.xml' path='doc/member[@name="FILE_STANDARD_INFO.NumberOfLinks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfLinks;
    /// <include file='FILE_STANDARD_INFO.xml' path='doc/member[@name="FILE_STANDARD_INFO.DeletePending"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte DeletePending;
    /// <include file='FILE_STANDARD_INFO.xml' path='doc/member[@name="FILE_STANDARD_INFO.Directory"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Directory;
}