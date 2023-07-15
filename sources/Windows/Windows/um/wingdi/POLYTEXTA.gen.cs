// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POLYTEXTA.xml' path='doc/member[@name="POLYTEXTA"]/*'/>
public unsafe partial struct POLYTEXTA
{
    /// <include file='POLYTEXTA.xml' path='doc/member[@name="POLYTEXTA.x"]/*'/>
    public int x;
    /// <include file='POLYTEXTA.xml' path='doc/member[@name="POLYTEXTA.y"]/*'/>
    public int y;
    /// <include file='POLYTEXTA.xml' path='doc/member[@name="POLYTEXTA.n"]/*'/>
    public uint n;
    /// <include file='POLYTEXTA.xml' path='doc/member[@name="POLYTEXTA.lpstr"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpstr;
    /// <include file='POLYTEXTA.xml' path='doc/member[@name="POLYTEXTA.uiFlags"]/*'/>
    public uint uiFlags;
    /// <include file='POLYTEXTA.xml' path='doc/member[@name="POLYTEXTA.rcl"]/*'/>
    public RECT rcl;
    /// <include file='POLYTEXTA.xml' path='doc/member[@name="POLYTEXTA.pdx"]/*'/>
    public int* pdx;
}