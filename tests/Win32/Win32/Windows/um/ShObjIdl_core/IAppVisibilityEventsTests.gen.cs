// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IAppVisibilityEvents"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IAppVisibilityEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppVisibilityEvents"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppVisibilityEvents).GUID, Is.EqualTo(IID_IAppVisibilityEvents));
    }

    /// <summary>Validates that the <see cref = "IAppVisibilityEvents"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAppVisibilityEvents>(),
            Is.EqualTo(sizeof(IAppVisibilityEvents))
        );
    }

    /// <summary>Validates that the <see cref = "IAppVisibilityEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppVisibilityEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppVisibilityEvents"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppVisibilityEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppVisibilityEvents), Is.EqualTo(4));
        }
    }
}
