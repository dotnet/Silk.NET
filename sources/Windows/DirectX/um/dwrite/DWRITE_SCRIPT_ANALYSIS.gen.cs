// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_SCRIPT_ANALYSIS.xml' path='doc/member[@name="DWRITE_SCRIPT_ANALYSIS"]/*'/>
public partial struct DWRITE_SCRIPT_ANALYSIS
{
    /// <include file='DWRITE_SCRIPT_ANALYSIS.xml' path='doc/member[@name="DWRITE_SCRIPT_ANALYSIS.script"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort script;
    /// <include file='DWRITE_SCRIPT_ANALYSIS.xml' path='doc/member[@name="DWRITE_SCRIPT_ANALYSIS.shapes"]/*'/>
    public DWRITE_SCRIPT_SHAPES shapes;
}