// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SD_ENUM_SDS_INPUT.xml' path='doc/member[@name="SD_ENUM_SDS_INPUT"]/*'/>
public partial struct SD_ENUM_SDS_INPUT
{
    /// <include file='SD_ENUM_SDS_INPUT.xml' path='doc/member[@name="SD_ENUM_SDS_INPUT.StartingOffset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong StartingOffset;
    /// <include file='SD_ENUM_SDS_INPUT.xml' path='doc/member[@name="SD_ENUM_SDS_INPUT.MaxSDEntriesToReturn"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MaxSDEntriesToReturn;
}