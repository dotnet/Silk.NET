// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.WinRT;
/// <include file='BitmapDescription.xml' path='doc/member[@name="BitmapDescription"]/*'/>
[SupportedOSPlatform("windows10.0.14393.0")]
public partial struct BitmapDescription
{
    /// <include file='BitmapDescription.xml' path='doc/member[@name="BitmapDescription.Width"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint Width;
    /// <include file='BitmapDescription.xml' path='doc/member[@name="BitmapDescription.Height"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint Height;
    /// <include file='BitmapDescription.xml' path='doc/member[@name="BitmapDescription.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='BitmapDescription.xml' path='doc/member[@name="BitmapDescription.AlphaMode"]/*'/>
    public DXGI_ALPHA_MODE AlphaMode;
}