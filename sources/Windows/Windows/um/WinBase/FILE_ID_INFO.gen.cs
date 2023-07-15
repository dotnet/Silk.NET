// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_ID_INFO.xml' path='doc/member[@name="FILE_ID_INFO"]/*'/>
public partial struct FILE_ID_INFO
{
    /// <include file='FILE_ID_INFO.xml' path='doc/member[@name="FILE_ID_INFO.VolumeSerialNumber"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong VolumeSerialNumber;
    /// <include file='FILE_ID_INFO.xml' path='doc/member[@name="FILE_ID_INFO.FileId"]/*'/>
    public FILE_ID_128 FileId;
}