// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DRAGDROP
{
    [NativeTypeName("#define DRAGDROP_E_FIRST 0x80040100L")]
    public const uint DRAGDROP_E_FIRST = 0x80040100;

    [NativeTypeName("#define DRAGDROP_E_LAST 0x8004010FL")]
    public const uint DRAGDROP_E_LAST = 0x8004010F;

    [NativeTypeName("#define DRAGDROP_S_FIRST 0x00040100L")]
    public const int DRAGDROP_S_FIRST = 0x00040100;

    [NativeTypeName("#define DRAGDROP_S_LAST 0x0004010FL")]
    public const int DRAGDROP_S_LAST = 0x0004010F;

    [NativeTypeName("#define DRAGDROP_E_NOTREGISTERED _HRESULT_TYPEDEF_(0x80040100L)")]
    public const int DRAGDROP_E_NOTREGISTERED = unchecked((int)(0x80040100));

    [NativeTypeName("#define DRAGDROP_E_ALREADYREGISTERED _HRESULT_TYPEDEF_(0x80040101L)")]
    public const int DRAGDROP_E_ALREADYREGISTERED = unchecked((int)(0x80040101));

    [NativeTypeName("#define DRAGDROP_E_INVALIDHWND _HRESULT_TYPEDEF_(0x80040102L)")]
    public const int DRAGDROP_E_INVALIDHWND = unchecked((int)(0x80040102));

    [NativeTypeName("#define DRAGDROP_E_CONCURRENT_DRAG_ATTEMPTED _HRESULT_TYPEDEF_(0x80040103L)")]
    public const int DRAGDROP_E_CONCURRENT_DRAG_ATTEMPTED = unchecked((int)(0x80040103));

    [NativeTypeName("#define DRAGDROP_S_DROP _HRESULT_TYPEDEF_(0x00040100L)")]
    public const int DRAGDROP_S_DROP = ((int)(0x00040100));

    [NativeTypeName("#define DRAGDROP_S_CANCEL _HRESULT_TYPEDEF_(0x00040101L)")]
    public const int DRAGDROP_S_CANCEL = ((int)(0x00040101));

    [NativeTypeName("#define DRAGDROP_S_USEDEFAULTCURSORS _HRESULT_TYPEDEF_(0x00040102L)")]
    public const int DRAGDROP_S_USEDEFAULTCURSORS = ((int)(0x00040102));
}
