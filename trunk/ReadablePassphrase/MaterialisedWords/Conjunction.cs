﻿// Copyright 2013 Murray Grant
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MurrayGrant.ReadablePassphrase.Words;

namespace MurrayGrant.ReadablePassphrase.MaterialisedWords
{
    public sealed class MaterialisedConjunction : Conjunction
    {
        private string _Value;
        private bool _SeparatesNouns;
        private bool _SeparatesPhrases;

        public override string Value { get { return _Value; } }
        public override bool SeparatesNouns { get { return _SeparatesNouns; } }
        public override bool SeparatesPhrases { get { return _SeparatesPhrases; } }

        private MaterialisedConjunction() { }
        public MaterialisedConjunction(string value, bool separatesNouns, bool separatesPhrases)
        {
            _Value = value;
            _SeparatesNouns = separatesNouns;
            _SeparatesPhrases = separatesPhrases;
        }
    }
}
