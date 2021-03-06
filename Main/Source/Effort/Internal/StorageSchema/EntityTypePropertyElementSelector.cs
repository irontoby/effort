﻿// --------------------------------------------------------------------------------------------
// <copyright file="EntityTypePropertyElementSelector.cs" company="Effort Team">
//     Copyright (C) 2011-2013 Effort Team
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in
//     all copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//     THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------

namespace Effort.Internal.StorageSchema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Effort.Internal.Common.XmlProcessing;

    internal class EntityTypePropertyElementSelector : IElementSelector
    {
        private StorageSchemaContentNameProvider nameProvider;

        public EntityTypePropertyElementSelector(StorageSchemaContentNameProvider nameProvider)
        {
            if (nameProvider == null)
            {
                throw new ArgumentNullException("nameProvider");
            }

            this.nameProvider = nameProvider;
        }

        public IEnumerable<XElement> SelectElements(XElement root)
        {
            if (root == null)
            {
                throw new ArgumentNullException("root");
            }

            if (root.Name != this.nameProvider.SchemaElement)
            {
                throw new ArgumentException("", "root");
            }

            return root
                .Elements(this.nameProvider.EntityTypeElement)
                .SelectMany(x => x.Elements(this.nameProvider.PropertyElement));
        }
    }
}
