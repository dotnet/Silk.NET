// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes"]/*'/>
public partial struct DVD_VideoAttributes
{
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.fPanscanPermitted"]/*'/>
    public BOOL fPanscanPermitted;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.fLetterboxPermitted"]/*'/>
    public BOOL fLetterboxPermitted;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.ulAspectX"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulAspectX;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.ulAspectY"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulAspectY;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.ulFrameRate"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulFrameRate;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.ulFrameHeight"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulFrameHeight;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.Compression"]/*'/>
    public DVD_VIDEO_COMPRESSION Compression;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.fLine21Field1InGOP"]/*'/>
    public BOOL fLine21Field1InGOP;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.fLine21Field2InGOP"]/*'/>
    public BOOL fLine21Field2InGOP;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.ulSourceResolutionX"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSourceResolutionX;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.ulSourceResolutionY"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSourceResolutionY;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.fIsSourceLetterboxed"]/*'/>
    public BOOL fIsSourceLetterboxed;
    /// <include file='DVD_VideoAttributes.xml' path='doc/member[@name="DVD_VideoAttributes.fIsFilmMode"]/*'/>
    public BOOL fIsFilmMode;
}