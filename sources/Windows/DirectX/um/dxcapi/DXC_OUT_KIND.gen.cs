// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
namespace TerraFX.Interop.DirectX;
/// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND"]/*'/>
public enum DXC_OUT_KIND
{
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_NONE"]/*'/>
    DXC_OUT_NONE = 0,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_OBJECT"]/*'/>
    DXC_OUT_OBJECT = 1,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_ERRORS"]/*'/>
    DXC_OUT_ERRORS = 2,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_PDB"]/*'/>
    DXC_OUT_PDB = 3,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_SHADER_HASH"]/*'/>
    DXC_OUT_SHADER_HASH = 4,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_DISASSEMBLY"]/*'/>
    DXC_OUT_DISASSEMBLY = 5,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_HLSL"]/*'/>
    DXC_OUT_HLSL = 6,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_TEXT"]/*'/>
    DXC_OUT_TEXT = 7,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_REFLECTION"]/*'/>
    DXC_OUT_REFLECTION = 8,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_ROOT_SIGNATURE"]/*'/>
    DXC_OUT_ROOT_SIGNATURE = 9,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_EXTRA_OUTPUTS"]/*'/>
    DXC_OUT_EXTRA_OUTPUTS = 10,
    /// <include file='DXC_OUT_KIND.xml' path='doc/member[@name="DXC_OUT_KIND.DXC_OUT_FORCE_DWORD"]/*'/>
    DXC_OUT_FORCE_DWORD = unchecked((int)(0xFFFFFFFF)),
}