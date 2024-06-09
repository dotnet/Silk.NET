// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

public unsafe delegate int StorageInterfaceEnumerateDelegate(
    void* arg0,
    sbyte* arg1,
    EnumerateDirectoryCallback arg2,
    void* arg3
);
