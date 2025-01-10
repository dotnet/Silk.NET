// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SPVOICESTATUS
{
    [NativeTypeName("ULONG")]
    public uint ulCurrentStream;

    [NativeTypeName("ULONG")]
    public uint ulLastStreamQueued;
    public HRESULT hrLastResult;

    [NativeTypeName("DWORD")]
    public uint dwRunningState;

    [NativeTypeName("ULONG")]
    public uint ulInputWordPos;

    [NativeTypeName("ULONG")]
    public uint ulInputWordLen;

    [NativeTypeName("ULONG")]
    public uint ulInputSentPos;

    [NativeTypeName("ULONG")]
    public uint ulInputSentLen;

    [NativeTypeName("LONG")]
    public int lBookmarkId;

    [NativeTypeName("SPPHONEID")]
    public ushort PhonemeId;
    public SPVISEMES VisemeId;

    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    [NativeTypeName("DWORD")]
    public uint dwReserved2;
}
