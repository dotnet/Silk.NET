// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ISpatialEntityFactory"/> struct.</summary>
public static unsafe partial class ISpatialEntityFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISpatialEntityFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpatialEntityFactory).GUID, Is.EqualTo(IID_ISpatialEntityFactory));
    }

    /// <summary>Validates that the <see cref = "ISpatialEntityFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ISpatialEntityFactory>(),
            Is.EqualTo(sizeof(ISpatialEntityFactory))
        );
    }

    /// <summary>Validates that the <see cref = "ISpatialEntityFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISpatialEntityFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISpatialEntityFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISpatialEntityFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISpatialEntityFactory), Is.EqualTo(4));
        }
    }
}
