// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPC_IMAGE.xml' path='doc/member[@name="SPC_IMAGE"]/*'/>
public unsafe partial struct SPC_IMAGE
{
    /// <include file='SPC_IMAGE.xml' path='doc/member[@name="SPC_IMAGE.pImageLink"]/*'/>
    [NativeTypeName("struct SPC_LINK_ *")]
    public SPC_LINK* pImageLink;
    /// <include file='SPC_IMAGE.xml' path='doc/member[@name="SPC_IMAGE.Bitmap"]/*'/>
    public CRYPT_DATA_BLOB Bitmap;
    /// <include file='SPC_IMAGE.xml' path='doc/member[@name="SPC_IMAGE.Metafile"]/*'/>
    public CRYPT_DATA_BLOB Metafile;
    /// <include file='SPC_IMAGE.xml' path='doc/member[@name="SPC_IMAGE.EnhancedMetafile"]/*'/>
    public CRYPT_DATA_BLOB EnhancedMetafile;
    /// <include file='SPC_IMAGE.xml' path='doc/member[@name="SPC_IMAGE.GifFile"]/*'/>
    public CRYPT_DATA_BLOB GifFile;
}