// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IShellService"/> struct.</summary>
public static unsafe partial class IShellServiceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IShellService"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellService).GUID, Is.EqualTo(IID_IShellService));
    }

    /// <summary>Validates that the <see cref = "IShellService"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellService>(), Is.EqualTo(sizeof(IShellService)));
    }

    /// <summary>Validates that the <see cref = "IShellService"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellService).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IShellService"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellService), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellService), Is.EqualTo(4));
        }
    }
}
