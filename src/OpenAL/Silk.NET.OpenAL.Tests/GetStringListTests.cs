// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.OpenAL.Extensions.Creative;
using Silk.NET.OpenAL.Extensions.Enumeration;
using Silk.NET.OpenAL.Extensions.EXT;
using Xunit;

namespace Silk.NET.OpenAL.Tests;

public class GetStringListTests
{
    // the tests in here don't work in CI because CI doesn't have the stuff OpenAL Soft needs.
    [RunnableInDebugOnly]
    public unsafe void GetEnumerateAllContextStringList()
    {
        using var alc = ALContext.GetApi(true);
        var dev = alc.OpenDevice(string.Empty);
        if (dev != null && alc.TryGetExtension(dev, out EnumerateAll ext))
        {
            ext.GetStringList(dev, Extensions.Creative.GetEnumerateAllContextStringList.AllDevicesSpecifier);
        }
        else
        {
            throw new($"dev {(nint) dev}, ext not loaded");
        }

        Assert.True(alc.CloseDevice(dev));
    }

    [RunnableInDebugOnly]
    public unsafe void GetCaptureContextStringList()
    {
        using var alc = ALContext.GetApi(true);
        var dev = alc.OpenDevice(string.Empty);
        if (dev != null && alc.TryGetExtension(dev, out CaptureEnumerationEnumeration ext))
        {
            ext.GetStringList(dev, Extensions.EXT.Enumeration.GetCaptureContextStringList.CaptureDeviceSpecifiers);
        }
        else
        {
            throw new($"dev {(nint) dev}, ext not loaded");
        }

        Assert.True(alc.CloseDevice(dev));
    }

    [RunnableInDebugOnly]
    public unsafe void GetEnumerationContextStringList()
    {
        using var alc = ALContext.GetApi(true);
        var dev = alc.OpenDevice(string.Empty);
        if (dev != null && alc.TryGetExtension(dev, out Enumeration ext))
        {
            ext.GetStringList(dev, Extensions.Enumeration.GetEnumerationContextStringList.DeviceSpecifiers);
        }
        else
        {
            throw new($"dev {(nint) dev}, ext not loaded");
        }

        Assert.True(alc.CloseDevice(dev));
    }
}
