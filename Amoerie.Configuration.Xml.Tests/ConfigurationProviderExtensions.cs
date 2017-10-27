﻿using System;
using Microsoft.Extensions.Configuration;

namespace Amoerie.Configuration.Xml.Tests
{
  public static class ConfigurationProviderExtensions
  {
    public static string Get(this IConfigurationProvider provider, string key)
    {
      string value;

      if (!provider.TryGet(key, out value))
      {
        throw new InvalidOperationException("Key not found");
      }

      return value;
    }
  }
}