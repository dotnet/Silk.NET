// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BIND_OPTS3.xml' path='doc/member[@name="BIND_OPTS3"]/*'/>
[NativeTypeName("struct tagBIND_OPTS3 : tagBIND_OPTS2")]
[NativeInheritance("tagBIND_OPTS2")]
public partial struct BIND_OPTS3
{
    public BIND_OPTS2 Base;
    /// <include file='BIND_OPTS3.xml' path='doc/member[@name="BIND_OPTS3.hwnd"]/*'/>
    public HWND hwnd;
}