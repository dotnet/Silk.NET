// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_BUS_RESET_REQUEST.xml' path='doc/member[@name="STORAGE_BUS_RESET_REQUEST"]/*'/>
public partial struct STORAGE_BUS_RESET_REQUEST
{
    /// <include file='STORAGE_BUS_RESET_REQUEST.xml' path='doc/member[@name="STORAGE_BUS_RESET_REQUEST.PathId"]/*'/>
    public byte PathId;
}