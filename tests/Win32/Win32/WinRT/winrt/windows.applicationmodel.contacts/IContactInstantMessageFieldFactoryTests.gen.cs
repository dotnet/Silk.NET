// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IContactInstantMessageFieldFactory"/> struct.</summary>
public static unsafe partial class IContactInstantMessageFieldFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IContactInstantMessageFieldFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IContactInstantMessageFieldFactory).GUID,
            Is.EqualTo(IID_IContactInstantMessageFieldFactory)
        );
    }

    /// <summary>Validates that the <see cref = "IContactInstantMessageFieldFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IContactInstantMessageFieldFactory>(),
            Is.EqualTo(sizeof(IContactInstantMessageFieldFactory))
        );
    }

    /// <summary>Validates that the <see cref = "IContactInstantMessageFieldFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContactInstantMessageFieldFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IContactInstantMessageFieldFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContactInstantMessageFieldFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContactInstantMessageFieldFactory), Is.EqualTo(4));
        }
    }
}
