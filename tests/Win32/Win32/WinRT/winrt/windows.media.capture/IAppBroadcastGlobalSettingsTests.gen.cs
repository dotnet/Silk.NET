// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IAppBroadcastGlobalSettings"/> struct.</summary>
public static unsafe partial class IAppBroadcastGlobalSettingsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppBroadcastGlobalSettings"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IAppBroadcastGlobalSettings).GUID,
            Is.EqualTo(IID_IAppBroadcastGlobalSettings)
        );
    }

    /// <summary>Validates that the <see cref = "IAppBroadcastGlobalSettings"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAppBroadcastGlobalSettings>(),
            Is.EqualTo(sizeof(IAppBroadcastGlobalSettings))
        );
    }

    /// <summary>Validates that the <see cref = "IAppBroadcastGlobalSettings"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppBroadcastGlobalSettings).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppBroadcastGlobalSettings"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppBroadcastGlobalSettings), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppBroadcastGlobalSettings), Is.EqualTo(4));
        }
    }
}
