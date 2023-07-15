// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='PropertyItem.xml' path='doc/member[@name="PropertyItem"]/*'/>
public unsafe partial struct PropertyItem
{
    /// <include file='PropertyItem.xml' path='doc/member[@name="PropertyItem.id"]/*'/>
    [NativeTypeName("PROPID")]
    public uint id;
    /// <include file='PropertyItem.xml' path='doc/member[@name="PropertyItem.length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint length;
    /// <include file='PropertyItem.xml' path='doc/member[@name="PropertyItem.type"]/*'/>
    [NativeTypeName("WORD")]
    public ushort type;
    /// <include file='PropertyItem.xml' path='doc/member[@name="PropertyItem.value"]/*'/>
    public void* value;
}