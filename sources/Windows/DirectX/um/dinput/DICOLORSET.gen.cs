// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET"]/*'/>
public partial struct DICOLORSET
{
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.cTextFore"]/*'/>
    [NativeTypeName("D3DCOLOR")]
    public uint cTextFore;
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.cTextHighlight"]/*'/>
    [NativeTypeName("D3DCOLOR")]
    public uint cTextHighlight;
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.cCalloutLine"]/*'/>
    [NativeTypeName("D3DCOLOR")]
    public uint cCalloutLine;
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.cCalloutHighlight"]/*'/>
    [NativeTypeName("D3DCOLOR")]
    public uint cCalloutHighlight;
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.cBorder"]/*'/>
    [NativeTypeName("D3DCOLOR")]
    public uint cBorder;
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.cControlFill"]/*'/>
    [NativeTypeName("D3DCOLOR")]
    public uint cControlFill;
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.cHighlightFill"]/*'/>
    [NativeTypeName("D3DCOLOR")]
    public uint cHighlightFill;
    /// <include file='DICOLORSET.xml' path='doc/member[@name="DICOLORSET.cAreaFill"]/*'/>
    [NativeTypeName("D3DCOLOR")]
    public uint cAreaFill;
}