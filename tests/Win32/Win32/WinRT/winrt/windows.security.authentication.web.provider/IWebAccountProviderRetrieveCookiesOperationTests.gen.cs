// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IWebAccountProviderRetrieveCookiesOperation"/> struct.</summary>
public static unsafe partial class IWebAccountProviderRetrieveCookiesOperationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWebAccountProviderRetrieveCookiesOperation"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IWebAccountProviderRetrieveCookiesOperation).GUID,
            Is.EqualTo(IID_IWebAccountProviderRetrieveCookiesOperation)
        );
    }

    /// <summary>Validates that the <see cref = "IWebAccountProviderRetrieveCookiesOperation"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IWebAccountProviderRetrieveCookiesOperation>(),
            Is.EqualTo(sizeof(IWebAccountProviderRetrieveCookiesOperation))
        );
    }

    /// <summary>Validates that the <see cref = "IWebAccountProviderRetrieveCookiesOperation"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(IWebAccountProviderRetrieveCookiesOperation).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "IWebAccountProviderRetrieveCookiesOperation"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWebAccountProviderRetrieveCookiesOperation), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWebAccountProviderRetrieveCookiesOperation), Is.EqualTo(4));
        }
    }
}
