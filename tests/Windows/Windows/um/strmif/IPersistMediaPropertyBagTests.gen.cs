// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPersistMediaPropertyBag"/> struct.</summary>
public static unsafe partial class IPersistMediaPropertyBagTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPersistMediaPropertyBag"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPersistMediaPropertyBag).GUID, Is.EqualTo(IID_IPersistMediaPropertyBag));
    }

    /// <summary>Validates that the <see cref = "IPersistMediaPropertyBag"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPersistMediaPropertyBag>(), Is.EqualTo(sizeof(IPersistMediaPropertyBag)));
    }

    /// <summary>Validates that the <see cref = "IPersistMediaPropertyBag"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPersistMediaPropertyBag).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPersistMediaPropertyBag"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPersistMediaPropertyBag), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPersistMediaPropertyBag), Is.EqualTo(4));
        }
    }
}