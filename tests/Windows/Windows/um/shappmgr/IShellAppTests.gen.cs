// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IShellApp"/> struct.</summary>
public static unsafe partial class IShellAppTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IShellApp"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellApp).GUID, Is.EqualTo(IID_IShellApp));
    }

    /// <summary>Validates that the <see cref = "IShellApp"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellApp>(), Is.EqualTo(sizeof(IShellApp)));
    }

    /// <summary>Validates that the <see cref = "IShellApp"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellApp).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IShellApp"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellApp), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellApp), Is.EqualTo(4));
        }
    }
}