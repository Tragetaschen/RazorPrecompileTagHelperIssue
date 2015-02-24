using Microsoft.AspNet.Mvc;
using System;

namespace Repro.compiler.preprocess
{
    public class RazorPreCompilation : RazorPreCompileModule
    {
        public RazorPreCompilation(IServiceProvider provider) : base(provider)
        {
            Console.WriteLine("Running precompilation");
        }
    }
}
