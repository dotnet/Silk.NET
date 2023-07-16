// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IContactManager"/> struct.</summary>
public static unsafe partial class IContactManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IContactManager"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IContactManager).GUID, Is.EqualTo(IID_IContactManager));
    }

    /// <summary>Validates that the <see cref = "IContactManager"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IContactManager>(), Is.EqualTo(sizeof(IContactManager)));
    }

    /// <summary>Validates that the <see cref = "IContactManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContactManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IContactManager"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContactManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContactManager), Is.EqualTo(4));
        }
    }
}