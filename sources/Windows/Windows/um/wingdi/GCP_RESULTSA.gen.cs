// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA"]/*'/>
public unsafe partial struct GCP_RESULTSA
{
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lStructSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpOutString"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpOutString;
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpOrder"]/*'/>
    public uint* lpOrder;
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpDx"]/*'/>
    public int* lpDx;
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpCaretPos"]/*'/>
    public int* lpCaretPos;
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpClass"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpClass;
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.lpGlyphs"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpGlyphs;
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.nGlyphs"]/*'/>
    public uint nGlyphs;
    /// <include file='GCP_RESULTSA.xml' path='doc/member[@name="GCP_RESULTSA.nMaxFit"]/*'/>
    public int nMaxFit;
}