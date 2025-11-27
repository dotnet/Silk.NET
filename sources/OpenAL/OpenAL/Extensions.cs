// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL;

public partial class AL
{
    public static void ThrowError()
    {
        var err = GetError();
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenALException(err);
            Throw(err);
        }
    }
}

public partial class ALContext
{
    public static void ThrowError(DeviceHandle device)
    {
        var err = GetError(device);
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenALException(err);
            Throw(err);
        }
    }
}

public static class Extensions
{
    public static void ThrowError(this IAL al)
    {
        var err = al.GetError();
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenALException(err);
            Throw(err);
        }
    }

    public static void ThrowError(this IALContext alc, DeviceHandle device)
    {
        var err = alc.GetError(device);
        if (err != ErrorCode.NoError)
        {
            static void Throw(ErrorCode err) => throw new OpenALException(err);
            Throw(err);
        }
    }
}
