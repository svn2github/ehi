﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections.Concurrent;

namespace Siemens.EHealth.Client.Sso
{
    internal class MemorySessionCache : ISessionCache
    {
        private static IDictionary<String, XmlElement> cache = new ConcurrentDictionary<String, XmlElement>();

        public XmlElement Get(string id)
        {
            XmlElement token;
            if (cache.TryGetValue(id, out token))
            {
                return token;
            }
            else
            {
                return null;
            }
        }

        public void Add(string id, XmlElement value, DateTime expires)
        {
            cache.Add(id, value);
        }

        public void Remove(string id)
        {
            cache.Remove(id);
        }
    }
}
