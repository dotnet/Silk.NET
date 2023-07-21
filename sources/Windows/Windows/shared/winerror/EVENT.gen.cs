// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class EVENT
{
    [NativeTypeName("#define EVENT_E_FIRST 0x80040200L")]
    public const uint EVENT_E_FIRST = 0x80040200;

    [NativeTypeName("#define EVENT_E_LAST 0x8004021FL")]
    public const uint EVENT_E_LAST = 0x8004021F;

    [NativeTypeName("#define EVENT_S_FIRST 0x00040200L")]
    public const int EVENT_S_FIRST = 0x00040200;

    [NativeTypeName("#define EVENT_S_LAST 0x0004021FL")]
    public const int EVENT_S_LAST = 0x0004021F;

    [NativeTypeName("#define EVENT_S_SOME_SUBSCRIBERS_FAILED _HRESULT_TYPEDEF_(0x00040200L)")]
    public const int EVENT_S_SOME_SUBSCRIBERS_FAILED = ((int)(0x00040200));

    [NativeTypeName("#define EVENT_E_ALL_SUBSCRIBERS_FAILED _HRESULT_TYPEDEF_(0x80040201L)")]
    public const int EVENT_E_ALL_SUBSCRIBERS_FAILED = unchecked((int)(0x80040201));

    [NativeTypeName("#define EVENT_S_NOSUBSCRIBERS _HRESULT_TYPEDEF_(0x00040202L)")]
    public const int EVENT_S_NOSUBSCRIBERS = ((int)(0x00040202));

    [NativeTypeName("#define EVENT_E_QUERYSYNTAX _HRESULT_TYPEDEF_(0x80040203L)")]
    public const int EVENT_E_QUERYSYNTAX = unchecked((int)(0x80040203));

    [NativeTypeName("#define EVENT_E_QUERYFIELD _HRESULT_TYPEDEF_(0x80040204L)")]
    public const int EVENT_E_QUERYFIELD = unchecked((int)(0x80040204));

    [NativeTypeName("#define EVENT_E_INTERNALEXCEPTION _HRESULT_TYPEDEF_(0x80040205L)")]
    public const int EVENT_E_INTERNALEXCEPTION = unchecked((int)(0x80040205));

    [NativeTypeName("#define EVENT_E_INTERNALERROR _HRESULT_TYPEDEF_(0x80040206L)")]
    public const int EVENT_E_INTERNALERROR = unchecked((int)(0x80040206));

    [NativeTypeName("#define EVENT_E_INVALID_PER_USER_SID _HRESULT_TYPEDEF_(0x80040207L)")]
    public const int EVENT_E_INVALID_PER_USER_SID = unchecked((int)(0x80040207));

    [NativeTypeName("#define EVENT_E_USER_EXCEPTION _HRESULT_TYPEDEF_(0x80040208L)")]
    public const int EVENT_E_USER_EXCEPTION = unchecked((int)(0x80040208));

    [NativeTypeName("#define EVENT_E_TOO_MANY_METHODS _HRESULT_TYPEDEF_(0x80040209L)")]
    public const int EVENT_E_TOO_MANY_METHODS = unchecked((int)(0x80040209));

    [NativeTypeName("#define EVENT_E_MISSING_EVENTCLASS _HRESULT_TYPEDEF_(0x8004020AL)")]
    public const int EVENT_E_MISSING_EVENTCLASS = unchecked((int)(0x8004020A));

    [NativeTypeName("#define EVENT_E_NOT_ALL_REMOVED _HRESULT_TYPEDEF_(0x8004020BL)")]
    public const int EVENT_E_NOT_ALL_REMOVED = unchecked((int)(0x8004020B));

    [NativeTypeName("#define EVENT_E_COMPLUS_NOT_INSTALLED _HRESULT_TYPEDEF_(0x8004020CL)")]
    public const int EVENT_E_COMPLUS_NOT_INSTALLED = unchecked((int)(0x8004020C));

    [NativeTypeName("#define EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT _HRESULT_TYPEDEF_(0x8004020DL)")]
    public const int EVENT_E_CANT_MODIFY_OR_DELETE_UNCONFIGURED_OBJECT = unchecked((int)(0x8004020D));

    [NativeTypeName("#define EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT _HRESULT_TYPEDEF_(0x8004020EL)")]
    public const int EVENT_E_CANT_MODIFY_OR_DELETE_CONFIGURED_OBJECT = unchecked((int)(0x8004020E));

    [NativeTypeName("#define EVENT_E_INVALID_EVENT_CLASS_PARTITION _HRESULT_TYPEDEF_(0x8004020FL)")]
    public const int EVENT_E_INVALID_EVENT_CLASS_PARTITION = unchecked((int)(0x8004020F));

    [NativeTypeName("#define EVENT_E_PER_USER_SID_NOT_LOGGED_ON _HRESULT_TYPEDEF_(0x80040210L)")]
    public const int EVENT_E_PER_USER_SID_NOT_LOGGED_ON = unchecked((int)(0x80040210));
}
