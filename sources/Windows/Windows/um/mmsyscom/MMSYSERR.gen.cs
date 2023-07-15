// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MMSYSERR
{
    [NativeTypeName("#define MMSYSERR_BASE 0")]
    public const int MMSYSERR_BASE = 0;
    [NativeTypeName("#define MMSYSERR_NOERROR 0")]
    public const int MMSYSERR_NOERROR = 0;
    [NativeTypeName("#define MMSYSERR_ERROR (MMSYSERR_BASE + 1)")]
    public const int MMSYSERR_ERROR = (0 + 1);
    [NativeTypeName("#define MMSYSERR_BADDEVICEID (MMSYSERR_BASE + 2)")]
    public const int MMSYSERR_BADDEVICEID = (0 + 2);
    [NativeTypeName("#define MMSYSERR_NOTENABLED (MMSYSERR_BASE + 3)")]
    public const int MMSYSERR_NOTENABLED = (0 + 3);
    [NativeTypeName("#define MMSYSERR_ALLOCATED (MMSYSERR_BASE + 4)")]
    public const int MMSYSERR_ALLOCATED = (0 + 4);
    [NativeTypeName("#define MMSYSERR_INVALHANDLE (MMSYSERR_BASE + 5)")]
    public const int MMSYSERR_INVALHANDLE = (0 + 5);
    [NativeTypeName("#define MMSYSERR_NODRIVER (MMSYSERR_BASE + 6)")]
    public const int MMSYSERR_NODRIVER = (0 + 6);
    [NativeTypeName("#define MMSYSERR_NOMEM (MMSYSERR_BASE + 7)")]
    public const int MMSYSERR_NOMEM = (0 + 7);
    [NativeTypeName("#define MMSYSERR_NOTSUPPORTED (MMSYSERR_BASE + 8)")]
    public const int MMSYSERR_NOTSUPPORTED = (0 + 8);
    [NativeTypeName("#define MMSYSERR_BADERRNUM (MMSYSERR_BASE + 9)")]
    public const int MMSYSERR_BADERRNUM = (0 + 9);
    [NativeTypeName("#define MMSYSERR_INVALFLAG (MMSYSERR_BASE + 10)")]
    public const int MMSYSERR_INVALFLAG = (0 + 10);
    [NativeTypeName("#define MMSYSERR_INVALPARAM (MMSYSERR_BASE + 11)")]
    public const int MMSYSERR_INVALPARAM = (0 + 11);
    [NativeTypeName("#define MMSYSERR_HANDLEBUSY (MMSYSERR_BASE + 12)")]
    public const int MMSYSERR_HANDLEBUSY = (0 + 12);
    [NativeTypeName("#define MMSYSERR_INVALIDALIAS (MMSYSERR_BASE + 13)")]
    public const int MMSYSERR_INVALIDALIAS = (0 + 13);
    [NativeTypeName("#define MMSYSERR_BADDB (MMSYSERR_BASE + 14)")]
    public const int MMSYSERR_BADDB = (0 + 14);
    [NativeTypeName("#define MMSYSERR_KEYNOTFOUND (MMSYSERR_BASE + 15)")]
    public const int MMSYSERR_KEYNOTFOUND = (0 + 15);
    [NativeTypeName("#define MMSYSERR_READERROR (MMSYSERR_BASE + 16)")]
    public const int MMSYSERR_READERROR = (0 + 16);
    [NativeTypeName("#define MMSYSERR_WRITEERROR (MMSYSERR_BASE + 17)")]
    public const int MMSYSERR_WRITEERROR = (0 + 17);
    [NativeTypeName("#define MMSYSERR_DELETEERROR (MMSYSERR_BASE + 18)")]
    public const int MMSYSERR_DELETEERROR = (0 + 18);
    [NativeTypeName("#define MMSYSERR_VALNOTFOUND (MMSYSERR_BASE + 19)")]
    public const int MMSYSERR_VALNOTFOUND = (0 + 19);
    [NativeTypeName("#define MMSYSERR_NODRIVERCB (MMSYSERR_BASE + 20)")]
    public const int MMSYSERR_NODRIVERCB = (0 + 20);
    [NativeTypeName("#define MMSYSERR_MOREDATA (MMSYSERR_BASE + 21)")]
    public const int MMSYSERR_MOREDATA = (0 + 21);
    [NativeTypeName("#define MMSYSERR_LASTERROR (MMSYSERR_BASE + 21)")]
    public const int MMSYSERR_LASTERROR = (0 + 21);
}