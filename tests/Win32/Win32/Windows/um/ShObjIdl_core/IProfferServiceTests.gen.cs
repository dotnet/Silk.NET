// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IProfferService"/> struct.</summary>
public static unsafe partial class IProfferServiceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IProfferService"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IProfferService).GUID, Is.EqualTo(IID_IProfferService));
    }

    /// <summary>Validates that the <see cref = "IProfferService"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IProfferService>(), Is.EqualTo(sizeof(IProfferService)));
    }

    /// <summary>Validates that the <see cref = "IProfferService"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IProfferService).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IProfferService"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IProfferService), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IProfferService), Is.EqualTo(4));
        }
    }
}
