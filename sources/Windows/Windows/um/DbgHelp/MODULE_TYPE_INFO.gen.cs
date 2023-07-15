// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MODULE_TYPE_INFO.xml' path='doc/member[@name="MODULE_TYPE_INFO"]/*'/>
public unsafe partial struct MODULE_TYPE_INFO
{
    /// <include file='MODULE_TYPE_INFO.xml' path='doc/member[@name="MODULE_TYPE_INFO.dataLength"]/*'/>
    public ushort dataLength;
    /// <include file='MODULE_TYPE_INFO.xml' path='doc/member[@name="MODULE_TYPE_INFO.leaf"]/*'/>
    public ushort leaf;
    /// <include file='MODULE_TYPE_INFO.xml' path='doc/member[@name="MODULE_TYPE_INFO.data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte data[1];
}