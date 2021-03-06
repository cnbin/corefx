﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;
using OLEDB.Test.ModuleCore;
using XmlReaderTest.Common;

namespace XmlReaderTest.ReaderSettingsTest
{
    public partial class TCCloseInput : TCXMLReaderBaseGeneral
    {
        // Type is XmlReaderTest.ReaderSettingsTest.TCCloseInput
        // Test Case
        public override void AddChildren()
        {
            // for function v1
            {
                this.AddChild(new CVariation(v1) { Attribute = new Variation("Default Values") { Priority = 0 } });
            }
        }
    }
}
