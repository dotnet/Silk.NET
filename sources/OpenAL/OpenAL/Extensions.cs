// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL;

public partial class Al
{
    public static void ThrowError()
    {
        var err = GetError();
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenAlException(err);
            Throw(err);
        }
    }
}

public partial class AlContext
{
    public static void ThrowError(DeviceHandle device)
    {
        var err = GetError(device);
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenAlException(err);
            Throw(err);
        }
    }
}

public static class Extensions
{
    public static void ThrowError(this IAl al)
    {
        var err = al.GetError();
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenAlException(err);
            Throw(err);
        }
    }

    public static void ThrowError(this IAlContext alc, DeviceHandle device)
    {
        var err = alc.GetError(device);
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenAlException(err);
            Throw(err);
        }
    }
}
