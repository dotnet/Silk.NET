// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ContactManager"/> struct.</summary>
public static unsafe partial class ContactManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ContactManager"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ContactManager).GUID, Is.EqualTo(CLSID_ContactManager));
    }

    /// <summary>Validates that the <see cref = "ContactManager"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ContactManager>(), Is.EqualTo(sizeof(ContactManager)));
    }

    /// <summary>Validates that the <see cref = "ContactManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ContactManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ContactManager"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ContactManager), Is.EqualTo(1));
    }
}
