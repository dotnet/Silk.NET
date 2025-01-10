// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IContactsProviderActivatedEventArgs"/> struct.</summary>
public static unsafe partial class IContactsProviderActivatedEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IContactsProviderActivatedEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IContactsProviderActivatedEventArgs).GUID,
            Is.EqualTo(IID_IContactsProviderActivatedEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IContactsProviderActivatedEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IContactsProviderActivatedEventArgs>(),
            Is.EqualTo(sizeof(IContactsProviderActivatedEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IContactsProviderActivatedEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContactsProviderActivatedEventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IContactsProviderActivatedEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContactsProviderActivatedEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContactsProviderActivatedEventArgs), Is.EqualTo(4));
        }
    }
}
