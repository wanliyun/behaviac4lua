/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015-2017 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using Behaviac.Design;
using PluginBehaviac.Properties;
using Behaviac.Design.Attributes;
using Behaviac.Design.Nodes;
using Behaviac.Design.Attachments;

namespace PluginBehaviac.Nodes
{
    [NodeDesc("Composites:EventHandling", "waitforSignal_ico")]
    public class WaitforSignal : Behaviac.Design.Nodes.Impulse
    {
        public WaitforSignal()
        : base(Resources.WaitforSignal, Resources.WaitforSignalDesc)
        {
        }

        public override string DocLink
        {
            get
            {
                return "https://www.behaviac.com/waitforsignal/";
            }
        }

        public override string ExportClass
        {
            get
            {
                return "WaitforSignal";
            }
        }

        protected override void CloneProperties(Node newNode)
        {
            base.CloneProperties(newNode);
        }


        public override void CheckForErrors(BehaviorNode rootBehavior, List<ErrorCheck> result)
        {
            if (this._signal.ChildCount == 0)
            {
                result.Add(new Node.ErrorCheck(this, ErrorCheckLevel.Error, Resources.ImpulseWithoutEventError));
            }

            base.CheckForErrors(rootBehavior, result);
        }

    }
}
