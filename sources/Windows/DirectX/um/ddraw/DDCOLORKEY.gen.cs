// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DDCOLORKEY.xml' path='doc/member[@name="DDCOLORKEY"]/*'/>
public partial struct DDCOLORKEY
{
    /// <include file='DDCOLORKEY.xml' path='doc/member[@name="DDCOLORKEY.dwColorSpaceLowValue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwColorSpaceLowValue;
    /// <include file='DDCOLORKEY.xml' path='doc/member[@name="DDCOLORKEY.dwColorSpaceHighValue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwColorSpaceHighValue;
}