// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPrint"/> struct.</summary>
public static unsafe partial class IPrintTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPrint"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPrint).GUID, Is.EqualTo(IID_IPrint));
    }

    /// <summary>Validates that the <see cref = "IPrint"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPrint>(), Is.EqualTo(sizeof(IPrint)));
    }

    /// <summary>Validates that the <see cref = "IPrint"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPrint).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPrint"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPrint), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPrint), Is.EqualTo(4));
        }
    }
}