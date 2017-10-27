// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.IO;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Amoerie.Configuration.Xml.Tests
{
  public class XmlConfigurationExtensionsTest
  {
    [Fact]
    public void AddXmlFile_ThrowsIfFileDoesNotExistAtPath()
    {
      var config = new ConfigurationBuilder().AddXmlFile("NotExistingConfig.xml");

      // Arrange
      // Act and Assert
      new Action(() => config.Build()).ShouldThrow<FileNotFoundException>()
        .And.Message.Should()
        .StartWith(
          $"The configuration file 'NotExistingConfig.xml' was not found and is not optional. The physical path is '");
    }
  }
}