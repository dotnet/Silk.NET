// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS"]/*' />
public partial struct SPVOICESTATUS
{
    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.ulCurrentStream"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulCurrentStream;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.ulLastStreamQueued"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulLastStreamQueued;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.hrLastResult"]/*' />
    public HRESULT hrLastResult;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.dwRunningState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRunningState;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.ulInputWordPos"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulInputWordPos;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.ulInputWordLen"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulInputWordLen;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.ulInputSentPos"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulInputSentPos;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.ulInputSentLen"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulInputSentLen;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.lBookmarkId"]/*' />
    [NativeTypeName("LONG")]
    public int lBookmarkId;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.PhonemeId"]/*' />
    [NativeTypeName("SPPHONEID")]
    public ushort PhonemeId;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.VisemeId"]/*' />
    public SPVISEMES VisemeId;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='SPVOICESTATUS.xml' path='doc/member[@name="SPVOICESTATUS.dwReserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
}
