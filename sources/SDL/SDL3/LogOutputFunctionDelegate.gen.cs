// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

public unsafe delegate void LogOutputFunctionDelegate(
    void* arg0,
    int arg1,
    LogPriority arg2,
    sbyte* arg3
);
