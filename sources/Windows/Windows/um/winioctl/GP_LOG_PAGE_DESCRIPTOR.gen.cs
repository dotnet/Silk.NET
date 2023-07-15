// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='GP_LOG_PAGE_DESCRIPTOR.xml' path='doc/member[@name="GP_LOG_PAGE_DESCRIPTOR"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct GP_LOG_PAGE_DESCRIPTOR
{
    /// <include file='GP_LOG_PAGE_DESCRIPTOR.xml' path='doc/member[@name="GP_LOG_PAGE_DESCRIPTOR.LogAddress"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LogAddress;
    /// <include file='GP_LOG_PAGE_DESCRIPTOR.xml' path='doc/member[@name="GP_LOG_PAGE_DESCRIPTOR.LogSectors"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LogSectors;
}