﻿using Microsoft.AspNetCore.Components;
using BlazorStrap.Util.Components;
using BlazorComponentUtilities;
using System;
using System.Collections.Generic;

namespace BlazorStrap
{
    public class CodeBSJumbotron : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)] public IDictionary<string, object> UnknownParameters { get; set; }
        protected string classname =>
         new CssBuilder()
             .AddClass("jumbotron jumbotron-fluid", IsFluid)
             .AddClass("jumbotron", !IsFluid)
             .AddClass(Class)
         .Build();

        [Parameter] public bool IsFluid { get; set; }
        [Parameter] public string Class { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
