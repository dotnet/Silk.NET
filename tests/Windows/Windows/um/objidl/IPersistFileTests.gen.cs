// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPersistFile"/> struct.</summary>
public static unsafe partial class IPersistFileTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPersistFile"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPersistFile).GUID, Is.EqualTo(IID_IPersistFile));
    }

    /// <summary>Validates that the <see cref = "IPersistFile"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPersistFile>(), Is.EqualTo(sizeof(IPersistFile)));
    }

    /// <summary>Validates that the <see cref = "IPersistFile"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPersistFile).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPersistFile"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPersistFile), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPersistFile), Is.EqualTo(4));
        }
    }
}