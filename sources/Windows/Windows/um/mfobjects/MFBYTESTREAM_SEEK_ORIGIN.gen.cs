// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFBYTESTREAM_SEEK_ORIGIN.xml' path='doc/member[@name="MFBYTESTREAM_SEEK_ORIGIN"]/*'/>
public enum MFBYTESTREAM_SEEK_ORIGIN
{
    /// <include file='MFBYTESTREAM_SEEK_ORIGIN.xml' path='doc/member[@name="MFBYTESTREAM_SEEK_ORIGIN.msoBegin"]/*'/>
    msoBegin = 0,
    /// <include file='MFBYTESTREAM_SEEK_ORIGIN.xml' path='doc/member[@name="MFBYTESTREAM_SEEK_ORIGIN.msoCurrent"]/*'/>
    msoCurrent = (msoBegin + 1),
}