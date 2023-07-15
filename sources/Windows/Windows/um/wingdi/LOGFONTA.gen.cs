// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA"]/*'/>
public unsafe partial struct LOGFONTA
{
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfHeight"]/*'/>
    [NativeTypeName("LONG")]
    public int lfHeight;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfWidth"]/*'/>
    [NativeTypeName("LONG")]
    public int lfWidth;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfEscapement"]/*'/>
    [NativeTypeName("LONG")]
    public int lfEscapement;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfOrientation"]/*'/>
    [NativeTypeName("LONG")]
    public int lfOrientation;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfWeight"]/*'/>
    [NativeTypeName("LONG")]
    public int lfWeight;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfItalic"]/*'/>
    public byte lfItalic;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfUnderline"]/*'/>
    public byte lfUnderline;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfStrikeOut"]/*'/>
    public byte lfStrikeOut;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfCharSet"]/*'/>
    public byte lfCharSet;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfOutPrecision"]/*'/>
    public byte lfOutPrecision;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfClipPrecision"]/*'/>
    public byte lfClipPrecision;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfQuality"]/*'/>
    public byte lfQuality;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfPitchAndFamily"]/*'/>
    public byte lfPitchAndFamily;
    /// <include file='LOGFONTA.xml' path='doc/member[@name="LOGFONTA.lfFaceName"]/*'/>
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte lfFaceName[32];
}