// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FaceRectInfoBlobHeader.xml' path='doc/member[@name="FaceRectInfoBlobHeader"]/*'/>
public partial struct FaceRectInfoBlobHeader
{
    /// <include file='FaceRectInfoBlobHeader.xml' path='doc/member[@name="FaceRectInfoBlobHeader.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='FaceRectInfoBlobHeader.xml' path='doc/member[@name="FaceRectInfoBlobHeader.Count"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Count;
}